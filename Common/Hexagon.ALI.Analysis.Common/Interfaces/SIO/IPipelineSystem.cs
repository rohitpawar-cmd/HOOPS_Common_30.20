using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IPipelineSystem
    {
        [PPMProperty("PipelineSequenceNumber", "IPipelineSystem")]
        string PipelineSequenceNumber
        {
            get;
            set;
        }

        [PPMProperty("PipelineFluidSystem", "IPipelineSystem")]
        string PipelineFluidSystem
        {
            get;
            set;
        }

        [PPMProperty("PipelineFluidCode", "IPipelineSystem")]
        string PipelineFluidCode
        {
            get;
            set;
        }
    }
}
