using Hexagon.ALI.Analysis.Common.Classes.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements
{
    public interface IAnalysisPipe
    {
        [RelDef("AnalysisPipeProperty", true, false)]
        AnalysisPipeProperty AnalysisPipeProperty { get; set; }

        [RelDef("AnalysisLineElement")]
        AnalysisLineElement AnalysisLineElement { get; set; }

        [PPMProperty("GraphicsCoordinates", "IAnalysisPipe")]
        string GraphicsCoordinates { get; set; }
        PartOverride PartOverride { get; set; }
        PipeRunItem PipeRunItem { get; set; }
    }
}
