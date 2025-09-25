using System.Collections.Generic;

namespace Hexagon.ALI.Analysis.Common.DTOs
{
    public class GroupedDataLineElementReturn
    {
        public string ColumnName { get; set; } = string.Empty;
        public string UomType { get; set; } = string.Empty;
        public List<KeyValuePair<string, List<string>>> Data { get; set; } = new List<KeyValuePair<string, List<string>>>();
    }

    public class GroupedDataRestraintReturn
    {
        public string ColumnName { get; set; } = string.Empty;
        public string UomType { get; set; } = string.Empty;
        public List<KeyValuePair<string, List<string>>> Data { get; set; } = new List<KeyValuePair<string, List<string>>>();
    }

    public class GroupedDataUniformLoadReturn
    {
        public string ColumnName { get; set; } = string.Empty;
        public string UomType { get; set; } = string.Empty;
        public List<KeyValuePair<string, List<string>>> Data { get; set; } = new List<KeyValuePair<string, List<string>>>();
    }

    public class GroupedDataWaveReturn
    {
        public string ColumnName { get; set; } = string.Empty;
        public string UomType { get; set; } = string.Empty;
        public List<KeyValuePair<string, List<string>>> Data { get; set; } = new List<KeyValuePair<string, List<string>>>();
    }

    public class GroupedDataWindReturn
    {
        public string ColumnName { get; set; } = string.Empty;
        public string UomType { get; set; } = string.Empty;
        public List<KeyValuePair<string, string>> Data { get; set; } = new List<KeyValuePair<string, string>>();
    }
    public class GroupedDataColorReturn
    {
        public string ColumnHeader { get; set; } = string.Empty;
        public List<KeyValuePair<string, System.Drawing.Color>> ColorData { get; set; } = new List<KeyValuePair<string, System.Drawing.Color>>();
        public List<KeyValuePair<string, List<string>>> IDData { get; set; } = new List<KeyValuePair<string, List<string>>>();
    }
}
