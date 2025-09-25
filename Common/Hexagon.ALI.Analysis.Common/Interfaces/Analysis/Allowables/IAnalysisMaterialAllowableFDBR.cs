using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables
{
    public interface IAnalysisMaterialAllowableFDBR
    {
        [PPMProperty(nameof(LongitudinalWeldJointEfficiency), nameof(IAnalysisMaterialAllowableFDBR))]
        double? LongitudinalWeldJointEfficiency { get; set; }

        [PPMProperty(nameof(ElasticModulusRatio), nameof(IAnalysisMaterialAllowableFDBR))]
        double? ElasticModulusRatio { get; set; }

        [UoM("PressureUoM")]
        [PPMProperty(nameof(HydroTestAllowable), nameof(IAnalysisMaterialAllowableB31))]
        string HydroTestAllowable { get; set; }
        
        double? HydroTestAllowableSiValue { get; }
    }
}
