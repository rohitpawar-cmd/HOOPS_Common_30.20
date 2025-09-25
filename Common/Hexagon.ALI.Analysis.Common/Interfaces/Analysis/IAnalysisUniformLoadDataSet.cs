using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisUniformLoadDataSet
    {
        List<AnalysisLineElement> AnalysisLineElements { get; set; }

        [PPMProperty(nameof(UniformLoadType), nameof(IAnalysisUniformLoadDataSet))]
        bool UniformLoadType { get; set; }

        [UoM("UniformLoadUoM", "GLoadUoM")]
        [PPMProperty(nameof(UniformLoadX), nameof(IAnalysisUniformLoadDataSet))]
        string UniformLoadX { get; set; }
        double? UniformLoadXSiValue { get; }

        [UoM("UniformLoadUoM", "GLoadUoM")]
        [PPMProperty(nameof(UniformLoadY), nameof(IAnalysisUniformLoadDataSet))]
        string UniformLoadY { get; set; }
        double? UniformLoadYSiValue { get; }

        [UoM("UniformLoadUoM", "GLoadUoM")]
        [PPMProperty(nameof(UniformLoadZ), nameof(IAnalysisUniformLoadDataSet))]
        string UniformLoadZ { get; set; }
        double? UniformLoadZSiValue { get; }        
    }
}
