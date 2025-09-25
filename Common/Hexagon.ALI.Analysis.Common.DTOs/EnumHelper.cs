using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Hexagon.ALI.Analysis.Common.DTOs
{
    public static class EnumHelper
    {
        public static string GetEnumDescription(this Enum value)
        {
            if (value == null) return string.Empty;

            FieldInfo fi = value.GetType().GetField(value.ToString());
            if (fi != null && fi.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] attributes && attributes.Any())
            {
                return attributes.First().Description;
            }
            return AddSpacesToPascalCase(value.ToString());
        }

        public static string AddSpacesToPascalCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            // Use regex to add spaces before each capital letter (except the first one)
            return Regex.Replace(input.Replace("_", " ").Trim(), "(?<!^)([A-Z])", " $1").Replace("  ", " ");
        }
    }
}
