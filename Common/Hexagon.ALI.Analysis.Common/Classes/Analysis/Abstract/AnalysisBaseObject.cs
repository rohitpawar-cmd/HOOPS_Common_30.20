using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract
{
    [DefUID("AnalysisBaseObject")]
    public abstract class AnalysisBaseObject : SIOEntity, IAnalysisBaseObject
    {
        public AnalysisBaseObject()
        {
        }
    }
}