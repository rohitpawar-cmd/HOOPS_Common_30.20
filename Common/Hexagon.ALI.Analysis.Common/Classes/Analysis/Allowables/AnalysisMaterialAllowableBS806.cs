using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableBS806")]
    public class AnalysisMaterialAllowableBS806 : AnalysisMaterial, IAnalysisMaterialAllowableBS806
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public double? FactorForMinimumWallThickness { get; set; }

        [NotMapped]
        public string SustainedStressLimit { get; set; }
        public double? SustainedStressLimitSiValue { get; private set; }
    }
}
