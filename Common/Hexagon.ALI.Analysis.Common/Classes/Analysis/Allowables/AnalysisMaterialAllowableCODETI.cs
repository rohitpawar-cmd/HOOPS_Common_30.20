using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableCODETI")]
    public class AnalysisMaterialAllowableCODETI : AnalysisMaterial, IAnalysisMaterialAllowableCODETI
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public string ElementID { get; set; }
        public double? LongitudinalWeldJointEfficiency { get; set; }

        [NotMapped]
        public string HydroTestAllowablePressure { get; set; }
        public double? HydroTestAllowablePressureSiValue { get; private set; }        
    }
}
