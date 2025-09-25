using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries
{
    public interface IAnalysisFlangeCheckPressureRating
    {
        AnalysisFlangeCheckPeq AnalysisFlangeCheckPeq { get; set; }
        string AnalysisFlangeCheckPeqId { get; set; }

        [UoM("TemperatureUoM")]
        [PPMProperty("Temperature", "IAnalysisFlangeCheckPressureRating")]
        string Temperature { get; set; }
        double? TemperatureSiValue { get; }

        [UoM("PressureUoM")]
        [PPMProperty("PressureRating", "IAnalysisFlangeCheckPressureRating")]
        string PressureRating { get; set; }
        double? PressureRatingSiValue { get; }
    }
}
