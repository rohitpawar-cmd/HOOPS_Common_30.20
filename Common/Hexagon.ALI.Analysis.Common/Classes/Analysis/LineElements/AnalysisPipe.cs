using Hexagon.ALI.Analysis.Common.Classes.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements
{
    public class AnalysisPipe : AnalysisLineElement, IAnalysisPipe
    {
        public AnalysisPipe()
        {
        }
        public string GraphicsCoordinates { get; set; }
        public AnalysisLineElement AnalysisLineElement { get; set; }
        public AnalysisPipeProperty AnalysisPipeProperty { get; set; } = new AnalysisPipeProperty();
        [RelDef()] public PartOverride PartOverride { get; set; }
        [RelDef()] public PipeRunItem PipeRunItem { get; set; }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? base.ToString().Replace("Element", "Pipe") : Name;
        }

    }
}
