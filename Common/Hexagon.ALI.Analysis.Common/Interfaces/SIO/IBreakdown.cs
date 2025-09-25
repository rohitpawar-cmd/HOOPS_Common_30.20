using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IBreakdown
    {
        [PPMProperty("BreakdownClass", "IBreakdown")]
        string BreakdownClass
        {
            get;
            set;
        }

        [PPMProperty("SpecificBreakdownType", "IBreakdown")]
        string SpecificBreakdownType
        {
            get;
            set;
        }

        [PPMProperty("BreakdownTypeDescription", "IBreakdown")]
        string BreakdownTypeDescription
        {
            get;
            set;
        }

        [PPMProperty("BreakdownType", "IBreakdown")]
        string BreakdownType
        {
            get;
            set;
        }
    }
}
