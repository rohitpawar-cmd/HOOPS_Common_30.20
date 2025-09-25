using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class SlopeUoM : SIOEnum
    {
        #region VALUES

        public static readonly SlopeUoM InchesPer12Inches = new SlopeUoM("{8F3E2EA5-360F-4DDB-986E-9D0EE41ED64B}", "in/12 in", "inch(es) per 12 inches", 12);
        public static readonly SlopeUoM InchesPer10Feet = new SlopeUoM("{2CC96D6D-6B25-4DE7-9CCB-E32DB901D4BB}", "in/10 ft", "inch(es) per 10 ft", 120);
        public static readonly SlopeUoM InchesPer100Feet = new SlopeUoM("{A287FF8A-935B-4A3E-9F7A-EE52CA7C065B}", "in/100 ft", "inch(es) per 100 ft", 1200);
        public static readonly SlopeUoM CentiMeterPerMeter = new SlopeUoM("UoM.Slope.02", "cm/m", "centimeter per meter", 100);
        public static readonly SlopeUoM FootPerFoot = new SlopeUoM("UoM.Slope.06", "ft/ft", "foot per foot", 1);
        public static readonly SlopeUoM InchesPer30Feet = new SlopeUoM("UoM.Slope.04", "in/30ft", "inch per 30 feet", 360);
        public static readonly SlopeUoM InchesPerFoot = new SlopeUoM("UoM.Slope.05", "in/ft", "inch per foot", 12);
        public static readonly SlopeUoM MeterPerMeter = new SlopeUoM("UoM.Slope.03", "m/m", "meter per meter", 1);
        public static readonly SlopeUoM MilimeterPerMeter = new SlopeUoM("UoM.Slope.01", "mm/m", "millimeter per meter", 1000);
        public static readonly SlopeUoM InchPerInch = new SlopeUoM("UoM.Slope.07", "in/in", "inch per inch", 1);

        #endregion VALUES

        public SlopeUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}