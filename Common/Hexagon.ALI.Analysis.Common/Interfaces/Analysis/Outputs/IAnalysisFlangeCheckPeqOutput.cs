using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs
{
    public interface IAnalysisFlangeCheckPeqOutput
    {
        [UoM("ForceUoM")]
        [PPMProperty(nameof(Axial), nameof(IAnalysisFlangeCheckPeqOutput))]
        string Axial { get; set; }
        double? AxialSiValue { get; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(PEquivalent), nameof(IAnalysisFlangeCheckPeqOutput))]
        string PEquivalent { get; set; }
        double? PEquivalentSiValue { get; }

        [UoM("TemperatureUoM")]
        [PPMProperty(nameof(Rating), nameof(IAnalysisFlangeOutput))]
        string Rating { get; set; }
        double? RatingSiValue { get; }
    }
}
