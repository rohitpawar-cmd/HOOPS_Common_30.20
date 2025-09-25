using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Enums;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis
{
    public interface IAnalysisPrimitive
    {
        PipingSystem PipingSystem { get; set; }
        string PipingSystemId { get; set; }
        PrimitiveType PrimitiveType { get; set; }
        int? Number { get; set; }
    }
}
