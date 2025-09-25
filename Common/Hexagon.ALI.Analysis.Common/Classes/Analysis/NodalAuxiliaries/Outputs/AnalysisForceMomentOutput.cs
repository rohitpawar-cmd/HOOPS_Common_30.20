using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Helpers.Objects;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    [DefUID("AnalysisForceMomentOutput")]
    public abstract class AnalysisForceMomentOutput : AnalysisNodeAuxiliaryOutput, IAnalysisPointLoad
    {
        public AnalysisForceMomentOutput(AnalysisNode node = null, AnalysisLoadCase loadCase = null) : base(node, loadCase)
        {
        }

        #region PRIVATE PROPERTIES
        #endregion

        #region PUBLIC PROPERTIES
        [NotMapped]
        public string FX
        {
            get;
            set;
        }
        [NotMapped]
        public string FY
        {
            get;
            set;
        }
        [NotMapped]
        public string FZ
        {
            get;
            set;
        }
        [NotMapped]
        public string MX
        {
            get;
            set;
        }
        [NotMapped]
        public string MY
        {
            get;
            set;
        }
        [NotMapped]
        public string MZ
        {
            get;
            set;
        }
        #endregion

        #region SI PROPERTIES
        public double? FXSiValue
        {
            get;
            protected set;
        }
        public double? FYSiValue
        {
            get;
            protected set;
        }
        public double? FZSiValue
        {
            get;
            protected set;
        }
        public double? MXSiValue
        {
            get;
            protected set;
        }
        public double? MYSiValue
        {
            get;
            protected set;
        }
        public double? MZSiValue
        {
            get;
            protected set;
        }
        #endregion

        public override string RetrieveUomType(PropertyHelper propertyHelper)
        {
            if (propertyHelper.UoM.uomtype2 == null)
            {
                return base.RetrieveUomType(propertyHelper);
            }
            UoMAttribute uom = propertyHelper.UoM;
            if (uom.uomtype.Contains(nameof(MomentOutputUoM)))
            {
                return uom.uomtype;
            }
            if (uom.uomtype2.Contains(nameof(MomentOutputUoM)))
            {
                return uom.uomtype2;
            }
            throw new InvalidOperationException();
        }
    }

}