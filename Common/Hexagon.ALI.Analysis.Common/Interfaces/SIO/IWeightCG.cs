using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IWeightCG
    {
        [UoM("MassUoM")]
        [PPMProperty("DryWeight", "IWeightCG")]
        string DryWeight { get; set; }

        double? DryWeightSiValue { get; }
    }
}
