using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs
{
    public interface IAnalysisDNVDetailsOutput
    {
        [UoM("ElevationUoM")]
        [PPMProperty(nameof(Depth), nameof(IAnalysisDNVDetailsOutput))]
        string Depth { get; set; }
        [PPMProperty(nameof(DepthSiValue), nameof(IAnalysisDNVDetailsOutput))]
        double? DepthSiValue { get; }
        [UoM("PressureUoM")]
        [PPMProperty(nameof(P_ext), nameof(IAnalysisDNVDetailsOutput))]
        string P_ext { get; set; }
        [PPMProperty(nameof(P_extSiValue), nameof(IAnalysisDNVDetailsOutput))]
        double? P_extSiValue { get; }
        [UoM("PressureUoM")]
        [PPMProperty(nameof(P_int_1), nameof(IAnalysisDNVDetailsOutput))]
        string P_int_1 { get; set; }
        [PPMProperty(nameof(P_int_1SiValue), nameof(IAnalysisDNVDetailsOutput))]
        double? P_int_1SiValue { get; }
        [UoM("PressureUoM")]
        [PPMProperty(nameof(P_int_2), nameof(IAnalysisDNVDetailsOutput))]
        string P_int_2 { get; set; }
        [PPMProperty(nameof(P_int_2SiValue), nameof(IAnalysisDNVDetailsOutput))]
        double? P_int_2SiValue { get; }
        [UoM("ForceUoM")]
        [PPMProperty(nameof(FunctionalAxialForce), nameof(IAnalysisDNVDetailsOutput))]
        string FunctionalAxialForce { get; set; }
        [PPMProperty(nameof(FunctionalAxialForceSiValue), nameof(IAnalysisDNVDetailsOutput))]
        double? FunctionalAxialForceSiValue { get; }
        [UoM("ForceUoM")]
        [PPMProperty(nameof(EnvironmentalAxialForce), nameof(IAnalysisDNVDetailsOutput))]
        string EnvironmentalAxialForce { get; set; }
        [PPMProperty(nameof(EnvironmentalAxialForceSiValue), nameof(IAnalysisDNVDetailsOutput))]
        double? EnvironmentalAxialForceSiValue { get; }
        [UoM("MomentOutputUoM")]
        [PPMProperty(nameof(FunctionalMoment), nameof(IAnalysisDNVDetailsOutput))]
        string FunctionalMoment { get; set; }
        [PPMProperty(nameof(FunctionalMomentSiValue), nameof(IAnalysisDNVDetailsOutput))]
        double? FunctionalMomentSiValue { get; }
        [UoM("MomentOutputUoM")]
        [PPMProperty(nameof(EnvironmentalMoment), nameof(IAnalysisDNVDetailsOutput))]
        string EnvironmentalMoment { get; set; }
        [PPMProperty(nameof(EnvironmentalMomentSiValue), nameof(IAnalysisDNVDetailsOutput))]
        double? EnvironmentalMomentSiValue { get; }
        [PPMProperty(nameof(FunctionalStrain), nameof(IAnalysisDNVDetailsOutput))]
        string FunctionalStrain { get; set; }
        [PPMProperty(nameof(EnvironmentalStrain), nameof(IAnalysisDNVDetailsOutput))]
        string EnvironmentalStrain { get; set; }
    }
}
