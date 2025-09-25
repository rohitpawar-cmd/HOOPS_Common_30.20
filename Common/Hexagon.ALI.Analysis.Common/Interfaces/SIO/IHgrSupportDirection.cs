using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IHgrSupportDirection
    {
        [PPMProperty("HgrSupportDirection", "IHgrSupportDirection")]
        string HgrSupportDirection
        {
            get;
            set;
        }
    }
}
