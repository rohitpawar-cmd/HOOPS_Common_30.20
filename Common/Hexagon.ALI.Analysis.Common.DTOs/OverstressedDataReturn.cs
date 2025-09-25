using System.Collections.Generic;
using System.Drawing;

namespace Hexagon.ALI.Analysis.Common.DTOs
{
    public class OverstressedDataReturn
    {        
        public double? Ratio { get; set; }
        public string LineElementId { get; set; }
        public Coordinates StressCoordinates { get; set; }
    }
}
