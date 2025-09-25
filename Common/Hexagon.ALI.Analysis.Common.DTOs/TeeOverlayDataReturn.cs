using System;
using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.DTOs
{

    public class Coordinates
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class TeeOverlayDataReturn
    {
        public string NodeId { get; set; } = string.Empty;
        public Coordinates IntersectionNodeCoordinates { get; set; } = new Coordinates();
        public List<Tuple<Coordinates, double>> IntersectionElementCoordinatesAndDiameter { get; set; }
    }
}
