using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Helpers.Objects;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries
{
    [DefUID("AnalysisUniformLoadDataSet")]
    public class AnalysisUniformLoadDataSet : AnalysisVectorAuxiliary, IAnalysisUniformLoadDataSet, IAnalysisRunAuxiliary
    {
        public AnalysisUniformLoadDataSet(bool uniformLoadType = false)
        {
            UniformLoadType = uniformLoadType;
        }
        public AnalysisUniformLoadDataSet()
        {
            UniformLoadType = false;
        }
        private bool uniformLoadType;
        public bool UniformLoadType
        {
            get { return uniformLoadType; }
            set { ReAssignValues(value); }
        }
        [NotMapped]
        public string UniformLoadX { get; set; }
        public double? UniformLoadXSiValue { get; private set; }
        [NotMapped]
        public string UniformLoadY { get; set; }
        public double? UniformLoadYSiValue { get; private set; }
        [NotMapped]
        public string UniformLoadZ { get; set; }
        public double? UniformLoadZSiValue { get; private set; }
        [RelDef()] public List<AnalysisLineElement> AnalysisLineElements { get; set; }

        private void ReAssignValues(bool value)
        {
            uniformLoadType = value;
            UniformLoadXSiValue = null;
            UniformLoadYSiValue = null;
            UniformLoadZSiValue = null;
        }
        public override string ToString()
        {
            return AnalysisPrimitive?.Name == null ? base.ToString() : $"{AnalysisPrimitive?.Name}";
        }
        public override string RetrieveUomType(PropertyHelper propertyHelper)
        {
            if (propertyHelper.UoM.uomtype2 == null)
            {
                return base.RetrieveUomType(propertyHelper);
            }
            UoMAttribute uom = propertyHelper.UoM;
            if (propertyHelper.Name == nameof(UniformLoadX) || propertyHelper.Name == nameof(UniformLoadY) || propertyHelper.Name == nameof(UniformLoadZ))
            {
                if (uniformLoadType)
                {
                    return uom.uomtype2;
                }
                else
                {
                    return uom.uomtype;
                }
            }
            throw new InvalidOperationException();
        }
    }
}
