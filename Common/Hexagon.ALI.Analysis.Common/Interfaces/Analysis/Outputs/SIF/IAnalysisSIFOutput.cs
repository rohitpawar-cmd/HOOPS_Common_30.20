using Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs.SIF
{
    public interface IAnalysisSIFOutput
    {
        [PPMProperty(nameof(SIFFittingOutput), nameof(IAnalysisSIFOutput))]
        AnalysisSIFFittingOutput SIFFittingOutput { get; set; }
    }
}
