using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    public class AnalysisHangerOutput : AnalysisBaseObject, IAnalysisHangerReport, IAnalysisHangerShared
    {
        public AnalysisHangerOutput() 
        {
        }
        public AnalysisNode AnalysisNode { get; set; }
        [NotMapped]
        public string Manufacturer { get; set; }
        [NotMapped]
        public string Figure { get; set; }
        [NotMapped]
        public int? Size { get; set; }
        [NotMapped]
        public string VerticalMovement { get; set; }
        [NotMapped]
        public string HorizontalMovement { get; set; }
        [NotMapped]
        public string UserSpringRate { get; set; }
        [NotMapped]
        public string OperatingLoad { get; set; }
        [NotMapped]
        public string TheoreticalInstalledLoad { get; set; }
        [NotMapped]
        public string ActualInstalledLoad { get; set; }
        [NotMapped]
        public double? LoadVariation { get; set; }

        public int NumberofHangerDesigned { get; set; }
        [NotMapped]
        public double? VerticalMovementSiValue { get; private set; }
        [NotMapped]
        public double? HorizontalMovementSiValue { get; private set; }
        [NotMapped]
        public double? UserSpringRateSiValue { get; private set; }
        [NotMapped]
        public double? OperatingLoadSiValue { get; private set; }
        [NotMapped]
        public double? TheoreticalInstalledLoadSiValue { get; private set; }
        [NotMapped]
        public double? ActualInstalledLoadSiValue { get; private set; }
    }
}
