using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF
{
    public interface IAnalysisTD12Tee
    {
        [UoM("LengthUoM")]
        [PPMProperty("HeaderFittingPipeOD", "IAnalysisTD12Tee")]
        string HeaderFittingPipeOD { get; set; }

        double? HeaderFittingPipeODSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("BranchReinforcedLength", "IAnalysisTD12Tee")]
        string BranchReinforcedLength { get; set; }
        double? BranchReinforcedLengthSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("BranchFittingPipeOD", "IAnalysisTD12Tee")]
        string BranchFittingPipeOD { get; set; }

        double? BranchFittingPipeODSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("FilletRadii1", "IAnalysisTD12Tee")]
        string FilletRadii1 { get; set; }
        double? FilletRadii1SiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("FilletRadii2", "IAnalysisTD12Tee")]
        string FilletRadii2 { get; set; }
        double? FilletRadii2SiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("FilletRadii3", "IAnalysisTD12Tee")]
        string FilletRadii3 { get; set; }
        double? FilletRadii3SiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("HeaderFittingWallThickness", "IAnalysisTD12Tee")]
        string HeaderFittingWallThickness { get; set; }
        double? HeaderFittingWallThicknessSiValue { get; }

        [UoM("AngleUoM")]
        [PPMProperty("Theta", "IAnalysisTD12Tee")]
        string Theta { get; set; }
        double? ThetaSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("BranchNominalWallThickness", "IAnalysisTD12Tee")]
        string BranchNominalWallThickness { get; set; }
        double? BranchNominalWallThicknessSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("BranchReinforcedNominalWallThickness", "IAnalysisTD12Tee")]
        string BranchReinforcedNominalWallThickness { get; set; }
        double? BranchReinforcedNominalWallThicknessSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("HeaderReinforcedHalfWidthLength", "IAnalysisTD12Tee")]
        string HeaderReinforcedHalfWidthLength { get; set; }
        double? HeaderReinforcedHalfWidthLengthSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty("BranchReinforcedOrInfluenceHeight", "IAnalysisTD12Tee")]
        string BranchReinforcedOrInfluenceHeight { get; set; }
        double? BranchReinforcedOrInfluenceHeightSiValue { get; }

        [PPMProperty("FatigueClass", "IAnalysisTD12Tee")]
        string FatigueClass { get; set; }
    }
}
