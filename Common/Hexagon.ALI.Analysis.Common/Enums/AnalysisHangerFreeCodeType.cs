using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class AnalysisHangerFreeCodeType : SIOEnum
    {
        #region VALUES        
        public static readonly AnalysisHangerFreeCodeType Y = new AnalysisHangerFreeCodeType("4eb1f723-18b7-49f5-bfa9-272f9f6d2f34", "Y", "Free the anchor or restraint in the Y direction only", 1);
        public static readonly AnalysisHangerFreeCodeType XY = new AnalysisHangerFreeCodeType("29883952-640e-4434-872f-2faa2449b3b0", "XY", "Free the anchor or restraint in the Y and X directions only", 2);
        public static readonly AnalysisHangerFreeCodeType ZY = new AnalysisHangerFreeCodeType("c5cb9a5d-1490-4182-bf11-8695adf495e6", "ZY", "Free the anchor or restraint in the Y and Z directions only", 3);
        public static readonly AnalysisHangerFreeCodeType XYZ = new AnalysisHangerFreeCodeType("4908915d-cce2-4b24-a512-cbad014c5988", "XYZ", "Free all translational degrees of freedom for the anchor or restraint. (X,Y, and Z)", 4);
        public static readonly AnalysisHangerFreeCodeType ALL = new AnalysisHangerFreeCodeType("a941fcf5-01ab-4755-bd3e-37e34f1f7215", "ALL", "Free all translational and rotational degrees of freedom for the anchor or restraint. (X, Y, Z, RX, RY, and RZ)", 5);
        public static readonly AnalysisHangerFreeCodeType None = new AnalysisHangerFreeCodeType("897efc46-b4bc-40ae-ae76-c23beecac6c8", "None", "None", 6);
        #endregion

        public AnalysisHangerFreeCodeType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }
    }
}