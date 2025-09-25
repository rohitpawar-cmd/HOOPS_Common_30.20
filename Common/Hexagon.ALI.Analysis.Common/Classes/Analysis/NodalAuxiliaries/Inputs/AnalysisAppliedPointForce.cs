using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Helpers.Objects;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs
{
    [DefUID("AnalysisAppliedPointForce")]
    public class AnalysisAppliedPointForce : AnalysisNodeAuxiliary, IAnalysisPointLoad, IAnalysisVectorAuxiliary
    {
        public AnalysisAppliedPointForce(AnalysisNode node = null) : base(node)
        {
        }
        public AnalysisAppliedPointForce() : base()
        {
        }
        [NotMapped]
        public string FX { get; set; }
        [NotMapped]
        public string FY { get; set; }
        [NotMapped]
        public string FZ { get; set; }
        [NotMapped]
        public string MX { get; set; }
        [NotMapped]
        public string MY { get; set; }
        [NotMapped]
        public string MZ { get; set; }

        public double? FXSiValue { get; private set; }
        public double? FYSiValue { get; private set; }
        public double? FZSiValue { get; private set; }
        public double? MXSiValue { get; private set; }
        public double? MYSiValue { get; private set; }
        public double? MZSiValue { get; private set; }
        public AnalysisOperatingPrimitive AnalysisPrimitive { get; set; }
        public string AnalysisPrimitiveId { get; set; }

        [NotMapped]
        public string PrimitiveName => $"{AnalysisPrimitive?.PrimitiveType}{AnalysisPrimitive?.Number}";

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
