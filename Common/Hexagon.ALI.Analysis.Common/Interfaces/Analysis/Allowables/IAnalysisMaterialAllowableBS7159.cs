using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableBS7159
    {
        [PPMProperty(nameof(RatioHoopModulusAxialElasticityModulus), nameof(IAnalysisMaterialAllowableBS7159))]
        double? RatioHoopModulusAxialElasticityModulus { get; set; }

        [PPMProperty(nameof(MeanTemperatureChangeMultiplier), nameof(IAnalysisMaterialAllowableBS7159))]
        double? MeanTemperatureChangeMultiplier { get; set; }

    }
}
