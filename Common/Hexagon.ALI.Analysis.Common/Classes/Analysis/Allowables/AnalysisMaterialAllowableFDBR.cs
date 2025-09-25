using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    [DefUID("AnalysisMaterialAllowableFDBR")]
    public class AnalysisMaterialAllowableFDBR : AnalysisMaterial, IAnalysisMaterialAllowableFDBR
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }
        public double? LongitudinalWeldJointEfficiency { get; set; }
        public double? ElasticModulusRatio { get; set; }

        [NotMapped]
        public string HydroTestAllowable { get; set; }
        public double? HydroTestAllowableSiValue { get; private set; }
    }
}
