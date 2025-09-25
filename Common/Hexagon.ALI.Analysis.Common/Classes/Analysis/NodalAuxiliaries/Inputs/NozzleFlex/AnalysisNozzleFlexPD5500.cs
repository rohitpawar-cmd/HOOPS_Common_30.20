using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using Hexagon.ALI.Analysis.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs.NozzleFlex
{
    [DefUID("AnalysisNozzleFlexPD5500")]
    public class AnalysisNozzleFlexPD5500 : AnalysisNozzleFlex, IAnalysisNozzleFlexPD5500, IAnalysisNozzleFlexDetails
    {
        public AnalysisNozzleFlexPD5500(AnalysisNode analysisNode = null) : base(analysisNode)
        {
        }
        public AnalysisNozzleFlexPD5500()
        {

        }
        public VesselType? VesselType { get; set; }
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