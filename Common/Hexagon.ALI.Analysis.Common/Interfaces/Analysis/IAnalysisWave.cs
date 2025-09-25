using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisWave
    {
        List<AnalysisLineElement> AnalysisLineElements { get; set; }
        double? DragCoefficient { get; set; }
        double? AddedMassCoefficient { get; set; }
        double? LiftCoefficient { get; set; }
        [UoM("ThicknessUoM")]
        string MarineGrowthThickness { get; set; }
        double? MarineGrowthThicknessSiValue { get; }
        [UoM("FluidDensityUoM")]
        string MarineGrowthDensity { get; set; }
        double? MarineGrowthDensitySiValue { get; }
    }
}
