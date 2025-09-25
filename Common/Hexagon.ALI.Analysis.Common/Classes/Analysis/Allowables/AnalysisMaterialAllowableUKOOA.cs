using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableUKOOA")]
    public class AnalysisMaterialAllowableUKOOA : AnalysisMaterial, IAnalysisMaterialAllowableUKOOA
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public double? SystemDesignFactor_f2 { get; set; }
        public double? MeanTemperatureChangeMultiplier_K { get; set; }

    }
}
