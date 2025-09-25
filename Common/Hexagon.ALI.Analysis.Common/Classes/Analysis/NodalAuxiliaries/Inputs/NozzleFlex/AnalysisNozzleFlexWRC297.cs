using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs.NozzleFlex
{
    [DefUID("AnalysisNozzleFlexWRC297")]
    public class AnalysisNozzleFlexWRC297 : AnalysisNozzleFlex, IAnalysisNozzleFlexWRC297, IAnalysisNozzleFlexDetails
    {
        public AnalysisNozzleFlexWRC297(AnalysisNode analysisNode = null) : base(analysisNode)
        {
        }
        public AnalysisNozzleFlexWRC297()
        {

        }
        [NotMapped]
        public string NozzleDistanceToStiffenerHead { get; set; }

        public double? NozzleDistanceToStiffenerHeadSiValue { get; protected set; }
        [NotMapped]
        public string NozzleDistanceToOppositeStiffener { get; set; }

        public double? NozzleDistanceToOppositeStiffenerSiValue { get; protected set; }
        [NotMapped]
        public string VesselTemperature { get; set; }

        public double? VesselTemperatureSiValue { get; protected set; }
    }
}