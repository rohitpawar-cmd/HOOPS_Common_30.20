using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs.NozzleFlex
{
    [DefUID("AnalysisNozzleFlexCustom")]
    public class AnalysisNozzleFlexCustom : AnalysisNozzleFlex, IAnalysisNozzleFlexCustom
    {
        public AnalysisNozzleFlexCustom(AnalysisNode analysisNode = null) : base(analysisNode)
        {
        }
        public AnalysisNozzleFlexCustom()
        {
        }
        [NotMapped]
        public string NozzleAxial { get; set; }

        public double? NozzleAxialSiValue { get; protected set; }
        [NotMapped]
        public string NozzleTorsional { get; set; }

        public double? NozzleTorsionalSiValue { get; protected set; }
        [NotMapped]
        public string InPlaneBending { get; set; }

        public double? InPlaneBendingSiValue { get; protected set; }
        [NotMapped]
        public string OutPlaneBending { get; set; }

        public double? OutPlaneBendingSiValue { get; protected set; }
    }
}