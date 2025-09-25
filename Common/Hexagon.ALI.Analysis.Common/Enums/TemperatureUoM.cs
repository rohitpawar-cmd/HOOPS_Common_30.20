using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class TemperatureUoM : SIOEnum
    {
        #region VALUES

        public static readonly TemperatureUoM Celsius = new TemperatureUoM("UoM.TemperatureUoM.01", "C", "degree Celsius", 1, -273.14999999999998);
        public static readonly TemperatureUoM Fahrenheit = new TemperatureUoM("UoM.TemperatureUoM.02", "F", "degree Fahrenheit", 1.8, -459.67);
        public static readonly TemperatureUoM Kelvin = new TemperatureUoM("UoM.TemperatureUoM.03", "K", "degree Kelvin", 1);
        public static readonly TemperatureUoM Rankine = new TemperatureUoM("UoM.TemperatureUoM.04", "Ra", "degree Rankine", 1.8);

        #endregion VALUES

        public TemperatureUoM(string uid, string text, string description, double number, double constant = 0) : base(uid, text, description, number, constant)
        {
            dict.TryAdd(uid, text);
        }

    }
}