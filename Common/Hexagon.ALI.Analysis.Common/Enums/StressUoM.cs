using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class ElasticModulusUoM : StressUoM
    {
        public ElasticModulusUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {

        }
    }
    [ExcludeFromCodeCoverage]
    public class WindLoadUoM : StressUoM
    {
        public WindLoadUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {

        }
    }
    [ExcludeFromCodeCoverage]
    public class StressUoM : SIOEnum
    {
        #region VALUES

        public static readonly StressUoM DynePerCmSquared = new StressUoM("UoM.PressureUoM.16", "dyn/cm^2", "dyne per square centimeter", 10);
        public static readonly StressUoM GramForcePerCmSquared = new StressUoM("UoM.PressureUoM.06", "gram-force/cm^2", "gram-force per square centimeter", 0.0101972000);
        public static readonly StressUoM KilogramForcePerCmSquared = new StressUoM("UoM.PressureUoM.19", "kgf/cm^2", "kilogram force per square centimeter", 1.01971618480605446819205976890e-5);
        public static readonly StressUoM KilogramForcePerMmSquared = new StressUoM("UoM.PressureUoM.18", "kgf/mm^2", "kilogram force per square millimeter", 1.01971618480605446819205976890e-7);
        public static readonly StressUoM KilogramForcePerMSquared = new StressUoM("UoM.PressureUoM.20", "kgf/m^2", "kilogram force per square meter", 0.1019720000);
        public static readonly StressUoM KiloPascalPerInchSquared = new StressUoM("UoM.PressureUoM.21", "kip/in^2", "kilopascal per square inch", 1.45037737730209215148407201699e-7);
        public static readonly StressUoM KiloPascalPerFootSquared = new StressUoM("UoM.PressureUoM.22", "kips/ft^2", "kilopascal per square foot", 2.08854342331501269805224677275e-5);
        public static readonly StressUoM kPa = new StressUoM("UoM.PressureUoM.04", "kPa", "kilopascal", 0.001);
        public static readonly StressUoM mPa = new StressUoM("UoM.PressureUoM.02", "mPa", "millipascal", 1000);
        public static readonly StressUoM MPa = new StressUoM("UoM.PressureUoM.05", "MPa", "megapascal", 0.000001);
        public static readonly StressUoM NewtonPerMmSquared = new StressUoM("UoM.PressureUoM.17", "N/mm^2", "Newton per sq mm", 0.000001);
        public static readonly StressUoM Pa = new StressUoM("UoM.PressureUoM.03", "Pa", "pascal", 1);
        public static readonly StressUoM PoundalPerFootSquared = new StressUoM("UoM.PressureUoM.23", "poundal/ft^2", "poundal per square foot", 0.6719690000);
        public static readonly StressUoM Poz = new StressUoM("UoM.PressureUoM.34", "poz", "ounces (a)", 0.00232);
        public static readonly StressUoM Psf = new StressUoM("UoM.PressureUoM.15", "psf", "psf or pound force per square foot", 2.08854342331501269805224677275e-2);
        public static readonly StressUoM Psi = new StressUoM("UoM.PressureUoM.14", "psi", "pound force per square inch", 1.45037737730209215148407201699e-4);
        public static readonly StressUoM Psia = new StressUoM("UoM.PressureUoM.12", "psia", "pound per square inch (a)", 1.45037737730209215148407201699e-4);
        public static readonly StressUoM Psig = new StressUoM("UoM.PressureUoM.13", "psig", "psig", 1.45037737730209215148407201699e-4, -14.695948775513426925);
        public static readonly StressUoM TonPerFootSquared = new StressUoM("UoM.PressureUoM.36", "tonf/ft^2", "ton force per sq ft", 1.04427135645854841492171107383e-5);
        public static readonly StressUoM TonPerInchSquared = new StressUoM("UoM.PressureUoM.35", "tonf/in^2", "ton force per sq inch", 7.25188499997409365610149254678e-8);
        public static readonly StressUoM UPa = new StressUoM("UoM.PressureUoM.01", "uPa", "micropascal", 1000000);

        #endregion VALUES

        public StressUoM(string uid, string text, string description, double number, double constant = 0) : base(uid, text, description, number, constant)
        {
            dict.TryAdd(uid, text);
        }

    }
}