using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.SIF;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF
{
    public class AnalysisSIFFitting : AnalysisBaseSif, IAnalysisSIFFitting, IAnalysisB31JTee, IAnalysisCommonTee, IAnalysisTD12Tee
    {
        public bool? SIFOption1 { get; set; }
        public bool? SIFOption2 { get; set; }
        public double? PressureStressMultiplier { get; set; }
        public ReinforcementType? ReinforcedType { get; set; }
        public FlangeNumber? NumberOfFlanges { get; set; }
        public AnalysisNode SurfaceNode { get; set; }
        public string FatigueClass { get; set; }
        public double? ReinforcedLengthSiValue { get; private set; }
        public double? ReinforcedAngleThetaSiValue { get; private set; }
        public double? ReinforcedTaperLargeEndSiValue { get; private set; }
        public double? ReinforcedThicknessSiValue { get; private set; }
        public double? PadThicknessSiValue { get; private set; }
        public double? ReinforcedRadiusSiValue { get; private set; }
        public double? EffectiveBranchThicknessSiValue { get; private set; }
        public CommonTeeWeld? CommonTeeWeldID { get; set; }
        public double? FittingOutsideRadiusSiValue { get; private set; }
        public double? FittingCrotchRadiusSiValue { get; private set; }
        public double? FittingCrotchThicknessSiValue { get; private set; }
        public double? EncirclementPadSaddleThicknessSiValue { get; private set; }
        public double? HeaderFittingPipeODSiValue { get; private set; }
        public double? BranchReinforcedLengthSiValue { get; private set; }
        public double? BranchFittingPipeODSiValue { get; private set; }
        public double? FilletRadii1SiValue { get; private set; }
        public double? FilletRadii2SiValue { get; private set; }
        public double? FilletRadii3SiValue { get; private set; }
        public double? HeaderFittingWallThicknessSiValue { get; private set; }
        public double? ThetaSiValue { get; private set; }
        public double? BranchNominalWallThicknessSiValue { get; private set; }
        public double? BranchReinforcedNominalWallThicknessSiValue { get; private set; }
        public double? HeaderReinforcedHalfWidthLengthSiValue { get; private set; }
        public double? BranchReinforcedOrInfluenceHeightSiValue { get; private set; }


        #region NOT MAPPED
        [NotMapped]
        public string ReinforcedLength { get; set; }

        [NotMapped]
        public string ReinforcedAngleTheta { get; set; }

        [NotMapped]
        public string ReinforcedTaperLargeEnd { get; set; }

        [NotMapped]
        public string ReinforcedThickness { get; set; }

        [NotMapped]
        public string PadThickness { get; set; }

        [NotMapped]
        public string ReinforcedRadius { get; set; }

        [NotMapped]
        public string EffectiveBranchThickness { get; set; }

        [NotMapped]
        public string FittingOutsideRadius { get; set; }

        [NotMapped]
        public string FittingCrotchRadius { get; set; }

        [NotMapped]
        public string FittingCrotchThickness { get; set; }

        [NotMapped]
        public string EncirclementPadSaddleThickness { get; set; }

        [NotMapped]
        public string HeaderFittingPipeOD { get; set; }

        [NotMapped]
        public string BranchReinforcedLength { get; set; }

        [NotMapped]
        public string BranchFittingPipeOD { get; set; }

        [NotMapped]
        public string FilletRadii1 { get; set; }

        [NotMapped]
        public string FilletRadii2 { get; set; }

        [NotMapped]
        public string FilletRadii3 { get; set; }

        [NotMapped]
        public string HeaderFittingWallThickness { get; set; }

        [NotMapped]
        public string Theta { get; set; }

        [NotMapped]
        public string BranchNominalWallThickness { get; set; }

        [NotMapped]
        public string BranchReinforcedNominalWallThickness { get; set; }

        [NotMapped]
        public string HeaderReinforcedHalfWidthLength { get; set; }

        [NotMapped]
        public string BranchReinforcedOrInfluenceHeight { get; set; }
        #endregion
    }

}
