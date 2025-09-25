using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract
{
    [DefUID("AnalysisSupport")]
    public abstract class AnalysisSupport : AnalysisNodeAuxiliary, IAnalysisSupport
    {
        /*****************************************************************************************************************************************/
        // TODO:
        // This class isnt in the schema yet. Refer to TagTypes hierarchy in schema editor once this is added to schema
        // Depending whether this inherits from AnalysisEntity, TagType mappings may have to adjusted for anything object that inherits from this
        /*****************************************************************************************************************************************/

        public AnalysisSupport(Support sioSupport, AnalysisNode node) : base(node)
        {
            OwnsSupport = sioSupport;
            // CNode is not the node.
            //AnalysisSupportToCAnalysisNode = node;
        }
        public AnalysisSupport()
        {

        }
        public AnalysisNode AnalysisSupportToCAnalysisNode { get; set; }
        public string SupportGuid { get; set; }
        public string SupportTag {  get; set; }
        public Support OwnsSupport { get; set; }
        public string OwnsSupportId { get; set; }
    }
}