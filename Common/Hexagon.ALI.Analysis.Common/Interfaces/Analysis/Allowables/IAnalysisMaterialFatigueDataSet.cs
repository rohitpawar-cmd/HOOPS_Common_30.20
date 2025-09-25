using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialFatigueDataSet
    {
        AnalysisMaterial Material { get; set; }
        string AnalysisMaterialId { get; set; }

        [PPMProperty("Cycles", nameof(IAnalysisMaterialFatigueDataSet))]
        double Cycles { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty("Stress", nameof(IAnalysisMaterialFatigueDataSet))]
        string Stress { get; set; }

        double? StressSiValue { get; }
    }
}
