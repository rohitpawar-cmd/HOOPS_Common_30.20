using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IPipingComponent
    {
        [PPMProperty("PipePartIsSpecialty", "IPipingComponent")]
        bool PipePartIsSpecialty
        {
            get;
            set;
        }

        [PPMProperty("PipeComponentGeometryType", "IPipingComponent")]
        string PipeComponentGeometryType
        {
            get;
            set;
        }

        [PPMProperty("PipingComponentType", "IPipingComponent")]
        int PipingComponentType
        {
            get;
            set;
        }
    }
}
