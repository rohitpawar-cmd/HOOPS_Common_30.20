using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableBS7159")]
    public class AnalysisMaterialAllowableBS7159 : AnalysisMaterial, IAnalysisMaterialAllowableBS7159
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public double? RatioHoopModulusAxialElasticityModulus { get; set; }
        public double? MeanTemperatureChangeMultiplier { get; set; }
    }
}
