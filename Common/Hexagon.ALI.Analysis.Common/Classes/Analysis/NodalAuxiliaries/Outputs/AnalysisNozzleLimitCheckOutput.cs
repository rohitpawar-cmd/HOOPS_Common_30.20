using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs;
using Hexagon.ALI.Analysis.Common.DTOs.Enums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    public class AnalysisNozzleLimitCheckOutput : AnalysisNodeAuxiliaryOutput, IAnalysisNozzleLimitCheckOutput
    {
        public AnalysisNozzleLimitCheckOutput(AnalysisNode node = null, AnalysisLoadCase loadCase = null) : base(node, loadCase)
        {
        }
        public AnalysisNozzleLimitCheckOutput()
        {

        }

        public AnalysisNozzleLimitCheck InputNozzleLimitCheck { get; set; }
        [NotMapped]
        public string FA { get; set; }

        public double? FASiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string FB { get; set; }

        public double? FBSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string FC { get; set; }

        public double? FCSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string MA { get; set; }

        public double? MASiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string MB { get; set; }

        public double? MBSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string MC { get; set; }

        public double? MCSiValue
        {
            get;
            private set;
        }
        public double? ForcesCheck { get; set; }
        public double? MomentsCheck { get; set; }

        [NotMapped]
        public ReportPassFailStatus PassFailStatus =>
            Math.Abs(FASiValue.GetValueOrDefault()) > Math.Abs(InputNozzleLimitCheck.LocalForceASiValue.GetValueOrDefault()) || Math.Abs(FBSiValue.GetValueOrDefault()) > Math.Abs(InputNozzleLimitCheck.LocalForceBSiValue.GetValueOrDefault()) || Math.Abs(FCSiValue.GetValueOrDefault()) > Math.Abs(InputNozzleLimitCheck.LocalForceCSiValue.GetValueOrDefault()) ||
            Math.Abs(MASiValue.GetValueOrDefault()) > Math.Abs(InputNozzleLimitCheck.LocalMomentASiValue.GetValueOrDefault()) || Math.Abs(MBSiValue.GetValueOrDefault()) > Math.Abs(InputNozzleLimitCheck.LocalMomentBSiValue.GetValueOrDefault()) || Math.Abs(MCSiValue.GetValueOrDefault()) > Math.Abs(InputNozzleLimitCheck.LocalMomentCSiValue.GetValueOrDefault())
                ? ReportPassFailStatus.Fail : ReportPassFailStatus.Pass;
    }
}
