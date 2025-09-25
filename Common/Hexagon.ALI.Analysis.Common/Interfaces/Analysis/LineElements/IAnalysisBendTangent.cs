using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces.Analysis.LineElements
{
    public interface IAnalysisBendTangent
    {
        [PPMProperty(nameof(Tangent1X), nameof(IAnalysisBendTangent))]
        [UoM("LengthUoM")]
        string Tangent1X { get; set; }

        [PPMProperty(nameof(Tangent1Y), nameof(IAnalysisBendTangent))]
        [UoM("LengthUoM")]
        string Tangent1Y { get; set; }

        [PPMProperty(nameof(Tangent1Z), nameof(IAnalysisBendTangent))]
        [UoM("LengthUoM")]
        string Tangent1Z { get; set; }

        [PPMProperty(nameof(Tangent2X), nameof(IAnalysisBendTangent))]
        [UoM("LengthUoM")]
        string Tangent2X { get; set; }

        [PPMProperty(nameof(Tangent2Y), nameof(IAnalysisBendTangent))]
        [UoM("LengthUoM")]
        string Tangent2Y { get; set; }

        [PPMProperty(nameof(Tangent2Z), nameof(IAnalysisBendTangent))]
        [UoM("LengthUoM")]
        string Tangent2Z { get; set; }

        double? Tangent1XSiValue { get; }
        double? Tangent1YSiValue { get; }
        double? Tangent1ZSiValue { get; }
        double? Tangent2XSiValue { get; }
        double? Tangent2YSiValue { get; }
        double? Tangent2ZSiValue { get; }
    }
}
