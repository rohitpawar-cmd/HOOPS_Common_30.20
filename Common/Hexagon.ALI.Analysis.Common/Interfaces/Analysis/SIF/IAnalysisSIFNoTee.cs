using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF
{
    public interface IAnalysisSIFNoTee
    {
        [PPMProperty("WeldStrFactWc", "IAnalysisSIFNoTee")]
        double? WeldStrFactWc { get; set; }

        [PPMProperty("PressureStressMultiplier", "IAnalysisSIFNoTee")]
        double? PressureStressMultiplier { get; set; }
    }
}
