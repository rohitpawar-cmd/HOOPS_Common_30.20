using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IRtePipeRun
    {
        [PPMProperty("PipeRunFlowDirection", "IRtePipeRun")]
        string PipeRunFlowDirection
        {
            get; set;
        }

        [UoM("SlopeUoM")]
        [PPMProperty("MinSlope", "IRtePipeRun")]
        string MinSlope
        {
            get; set;
        }

        [UoM("NominalDiameterUoM")]
        [PPMProperty("PipeRunNPD", "IRtePipeRun")]
        string PipeRunNPD
        {
            get; set;
        }

        [PPMProperty("PipeRunScheduleOverride", "IRtePipeRun")]
        string PipeRunScheduleOverride
        {
            get; set;
        }

        [PPMProperty("PipeRunSlopeDirection", "IRtePipeRun")]
        string PipeRunSlopeDirection
        {
            get; set;
        }

        [UoM("LengthUoM")]
        [PPMProperty("PipeRunEstimatedLength", "IRtePipeRun")]
        string PipeRunEstimatedLength
        {
            get; set;
        }

        [PPMProperty("PipeRunMaterialsClass", "IRtePipeRun")]
        string PipeRunMaterialsClass
        {
            get; set;
        }

        [PPMProperty("PipeRunSpecStatus", "IRtePipeRun")]
        string PipeRunSpecStatus
        {
            get; set;
        }

        [PPMProperty("PipeRunSchedulePractice", "IRtePipeRun")]
        string PipeRunSchedulePractice
        {
            get;
            set;
        }
        double? MinSlopeSiValue
        {
            get;
        }

        double? PipeRunNPDSiValue
        {
            get;
        }

        double? PipeRunEstimatedLengthSiValue
        {
            get;
        }
    }
}
