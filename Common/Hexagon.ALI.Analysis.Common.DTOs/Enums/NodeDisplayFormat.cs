using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.DTOs.Enums
{
    public enum NodeDisplayFormat
    {
        None = 0,
        [Description("Number Only")]
        NumberOnly,
        [Description("Name Only")]
        NameOnly,
        [Description("Number (Name)")]
        NumberNameParentheses,
        [Description("Name (Number)")]
        NameNumberParentheses,
        [Description("Number - Name")]
        NumberNameDash,
        [Description("Name - Number")]
        NameNumberDash,
    }
}
