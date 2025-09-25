using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface ISIOEntity
    {
        #region Clipper Common Properties

        [PPMProperty("Name", "IObject")]
        string Name
        {
            get;
            set;
        }

        [PPMProperty("Description", "IObject")]
        string Description
        {
            get;
            set;
        }

        #endregion Clipper Common Properties

        string InternalID
        {
            get;
        }
    }
}