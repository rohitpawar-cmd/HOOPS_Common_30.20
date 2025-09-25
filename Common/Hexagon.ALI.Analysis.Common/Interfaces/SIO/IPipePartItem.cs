using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IPipePartItem
    {
        [PPMProperty("PipePartShortMatlDesc", "IPipePartItem")]
        string PipePartShortMatlDesc
        {
            get;
            set;
        }

        [PPMProperty("PipePartMaterialGrade", "IPipePartItem")]
        string PipePartMaterialGrade
        {
            get;
            set;
        }

        [PPMProperty("PipePartMaterialCategory", "IPipePartItem")]
        string PipePartMaterialCategory
        {
            get;
            set;
        }

        [PPMProperty("PipePartMaterialGradePractice", "IPipePartItem")]
        string PipePartMaterialGradePractice
        {
            get;
            set;
        }

    }
}
