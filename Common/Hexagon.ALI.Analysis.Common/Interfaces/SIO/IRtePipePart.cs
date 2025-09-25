using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IRtePipePart
    {
        [PPMProperty("StressSystemNo", "IRtePipePart")]
        string StressSystemNo
        {
            get;
            set;
        }

        [PPMProperty("IsoSheetNo", "IRtePipePart")]
        string IsoSheetNo
        {
            get;
            set;
        }

        [PPMProperty("IsogenKey", "IRtePipePart")]
        string IsogenKey
        {
            get;
            set;
        }
    }
}
