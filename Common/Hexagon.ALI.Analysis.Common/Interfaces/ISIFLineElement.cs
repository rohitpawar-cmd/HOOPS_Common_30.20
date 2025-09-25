using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface ISIFLineElement
    {
        [PPMProperty(nameof(Id), nameof(ISIFLineElement))]
        string Id { get; set;  }

        [PPMProperty(nameof(Composition), nameof(ISIFLineElement))]
        int? Composition { get; set; }
    }
}
