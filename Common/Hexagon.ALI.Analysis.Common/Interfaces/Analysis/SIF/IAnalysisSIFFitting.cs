using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF
{
    public interface IAnalysisSIFFitting
    {
        [PPMProperty("SIFType", "IAnalysisSIFFitting")]
        SIFType? SIFType { get; set; }

        [PPMProperty("SIFOption1", "IAnalysisSIFFitting")]
        bool? SIFOption1 { get; set; }

        [PPMProperty("SIFOption2", "IAnalysisSIFFitting")]
        bool? SIFOption2 { get; set; }

        [PPMProperty("WeldStrFactWc", "IAnalysisSIFFitting")]
        double? WeldStrFactWc { get; set; }

        [PPMProperty("PressureStressMultiplier", "IAnalysisSIFFitting")]
        double? PressureStressMultiplier { get; set; }
    }
}
