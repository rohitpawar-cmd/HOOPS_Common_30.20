using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class MaterialsCategory : SIOEnum
    {
        #region VALUES

        public static readonly MaterialsCategory Undefined = new MaterialsCategory("{3C99E4F4-6A95-490B-B0DB-F94124DD6F36}", "Undefined", "", 1);

        #endregion VALUES

        public MaterialsCategory(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }
    }
}