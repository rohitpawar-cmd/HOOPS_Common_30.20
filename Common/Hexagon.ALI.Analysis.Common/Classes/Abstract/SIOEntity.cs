using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Helpers.Objects;
using Hexagon.ALI.Analysis.Common.Helpers.Units;
using Hexagon.ALI.Analysis.Common.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("Hexagon.ALI.Analysis.Common.PublisherClipperSDK.Tests")]
[assembly: InternalsVisibleTo("Hexagon.ALI.Analysis.Common.PublisherWebApi.Tests")]
[assembly: InternalsVisibleTo("Hexagon.ALI.Analysis.Common.PublisherClipperSDK")]
[assembly: InternalsVisibleTo("Hexagon.ALI.Analysis.Common.Tests")]
[assembly: InternalsVisibleTo("Hexagon.ALI.Analysis.Common.Entities.Tests")]
[assembly: InternalsVisibleTo("Hexagon.ALI.Analysis.Common.BlService")]
[assembly: InternalsVisibleTo("Hexagon.ALI.Analysis.Common.PublisherWebApi")]
[assembly: InternalsVisibleTo("Hexagon.ALI.Analysis.Piping.ReviewerService.L0.Tests")]


namespace Hexagon.ALI.Analysis.Common.Classes
{
    public abstract class SIOEntity : SIOObject, ISIOEntity
    {
        public bool Generated = false;
        private readonly Guid _InternalID = Guid.NewGuid();

        #region Clipper Common Properties

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        #endregion Clipper Common Properties

        public string InternalID
        {
            get
            {
                return _InternalID.ToString();
            }

        }

        internal void SetUomValues(UnitStore unitsStore)
        {
            var sipropertyInfos = GetType().GetProperties().Where(w => w.Name.Contains("SiValue"));
            var splitDelim = new string[] { "SiValue" };
            if (sipropertyInfos.Any())
            {
                var propNames = sipropertyInfos.Select(s => s.Name.Split(splitDelim, StringSplitOptions.None).First());
                var propertyHelpers = PropertyHelper.GetInterfaces(GetType()).Select(s => s.Value).Where(w => propNames.Contains(w.Name));
                var errorMessageBuilder = new StringBuilder();
                foreach (var propertyHelper in propertyHelpers)
                {
                    var sipropertyInfo = sipropertyInfos.FirstOrDefault(f => string.Equals(f.Name, $"{propertyHelper.Name}SiValue"));
                    var value = propertyHelper.PropertyInfo.GetValue(this);
                    if (value == null)
                    {
                        sipropertyInfo.SetValue(this, null);
                        continue;
                    }
                    if (string.IsNullOrEmpty(value.ToString()))
                    {
                        sipropertyInfo.SetValue(this, null);
                        continue;
                    }

                    if (IsUomValueValid(propertyHelper.PropertyInfo.GetValue(this).ToString(), out string strVal, out double doubleVal, out string errorMessage))
                    {
                        var uomtype = RetrieveUomType(propertyHelper);
                        //Calculate SiValue
                        UserUnits unit = unitsStore.GetUserUnit(uomtype);

                        if (unit != null)
                        {
                            var siValue = (doubleVal - unit.Constant) / unit.ConversionFactorToSI;
                            sipropertyInfo.SetValue(this, siValue);
                            continue;
                        }
                        throw new IncorrectSiValueException($"Unit for uomtype:{uomtype} is null");
                    }
                    else
                    {
                        sipropertyInfo.SetValue(this, null);
                        errorMessageBuilder.AppendLine(errorMessage);
                    }


                }
                if (errorMessageBuilder.Length > 0)
                {
                    throw new IncorrectSiValueException($"Errors when Setting Si Values for {this} :: \r\n {errorMessageBuilder}");
                }

            }
            return;


        }
        public virtual string RetrieveUomType(PropertyHelper propertyHelper)
        {
            if (propertyHelper.UoM.uomtype2 != null)
            {
                throw new InvalidOperationException("Override this Method to handle multiple uom types");
            }

            return propertyHelper.UoM.uomtype;
        }

        internal bool IsUomValueValid(string val, out string strVal, out double doubleVal, out string errorMessage)
        {

            bool result = true;
            errorMessage = "";
            strVal = "";
            int spaceIndex = val.IndexOf(' ');

            if (spaceIndex != -1)
            {
                result = false;
                errorMessage = $"'{val}' is not a valid value";
            }
            else
            {
                strVal = val;
            }
            if (!double.TryParse(strVal, NumberStyles.Float, CultureInfo.InvariantCulture, out doubleVal))
            {

                errorMessage = $"'{val}' is not a number";
                result = false;
            }
            return result;

        }

        public double? GetUserValue(string propertyName, UnitStore units)
        {
            var type = GetType();
            string siPropertyName = $"{propertyName}SiValue";
            var si = PropertyHelper.GetSiValuePropertyInfos(type).First(f => f.Name == siPropertyName);
            var ph = PropertyHelper.GetUoMPropertyInfos(type).First(f => f.Name == propertyName);
            string uomType = RetrieveUomType(ph);
            var userUnits = units.GetUserUnit(uomType);
            var value = si.GetValue(this, null) as double?;
            return value != null ? value * userUnits.ConversionFactorToSI + userUnits.Constant : null;
        }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? base.ToString() : Name;
        }

        #region PROTECTED METHODS
        public List<(SIOEntity Entity, RelDefAttribute RelDef)> Relations = new List<(SIOEntity, RelDefAttribute)>();
        public SIOEntity End1Relation = null;

        #endregion PROTECTED METHODS
    }
}