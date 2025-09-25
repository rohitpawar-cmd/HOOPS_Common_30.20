using Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisMaterial
    {
        List<AnalysisLineElement> AnalysisLineElements { get; set; }

        [PPMProperty(nameof(MaterialName), nameof(IAnalysisMaterial))]
        string MaterialName { get; set; }

        [PPMProperty(nameof(PoissonsRatio), nameof(IAnalysisMaterial))]
        double? PoissonsRatio { get; set; }

        [UoM("PipeDensityUoM")]
        [PPMProperty("PipeDensity", nameof(IAnalysisMaterial))]
        string PipeDensity { get; set; }

        double? PipeDensitySiValue { get; }

        [UoM("StressUoM")]
        [PPMProperty(nameof(YieldStress), nameof(IAnalysisMaterial))]
        string YieldStress { get; set; }
        double? YieldStressSiValue { get; }

        [RelDef("OwnsAnalysisMaterialAllowableDataSet")]
        List<AnalysisMaterialAllowableDataSet> OwnsAnalysisMaterialAllowableDataSet { get; set; }

        [RelDef("OwnsAnalysisMaterialFatigueDataSet")]
        List<AnalysisMaterialFatigueDataSet> OwnsAnalysisMaterialFatigueDataSet { get; set; }
    }
}
