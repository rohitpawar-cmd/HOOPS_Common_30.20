using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.DTOs.Enums;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Reports;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Reports
{
    [DefUID("AnalysisMDMTReport")]
    public class AnalysisMDMTReport : AnalysisNodeAuxiliaryOutput, IAnalysisReportOutputMDMT
    {
        [NotMapped]
        public string PipeThickness { get; set; }
        public double? PipeThicknessSiValue { get; private set; }
        public int? MaterialID { get; set; }
        public string Curve { get; set; }
        public PipingCode? PipingCode { get; set; }

        [NotMapped]
        public string MinimumTemperature { get; set; }
        public double? MinimumTemperatureSiValue { get; private set; }

        [NotMapped]
        public string BaseMDMT { get; set; }
        public double? BaseMDMTSiValue { get; private set; }
        public double? StressRatio { get; set; }

        [NotMapped]
        public string Reduction { get; set; }
        public double? ReductionSiValue { get; private set; }

        [NotMapped]
        public string FinalMDMT { get; set; }
        public double? FinalMDMTSiValue { get; private set; }
        public int? Status { get; set; }

        [NotMapped]
        public MdmtStatus? UserStatus
        {
            get
            {
                if (Status > 0)
                {
                    return MdmtStatus.Impact;
                }
                else if (Status == 0)
                {
                    return MdmtStatus.OK;
                }
                else if (Status < 0)
                {
                    return MdmtStatus.Unkown;
                }
                else
                {
                    return null;
                }
            }
        }

        [NotMapped]
        public int? UserWarning
        {
            get
            {
                if (Status >= 0 && Status <=2)
                {
                    return null;
                }
                return Status;
            }
        }

        [NotMapped]
        public ReportPassFailStatus? PassFailStatus
        {
            get
            {
                if (UserStatus == null)
                {
                    return null;
                }
                if (UserStatus == MdmtStatus.OK)
                {
                    return ReportPassFailStatus.Pass;
                }
                return ReportPassFailStatus.Fail;
            }
        }
    }
}
