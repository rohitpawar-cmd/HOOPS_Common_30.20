using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs.SIF
{
    public interface IAnalysisSIFFittingOutput
    {
        [UoM("DiameterUoM")]
        [PPMProperty(nameof(MeanDiameterMatchingPipe), nameof(IAnalysisSIFFittingOutput))]
        string MeanDiameterMatchingPipe { get; set;}        
        double? MeanDiameterMatchingPipeSiValue { get; }

        [UoM("DiameterUoM")]
        [PPMProperty(nameof(OutisdeDiameterMatchingPipe), nameof(IAnalysisSIFFittingOutput))]
        string OutisdeDiameterMatchingPipe { get; set; }
        double? OutisdeDiameterMatchingPipeSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(MeanRadiusMatchingPipe), nameof(IAnalysisSIFFittingOutput))]
        string MeanRadiusMatchingPipe { get; set; }
        double? MeanRadiusMatchingPipeSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(NominalWallThicknessMatchingPipe), nameof(IAnalysisSIFFittingOutput))]
        string NominalWallThicknessMatchingPipe { get; set; }
        double? NominalWallThicknessMatchingPipeSiValue { get; }

        [UoM("DiameterUoM")]
        [PPMProperty(nameof(MeanDiameterMatchingBranchPipe), nameof(IAnalysisSIFFittingOutput))]
        string MeanDiameterMatchingBranchPipe { get; set; }
        double? MeanDiameterMatchingBranchPipeSiValue { get; }

        [UoM("DiameterUoM")]
        [PPMProperty(nameof(OutisdeDiameterMatchingBranchPipe), nameof(IAnalysisSIFFittingOutput))]
        string OutisdeDiameterMatchingBranchPipe { get; set; }
        double? OutisdeDiameterMatchingBranchPipeSiValue { get; }

        [UoM("DiameterUoM")]
        [PPMProperty(nameof(EffectiveBranchDiameterBranchReinforcement), nameof(IAnalysisSIFFittingOutput))]
        string EffectiveBranchDiameterBranchReinforcement { get; set; }
        double? EffectiveBranchDiameterBranchReinforcementSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(MeanRadiusMatchingBranchPipe), nameof(IAnalysisSIFFittingOutput))]
        string MeanRadiusMatchingBranchPipe { get; set; }
        double? MeanRadiusMatchingBranchPipeSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(NominalWallThicknessBranchPipe), nameof(IAnalysisSIFFittingOutput))]
        string NominalWallThicknessBranchPipe { get; set; }
        double? NominalWallThicknessBranchPipeSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(ReinforcementPadSaddleThichkness), nameof(IAnalysisSIFFittingOutput))]
        string ReinforcementPadSaddleThichkness { get; set; }
        double? ReinforcementPadSaddleThichknessSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(UserDefinedEffectiveBranchThicknessUsedBranchReinforcement), nameof(IAnalysisSIFFittingOutput))]
        string UserDefinedEffectiveBranchThicknessUsedBranchReinforcement { get; set; }
        double? UserDefinedEffectiveBranchThicknessUsedBranchReinforcementSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(CrotchThickness), nameof(IAnalysisSIFFittingOutput))]
        string CrotchThickness { get; set; }
        double? CrotchThicknessSiValue { get; }

        [UoM("DiameterUoM")]
        [PPMProperty(nameof(ExternalCrotchRadiusWeldingTee), nameof(IAnalysisSIFFittingOutput))]
        string ExternalCrotchRadiusWeldingTee { get; set; }
        double? ExternalCrotchRadiusWeldingTeeSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(RadiusOutsideLegFitting), nameof(IAnalysisSIFFittingOutput))]
        string RadiusOutsideLegFitting { get; set; }
        double? RadiusOutsideLegFittingSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(LengthTaperThickerBranchSectionUsedBranchReinforcement), nameof(IAnalysisSIFFittingOutput))]
        string LengthTaperThickerBranchSectionUsedBranchReinforcement { get;set; }
        double? LengthTaperThickerBranchSectionUsedBranchReinforcementSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(RadiiBranchReinforcement), nameof(IAnalysisSIFFittingOutput))]
        string RadiiBranchReinforcement { get; set; }
        double? RadiiBranchReinforcementSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(LocalBranchThicknessBranchReinforcement), nameof(IAnalysisSIFFittingOutput))]
        string LocalBranchThicknessBranchReinforcement { get; set; }
        double? LocalBranchThicknessBranchReinforcementSiValue { get; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(LargeEndTaperBranchReinforcement), nameof(IAnalysisSIFFittingOutput))]
        string LargeEndTaperBranchReinforcement { get; set; }
        double? LargeEndTaperBranchReinforcementSiValue { get; }

        [UoM("AngleUoM")]
        [PPMProperty(nameof(ThetaAngleBranchReinforcement), nameof(IAnalysisSIFFittingOutput))]
        string ThetaAngleBranchReinforcement { get; set; }
        double? ThetaAngleBranchReinforcementSiValue { get; }
    }
}
