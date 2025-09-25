using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Helpers.Objects;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs
{
    [DefUID("AnalysisNozzleLimitCheck")]
    public class AnalysisNozzleLimitCheck : AnalysisNodeAuxiliary, IAnalysisNozzleLimitCheck, IAnalysisLocalForceMoments
    {
        public AnalysisNozzleLimitCheck(AnalysisNode node = null) : base(node)
        {

        }
        public AnalysisNozzleLimitCheck()
        {

        }
        #region PUBLIC PROPERTIES
        public ComparisonMethod? ComparisonMethod
        {
            get; set;
        }

        public double? RefVectorX
        {
            get; set;
        }

        public double? RefVectorY
        {
            get; set;
        }

        public double? RefVectorZ
        {
            get; set;
        }
        [NotMapped]
        public string LocalForceA
        {
            get;
            set;
        }
        [NotMapped]
        public string LocalForceB
        {
            get;
            set;
        }
        [NotMapped]
        public string LocalForceC
        {
            get;
            set;
        }
        [NotMapped]
        public string LocalMomentA
        {
            get;
            set;
        }
        [NotMapped]
        public string LocalMomentB
        {
            get;
            set;
        }
        [NotMapped]
        public string LocalMomentC
        {
            get;
            set;
        }
        #endregion

        #region SI VALUES
        public double? LocalForceASiValue
        {
            get;
            private set;
        }
        public double? LocalForceBSiValue
        {
            get;
            private set;
        }
        public double? LocalForceCSiValue
        {
            get;
            private set;
        }
        public double? LocalMomentASiValue
        {
            get;
            private set;
        }
        public double? LocalMomentBSiValue
        {
            get;
            private set;
        }
        public double? LocalMomentCSiValue
        {
            get;
            private set;
        }
        #endregion

        public override string RetrieveUomType(PropertyHelper propertyHelper)
        {
            if (propertyHelper.UoM.uomtype2 == null)
            {
                return base.RetrieveUomType(propertyHelper);
            }
            UoMAttribute uom = propertyHelper.UoM;
            if (uom.uomtype.Contains(nameof(MomentInputUoM)))
            {
                return uom.uomtype;
            }
            if (uom.uomtype2.Contains(nameof(MomentInputUoM)))
            {
                return uom.uomtype2;
            }
            throw new InvalidOperationException();
        }
    }
}
