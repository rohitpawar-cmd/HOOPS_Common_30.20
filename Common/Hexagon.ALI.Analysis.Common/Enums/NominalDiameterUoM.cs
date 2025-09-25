using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class NominalDiameterUoM : SIOEnum
    {
        #region VALUES

        public static readonly NominalDiameterUoM Milimeter = new NominalDiameterUoM("{01C1681E-E88F-4AAA-8D2B-7CE9FFDD70DE}", "mm", "mm", 1);
        public static readonly NominalDiameterUoM Inch = new NominalDiameterUoM("{5A3F5B66-F99A-4E83-994E-10BA26DE6455}", "in", "in", .04);
        public static readonly NominalDiameterUoM Inch_Abbreviation = new NominalDiameterUoM("{25749EB3-5032-4CC8-96DA-0790BC3EC60C}", "\"", "\"", .04);

        #endregion VALUES

        public NominalDiameterUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }
    }
}