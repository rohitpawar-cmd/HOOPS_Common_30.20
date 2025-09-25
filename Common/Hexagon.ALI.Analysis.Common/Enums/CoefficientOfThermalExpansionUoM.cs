using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class CoefficientOfThermalExpansionUoM : SIOEnum
    {
        #region VALUES
        public static readonly CoefficientOfThermalExpansionUoM perDegreeK = new CoefficientOfThermalExpansionUoM("UoM.CoefficientOfThermalExpansion.01", "/K", "per degree Kelvin", 1);
        public static readonly CoefficientOfThermalExpansionUoM perDegreeC = new CoefficientOfThermalExpansionUoM("UoM.CoefficientOfThermalExpansion.02", "/deg C", "per degree Celcius", 1);
        public static readonly CoefficientOfThermalExpansionUoM perDegreeF = new CoefficientOfThermalExpansionUoM("UoM.CoefficientOfThermalExpansion.03", "/deg F", "per degree Fahrenheit", 0.55555555555555555555555555555556);
        public static readonly CoefficientOfThermalExpansionUoM perDegreeR = new CoefficientOfThermalExpansionUoM("UoM.CoefficientOfThermalExpansion.04", "/deg R", "per degree Rankine", 0.55555555555555555555555555555556);
        //public static readonly CoefficientOfThermalExpansionUoM inindeg = new CoefficientOfThermalExpansionUoM("UoM.CoefficientOfThermalExpansion.05", "in/in/deg", "inch per inch per degree", 0.55555555555555555555555555555556);
        //public static readonly CoefficientOfThermalExpansionUoM mmmmdeg = new CoefficientOfThermalExpansionUoM("UoM.CoefficientOfThermalExpansion.06", "mm/mm/deg", "mm per mm per degree", 1);
        //public static readonly CoefficientOfThermalExpansionUoM cmcmdeg = new CoefficientOfThermalExpansionUoM("UoM.CoefficientOfThermalExpansion.07", "cm/cm/deg", "cm per cm per degree", 1);
        #endregion VALUES

        public CoefficientOfThermalExpansionUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }
    }
}
