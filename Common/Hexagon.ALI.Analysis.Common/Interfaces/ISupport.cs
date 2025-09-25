using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.SIO;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface ISupport
    {
        AnalysisSupport AnalysisSupport { get; set; }

        SupportedObject SupportedObject { get; set; }

        Pipeline Pipeline { get; set; }
    }
}
