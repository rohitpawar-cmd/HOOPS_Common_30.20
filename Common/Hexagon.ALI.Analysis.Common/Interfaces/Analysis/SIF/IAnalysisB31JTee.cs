using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF
{
    public interface IAnalysisB31JTee
    {
        [PPMProperty("ReinforcedType", "IAnalysisB31JTee")]
        ReinforcementType? ReinforcedType { get; set; }

        [PPMProperty("NumberOfFlanges", "IAnalysisB31JTee")]
        FlangeNumber? NumberOfFlanges { get; set; }

        [PPMProperty("SurfaceNode", "IAnalysisB31JTee")]
        AnalysisNode SurfaceNode { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty("ReinforcedLength", "IAnalysisB31JTee")]
        string ReinforcedLength { get; set; }
        double? ReinforcedLengthSiValue { get; }

        [UoM("AngleUoM")]
        [PPMProperty("ReinforcedAngleTheta", "IAnalysisB31JTee")]
        string ReinforcedAngleTheta { get; set; }
        double? ReinforcedAngleThetaSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("ReinforcedTaperLargeEnd", "IAnalysisB31JTee")]
        string ReinforcedTaperLargeEnd { get; set; }
        double? ReinforcedTaperLargeEndSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("ReinforcedThickness", "IAnalysisB31JTee")]
        string ReinforcedThickness { get; set; }
        double? ReinforcedThicknessSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("PadThickness", "IAnalysisB31JTee")]
        string PadThickness { get; set; }
        double? PadThicknessSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("ReinforcedRadius", "IAnalysisB31JTee")]
        string ReinforcedRadius { get; set; }
        double? ReinforcedRadiusSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("EffectiveBranchThickness", "IAnalysisB31JTee")]
        string EffectiveBranchThickness { get; set; }
        double? EffectiveBranchThicknessSiValue { get; }
    }
    public enum FlangeNumber
    {
        SingleFlanged = 1,
        DoubleFlanged = 2,
    }
    public enum ReinforcementType
    {
        [Description("1 - (a)")]
        a = 1,
        [Description("2 - (b)")]
        b = 2,
        [Description("3 - (c)")]
        c = 3,
        [Description("4 - (d)")]
        d = 4,
    }
}