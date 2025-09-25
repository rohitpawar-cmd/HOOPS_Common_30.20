using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableRCCMCD")]
    public class AnalysisMaterialAllowableRCCMCD : AnalysisMaterial, IAnalysisMaterialAllowableRCCMCD
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }

        [NotMapped]
        public string DifferenceOperatingPeakPressure { get; set; }
        public double? DifferenceOperatingPeakPressureSiValue { get; private set; }

        [NotMapped]
        public string HydroTestAllowablePressure { get; set; }        
        public double? HydroTestAllowablePressureSiValue { get; private set; }
    }
}
