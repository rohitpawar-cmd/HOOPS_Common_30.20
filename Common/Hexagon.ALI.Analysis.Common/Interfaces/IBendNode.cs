using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IBendNode
    {
        [UoM("AngleUoM")]
        [PPMProperty(nameof(Angle), nameof(IBendNode))]
        string Angle
        {
            get;
            set;
        }
        double? AngleSiValue { get; }
    }
}