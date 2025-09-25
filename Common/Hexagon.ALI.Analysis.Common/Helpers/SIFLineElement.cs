using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Interfaces;

namespace Hexagon.ALI.Analysis.Common.Helpers
{
    public class AnalysisSifLineElement :ISIFLineElement
    {
        public string Id { get; set; }        
        public AnalysisBaseSif AnalysisBaseSif { get; set; }
        public AnalysisSIFUserDefinedData AnalysisSIFUserDefinedData { get; set; }
        public AnalysisLineElement AnalysisLineElement { get; set; }
        public int? Composition { get; set; }

    }
}
