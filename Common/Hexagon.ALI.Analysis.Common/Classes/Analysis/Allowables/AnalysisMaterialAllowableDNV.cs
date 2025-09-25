using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    public class AnalysisMaterialAllowableDNV : AnalysisMaterial, IAnalysisMaterialAllowableDNV
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public bool? SupplementaryRequirement { get; set; }
        public bool? MaterialLuderPlateau { get; set; }
        public double? StrainHardeningFactor { get; set; }
        public double? FabricationStringResisteanceFactor { get; set; }
        public string BurstFailureOperation { get; set; }
        public string BurstFailureTesing { get; set; }
        public string CollapseFailure { get; set; }
        public string PropagationBuckling { get; set; }
        public string LoadControlCondition { get; set; }
        public string DisplacementControlledCondition { get; set; }
        public double? LoadEffectFactor { get; set; }
        public double? GirthWeldStrainResisteanceFactor { get; set; }

        [NotMapped]
        public string ReactionForce { get; set; }
        public double? ReactionForceSiValue { get; private set; }
        public double? PressureYieldingUsageFactor { get; set; }
        public double? PressureBurstingUsageFactor { get; set; }
        public double? EquivalentStressCheckUsageFactor { get; set; }
    }
}

