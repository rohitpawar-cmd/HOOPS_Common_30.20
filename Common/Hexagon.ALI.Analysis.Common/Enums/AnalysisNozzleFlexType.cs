using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class AnalysisNozzleFlexType : SIOEnum
    {
        #region VALUES        
        public static readonly AnalysisNozzleFlexType API650 = new AnalysisNozzleFlexType("a61bd433-a0eb-42a6-934c-4b2de8c649dc", "API 650", "API 650", 1);
        public static readonly AnalysisNozzleFlexType WRC297 = new AnalysisNozzleFlexType("b2c59653-84cb-4d66-a7f2-70822e67d2b2", "WRC 297", "WRC 297", 2);
        public static readonly AnalysisNozzleFlexType PD5500 = new AnalysisNozzleFlexType("6b20bac7-2e87-46d6-85c5-d98d9fc3c056", "PD 5500", "PD 5500", 3);
        public static readonly AnalysisNozzleFlexType Custom = new AnalysisNozzleFlexType("b4cf8e9b-e70d-4c16-9c50-ffcebcd10312", "Custom", "Custom", 4);
        #endregion

        public AnalysisNozzleFlexType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }
    }
}
