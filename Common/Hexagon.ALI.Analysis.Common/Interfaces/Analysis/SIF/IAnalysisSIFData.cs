using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF
{
    public interface IAnalysisSIFData
    {

        [PPMProperty("InplaneSIF", "IAnalysisSIF")]
        double? InplaneSIF { get; set; }

        [PPMProperty("InplaneIndex", "IAnalysisSIF")]
        double? InplaneIndex { get; set; }

        [PPMProperty("InplaneFlexibility", "IAnalysisSIF")]
        double? InplaneFlexibility { get; set; }

        [PPMProperty("OutplaneSIF", "IAnalysisSIF")]
        double? OutplaneSIF { get; set; }

        [PPMProperty("OutplaneIndex", "IAnalysisSIF")]
        double? OutplaneIndex { get; set; }

        [PPMProperty("OutplaneFlexibility", "IAnalysisSIF")]
        double? OutplaneFlexibility { get; set; }

        [PPMProperty("TorsionSIF", "IAnalysisSIF")]
        double? TorsionSIF { get; set; }

        [PPMProperty("TorsionIndex", "IAnalysisSIF")]
        double? TorsionIndex { get; set; }

        [PPMProperty("TorsionFlexibility", "IAnalysisSIF")]
        double? TorsionFlexibility { get; set; }

        [PPMProperty("AxialSIF", "IAnalysisSIF")]
        double? AxialSIF { get; set; }

        [PPMProperty("AxialIndex", "IAnalysisSIF")]
        double? AxialIndex { get; set; }

        [PPMProperty("AxialFlexibility", "IAnalysisSIF")]
        double? AxialFlexibility { get; set; }

        [PPMProperty("PressureSIF", "IAnalysisSIF")]
        double? PressureSIF { get; set; }

        [PPMProperty("PressureIndex", "IAnalysisSIF")]
        double? PressureIndex { get; set; }

        [PPMProperty("PressureFlexibility", "IAnalysisSIF")]
        double? PressureFlexibility { get; set; }

        [PPMProperty("ShearSIF", "IAnalysisSIF")]
        double? ShearSIF { get; set; }

        [PPMProperty("ShearIndex", "IAnalysisSIF")]
        double? ShearIndex { get; set; }
    }
}
