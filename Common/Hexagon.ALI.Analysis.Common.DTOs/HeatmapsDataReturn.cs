using System;
using System.Collections.Generic;
using System.Drawing;

namespace Hexagon.ALI.Analysis.Common.DTOs
{
    public class HeatmapsDataReturn
    {
        public string ColumnName { get; set; } = string.Empty;
        public string UomType { get; set; } = string.Empty;
        public bool IsEmpty => RangeData.Count == 0;
        public Dictionary<string, Tuple<int, int>> LevelData { get; set; } = new Dictionary<string, Tuple<int, int>>();        
        public List<int> RangeData { get; set; } = new List<int>();
    }    
}
