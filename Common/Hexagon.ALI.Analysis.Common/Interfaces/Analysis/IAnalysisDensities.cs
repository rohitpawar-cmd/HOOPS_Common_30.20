using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisDensities
    {
        List<AnalysisLineElement> AnalysisLineElements { get; set; }
        [UoM("LengthUoM")]
        [PPMProperty(nameof(RefractoryThickness), "IAnalysisDensities")]
        string RefractoryThickness { get; set; }
        [PPMProperty(nameof(RefractoryThicknessSiValue), "IAnalysisDensities")]
        double? RefractoryThicknessSiValue { get; }
        [UoM("InsulationDensityUoM")]
        [PPMProperty(nameof(RefractoryDensity), "IAnalysisDensities")]
        string RefractoryDensity { get; set; }
        [PPMProperty(nameof(RefractoryDensitySiValue), "IAnalysisDensities")]
        double? RefractoryDensitySiValue { get; }
        [UoM("LengthUoM")]
        [PPMProperty(nameof(InsulationThickness), "IAnalysisDensities")]
        string InsulationThickness { get; set; }
        [PPMProperty(nameof(InsulationThicknessSiValue), "IAnalysisDensities")]
        double? InsulationThicknessSiValue { get; }
        [UoM("LengthUoM")]
        [PPMProperty(nameof(CladdingThickness), "IAnalysisDensities")]
        string CladdingThickness { get; set; }
        [PPMProperty(nameof(CladdingThicknessSiValue), "IAnalysisDensities")]
        double? CladdingThicknessSiValue { get; }
        [UoM("InsulationDensityUoM")]
        [PPMProperty(nameof(InsulationDensity), "IAnalysisDensities")]
        string InsulationDensity { get; set; }
        [PPMProperty(nameof(InsulationDensitySiValue), "IAnalysisDensities")]
        double? InsulationDensitySiValue { get; }
        [UoM("InsulationDensityUoM")]
        [PPMProperty(nameof(CladdingDensity), "IAnalysisDensities")]
        string CladdingDensity { get; set; }
        [PPMProperty(nameof(CladdingDensitySiValue), "IAnalysisDensities")]
        double? CladdingDensitySiValue { get; }
        [UoM("UniformLoadUoM")]
        [PPMProperty(nameof(Insulation_CladdingUnitWeight), "IAnalysisDensities")]
        string Insulation_CladdingUnitWeight { get; set; }
        [PPMProperty(nameof(Insulation_CladdingUnitWeightSiValue), "IAnalysisDensities")]
        double? Insulation_CladdingUnitWeightSiValue { get; }

    }
}
