using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs
{
    public interface IAnalysisHangerReport
    {
        [PPMProperty(nameof(Manufacturer), nameof(IAnalysisHangerReport))]
        string Manufacturer { get; set; }

        [PPMProperty(nameof(Figure), nameof(IAnalysisHangerReport))]
        string Figure { get; set; }

        [PPMProperty(nameof(Size), nameof(IAnalysisHangerReport))]
        int? Size { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(VerticalMovement), nameof(IAnalysisHangerReport))]
        string VerticalMovement { get; set; }

        [UoM("LengthUoM")]
        [PPMProperty(nameof(HorizontalMovement), nameof(IAnalysisHangerReport))]
        string HorizontalMovement { get; set; }

        [UoM("ForceUoM")]
        [PPMProperty(nameof(TheoreticalInstalledLoad), nameof(IAnalysisHangerReport))]
        string TheoreticalInstalledLoad { get; set; }

        [UoM("ForceUoM")]
        [PPMProperty(nameof(ActualInstalledLoad), nameof(IAnalysisHangerReport))]
        string ActualInstalledLoad { get; set; }

        #region SI VALUES
        double? VerticalMovementSiValue { get; }
        double? HorizontalMovementSiValue { get; }
        double? TheoreticalInstalledLoadSiValue { get; }
        double? ActualInstalledLoadSiValue { get; }
        #endregion
    }
}
