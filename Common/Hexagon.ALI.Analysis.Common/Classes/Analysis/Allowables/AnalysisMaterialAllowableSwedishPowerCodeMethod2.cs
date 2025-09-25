using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableSwedishPowerCodeMethod2")]
    public class AnalysisMaterialAllowableSwedishPowerCodeMethod2 : AnalysisMaterial, IAnalysisMaterialAllowableSwedishPowerCodeMethod2
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public double? CircumferentialJointFactor { get; set; }

        [NotMapped]
        public string UltimateTensileStrength { get; set; }
        public double? UltimateTensileStrengthSiValue { get; private set; }
        public double? BetaSeffCalculation { get; set; }        
    }
}
