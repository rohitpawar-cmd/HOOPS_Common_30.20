using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs.SIF;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF
{
    public class AnalysisSIFFittingOutput : AnalysisBaseObject, IAnalysisSIFFittingOutput
    {    
        public double? MeanDiameterMatchingPipeSiValue { get; protected set; }
        public double? OutisdeDiameterMatchingPipeSiValue { get; protected set; }
        public double? MeanRadiusMatchingPipeSiValue { get; protected set; }
        public double? NominalWallThicknessMatchingPipeSiValue { get; protected set; }
        public double? MeanDiameterMatchingBranchPipeSiValue { get; protected set; }
        public double? OutisdeDiameterMatchingBranchPipeSiValue { get; protected set; }
        public double? EffectiveBranchDiameterBranchReinforcementSiValue { get; protected set; }
        public double? MeanRadiusMatchingBranchPipeSiValue { get; protected set; }
        public double? NominalWallThicknessBranchPipeSiValue { get; protected set; }
        public double? ReinforcementPadSaddleThichknessSiValue { get; protected set; }
        public double? UserDefinedEffectiveBranchThicknessUsedBranchReinforcementSiValue { get; protected set; }
        public double? CrotchThicknessSiValue { get; protected set; }
        public double? ExternalCrotchRadiusWeldingTeeSiValue { get; protected set; }
        public double? RadiusOutsideLegFittingSiValue { get; protected set; }
        public double? LengthTaperThickerBranchSectionUsedBranchReinforcementSiValue { get; protected set; }
        public double? RadiiBranchReinforcementSiValue { get; protected set; }
        public double? LocalBranchThicknessBranchReinforcementSiValue { get; protected set; }
        public double? LargeEndTaperBranchReinforcementSiValue { get; protected set; }
        public double? ThetaAngleBranchReinforcementSiValue { get; protected set; }

        #region NOT MAPPED
        [NotMapped]
        public string MeanDiameterMatchingPipe { get; set; }

        [NotMapped]
        public string OutisdeDiameterMatchingPipe { get; set; }

        [NotMapped]
        public string MeanRadiusMatchingPipe { get; set; }

        [NotMapped]
        public string NominalWallThicknessMatchingPipe { get; set; }

        [NotMapped]
        public string MeanDiameterMatchingBranchPipe { get; set; }

        [NotMapped]
        public string OutisdeDiameterMatchingBranchPipe { get; set; }

        [NotMapped]
        public string EffectiveBranchDiameterBranchReinforcement { get; set; }

        [NotMapped]
        public string MeanRadiusMatchingBranchPipe { get; set; }

        [NotMapped]
        public string NominalWallThicknessBranchPipe { get; set; }

        [NotMapped]
        public string ReinforcementPadSaddleThichkness { get; set; }

        [NotMapped]
        public string UserDefinedEffectiveBranchThicknessUsedBranchReinforcement { get; set; }

        [NotMapped]
        public string CrotchThickness { get; set; }

        [NotMapped]
        public string ExternalCrotchRadiusWeldingTee { get; set; }

        [NotMapped]
        public string RadiusOutsideLegFitting { get; set; }

        [NotMapped]
        public string LengthTaperThickerBranchSectionUsedBranchReinforcement { get; set; }

        [NotMapped]
        public string RadiiBranchReinforcement { get; set; }

        [NotMapped]
        public string LocalBranchThicknessBranchReinforcement { get; set; }

        [NotMapped]
        public string LargeEndTaperBranchReinforcement { get; set; }

        [NotMapped]
        public string ThetaAngleBranchReinforcement { get; set; }
        #endregion
    }
}
