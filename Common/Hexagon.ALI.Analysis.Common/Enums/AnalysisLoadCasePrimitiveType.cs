using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class AnalysisLoadCasePrimitiveType : SIOEnum
    {
        #region VALUES        
        public static readonly AnalysisLoadCasePrimitiveType Temperature = new AnalysisLoadCasePrimitiveType("a61bd433-a0eb-42a6-934c-4b2de8c649dc", "Temperature", "Temperature", 1);
        public static readonly AnalysisLoadCasePrimitiveType Pressure = new AnalysisLoadCasePrimitiveType("b2c59653-84cb-4d66-a7f2-70822e67d2b2", "Pressure", "Pressure", 2);
        public static readonly AnalysisLoadCasePrimitiveType FluidDensity = new AnalysisLoadCasePrimitiveType("97acf98c-7fad-45b9-be82-dea06de2eae2", "FluidDensity", "Fluid Density", 3);
        #endregion

        public AnalysisLoadCasePrimitiveType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }
    }
}
