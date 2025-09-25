using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableGPTCZ380")]
    public class AnalysisMaterialAllowableGPTCZ380 : AnalysisMaterial, IAnalysisMaterialAllowableGPTCZ380
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public double? LongitudinalWeldJointEfficiency { get; set; }
        public double? ConstructionDesignFactor { get; set; }

        [NotMapped]
        public string MinimumYieldStress { get; set; }
        public double? MinimumYieldStressSiValue { get; private set; }
    }
}
