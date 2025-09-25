using System.Collections.Generic;
using System.Linq;

namespace Hexagon.ALI.Analysis.Common.DTOs
{    
    public class LineNumbersData
    {
        public LineNumbersData()
        {
            
        }

        public LineNumbersData(string lineElementId, string lineNumberName, int? red, int? green, int? blue, double lineNumberOpacity, bool lineNumberVisible)
        {
            LineElementId = lineElementId;
            LineNumberName = lineNumberName;
            Red = red;
            Green = green;
            Blue = blue;
            LineNumberOpacity = lineNumberOpacity;
            LineNumberVisible = lineNumberVisible;
        }

        public LineNumbersData(LineNumbersData lineNumbersData)
        {
            LineElementId = lineNumbersData.LineElementId;
            LineNumberName = lineNumbersData.LineNumberName;
            Red = lineNumbersData.Red;
            Green = lineNumbersData.Green;
            Blue = lineNumbersData.Blue;
            LineNumberOpacity = lineNumbersData.LineNumberOpacity;
            LineNumberVisible = lineNumbersData.LineNumberVisible;
            LineNumberElements = lineNumbersData.LineNumberElements.Select(s => new LineNumbersData(s)).ToList();
        }

        public string LineElementId { get; set; }
        public string LineNumberName { get; set; }
        public int? Red { get; set; }
        public int? Green { get; set; }
        public int? Blue { get; set; }
        public double LineNumberOpacity { get; set; }
        public bool LineNumberVisible { get; set; }
        public List<LineNumbersData> LineNumberElements { get; set; } = new List<LineNumbersData>();
    }
}
