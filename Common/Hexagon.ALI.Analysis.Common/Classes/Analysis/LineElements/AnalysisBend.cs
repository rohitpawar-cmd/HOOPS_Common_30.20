using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements
{
    [DefUID("AnalysisBend")]
    public class AnalysisBend : AnalysisPipe, IAnalysisBend, IAnalysisBendTangent
    {
        public AnalysisBend()
        {
        }

        public BendType? BendType { get; set; }
        public string RadiusType { get; set; }
        [NotMapped]
        public string FittingThickness { get; set; }
        public double KFactorIn { get; set; }
        public double KFactorOut { get; set; }
        [NotMapped]
        public string OverlayThickness { get; set; }
        public bool? SeamWelded { get; set; }
        public double? WeldReductionFactor { get; set; }
        public double? FittingThicknessSiValue { get; protected set; }
        public double? OverlayThicknessSiValue { get; protected set; }
        public double? RadiusSiValue { get; protected set; }
        [NotMapped]
        public string Radius { get; set; }
        [NotMapped]
        public string AngleB { get; set; }
        public List<BendNode> BendNodes { get; set; } = new List<BendNode>();
        public string NumberOfMiterCuts { get; set; }
        [NotMapped]
        public string Tbend { get; set; } = null;                                       //Currently no way to determine piping code from input txt file
        public double? AxialModRatio { get; set; }                       //EpTp/(EbTb)     //Currently no way to determine piping code from input txt file
        public double? TbendSiValue { get; protected set; }
        public double? AngleBSiValue { get; protected set; }
        [NotMapped]
        public string SpaceBetweenCuts { get; set; }
        public double? SpaceBetweenCutsSiValue { get; protected set; }
        [NotMapped]
        public string Tangent1X { get; set; }
        [NotMapped]
        public string Tangent1Y { get; set; }
        [NotMapped]
        public string Tangent1Z { get; set; }
        [NotMapped]
        public string Tangent2X { get; set; }
        [NotMapped]
        public string Tangent2Y { get; set; }
        [NotMapped]
        public string Tangent2Z { get; set; }

        public double? Tangent1XSiValue { get; set; }
        public double? Tangent1YSiValue { get; set; }
        public double? Tangent1ZSiValue { get; set; }
        public double? Tangent2XSiValue { get; set; }
        public double? Tangent2YSiValue { get; set; }
        public double? Tangent2ZSiValue { get; set; }

        [NotMapped] public string BendNode1 => BendNodes.ElementAtOrDefault(0)?.AnalysisNode?.NodeNumber ?? "";
        [NotMapped] public string BendNode2 => BendNodes.ElementAtOrDefault(1)?.AnalysisNode?.NodeNumber ?? "";
        [NotMapped] public string BendNode3 => BendNodes.ElementAtOrDefault(2)?.AnalysisNode?.NodeNumber ?? "";
        [NotMapped] public double? Angle1SiValue => BendNodes.ElementAtOrDefault(0)?.AngleSiValue;
        [NotMapped] public double? Angle2SiValue => BendNodes.ElementAtOrDefault(1)?.AngleSiValue;
        [NotMapped] public double? Angle3SiValue => BendNodes.ElementAtOrDefault(2)?.AngleSiValue;

        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? base.ToString().Replace("Element", "Bend") : Name;
        }
    }
}