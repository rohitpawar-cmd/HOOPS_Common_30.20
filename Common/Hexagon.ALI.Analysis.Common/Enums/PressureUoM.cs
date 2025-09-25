using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class PressureUoM : SIOEnum
    {
        #region VALUES

        public static readonly PressureUoM Atmosphere_Technical = new PressureUoM("UoM.PressureUoM.07", "at", "atmosphere (technical = 1kgf / cm^2)", 1.019716E-05);
        public static readonly PressureUoM Atmospehere_Standard = new PressureUoM("UoM.PressureUoM.08", "atm", "atmosphere (standard)", 9.86923266716012830002467308166e-6);
        public static readonly PressureUoM Bar = new PressureUoM("UoM.PressureUoM.10", "bar", "bar", 0.00001);
        public static readonly PressureUoM Bar_Gauge = new PressureUoM("UoM.PressureUoM.11", "barg", "bar gauge", 0.00001, -1.01325);
        public static readonly PressureUoM CM_Water_4C = new PressureUoM("UoM.PressureUoM.30", "cmH2O_4degC", "centimeter of water (4 deg C)", 1.01974E-02);
        public static readonly PressureUoM CM_Mercury_0C = new PressureUoM("UoM.PressureUoM.26", "cmHg_0degC", "centimeter of mercury (0 deg C)", 7.50064E-04);
        public static readonly PressureUoM Dyne_SqCM = new PressureUoM("UoM.PressureUoM.16", "dyn/cm^2", "dyne per square centimeter", 10);
        public static readonly PressureUoM Foot_Water_39F = new PressureUoM("UoM.PressureUoM.33", "ftH2O_39.2degF", "foot of water (39.2 deg F)", 3.34887209987676150672453517655e-4);
        public static readonly PressureUoM GramForce_SqCM = new PressureUoM("UoM.PressureUoM.06", "gram-force/cm^2", "gram-force per square centimeter", 1.01972E-02);
        public static readonly PressureUoM HectoPascal = new PressureUoM("{A1B172FE-9FC1-4115-A022-613090BB8F7A}", "hPa", "hectopascal", 1.00E-2);
        public static readonly PressureUoM Inch_Water_39F = new PressureUoM("UoM.PressureUoM.31", "inH2O_39.2degF", "inch of water (39.2 deg F)", 4.01474E-03);
        public static readonly PressureUoM Inch_Water_60F = new PressureUoM("UoM.PressureUoM.32", "inH2O_60degF", "inch of water (60 deg F)", 4.01864554757050638369097882126e-3);
        public static readonly PressureUoM Inch_Mercury_32F = new PressureUoM("UoM.PressureUoM.27", "inHg_32degF", "inch of mercury (32 deg F)", 2.95301E-04);
        public static readonly PressureUoM Inch_Mercury_60F = new PressureUoM("UoM.PressureUoM.28", "inHg_60degF", "inch of mercury (60 deg F)", 2.96133884693505086566084811722e-4);
        public static readonly PressureUoM KiloPascal = new PressureUoM("UoM.PressureUoM.04", "kPa", "kilopascal", 0.001);
        public static readonly PressureUoM KiloPascal_Gauge = new PressureUoM("UoM.PressureUoM.40", "kPag", "kilopascal (gauge)", 0.001, -101.325);
        public static readonly PressureUoM KGForce_SqCM = new PressureUoM("UoM.PressureUoM.19", "kgf/cm^2", "kilogram force per square centimeter", 1.01971618480605446819205976890e-5);
        public static readonly PressureUoM KGForce_SqCM_Gauge = new PressureUoM("UoM.PressureUoM.41", "kgf/cm^2-g", "(kilogram force per square centimeter)-gauge", 1.01971618480605446819205976890e-5, -1.0332274242547299);
        public static readonly PressureUoM KGForce_SqM = new PressureUoM("UoM.PressureUoM.20", "kgf/m^2", "kilogram force per square meter", 1.01972E-01);
        public static readonly PressureUoM KGForce_SqCMM = new PressureUoM("UoM.PressureUoM.18", "kgf/mm^2", "kilogram force per square millimeter", 1.01971618480605446819205976890e-7);
        public static readonly PressureUoM KiloPascal_SqInch = new PressureUoM("UoM.PressureUoM.21", "kip/in^2", "kilopascal per square inch", 1.45037737730209215148407201699e-7);
        public static readonly PressureUoM KiloPascal_SqFoot = new PressureUoM("UoM.PressureUoM.22", "kips/ft^2", "kilopascal per square foot", 2.08854342331501269805224677275e-5);
        public static readonly PressureUoM Ksi = new PressureUoM("{BDF8A7A7-1D89-4EE1-B259-B366950F1573}", "ksi", "kilopound force per square inch", 1.450377377E-07);
        public static readonly PressureUoM MegaPascal = new PressureUoM("UoM.PressureUoM.05", "MPa", "megapascal", 0.000001);
        public static readonly PressureUoM MegaPascal_Gauge = new PressureUoM("UoM.PressureUoM.42", "MPag", "Megapascals-gauge", 0.000001, -0.101325);
        public static readonly PressureUoM MicroPascal = new PressureUoM("UoM.PressureUoM.01", "uPa", "micropascal", 1000000);
        public static readonly PressureUoM MillaPascal = new PressureUoM("UoM.PressureUoM.02", "mPa", "millipascal", 1000);
        public static readonly PressureUoM Millibar = new PressureUoM("UoM.PressureUoM.09", "mbar", "millibar", 0.01);
        public static readonly PressureUoM M_Water_4C = new PressureUoM("{2F351D82-7BF4-4BA5-BD7F-489E1F15757D}", "mH2O_4degC", "meter of water (4 deg C)", 1.019744E-4);
        public static readonly PressureUoM MM_Water = new PressureUoM("UoM.PressureUoM.29", "mmH2O", "millimeter of water", 1.0197441459045319285118568482751E-01);
        public static readonly PressureUoM MM_Water_0C = new PressureUoM("UoM.PressureUoM.25", "mmHg_0degC", "millimeter of mercury (0 deg C)", 7.50063609549442189601587945050e-3);
        public static readonly PressureUoM Newton_Per_SqMM = new PressureUoM("UoM.PressureUoM.17", "N/mm^2", "Newton per sq mm", 0.000001);
        public static readonly PressureUoM OunceForce_SqInch = new PressureUoM("{4E1437B1-41CC-40B8-AF62-B02D0CB6206E}", "ozf/in^2", "ounce force per square inch", 2.320603E-3);
        public static readonly PressureUoM Pascal = new PressureUoM("UoM.PressureUoM.03", "Pa", "pascal", 1);
        public static readonly PressureUoM Pascal_Gauge = new PressureUoM("{597A4543-0A8E-4F17-9D69-935445AADCB0}", "Pag", "pascal (gauge)", 1, -101325);
        public static readonly PressureUoM Poundal_SqFoot = new PressureUoM("UoM.PressureUoM.23", "poundal/ft^2", "poundal per square foot", 6.71969E-01);
        public static readonly PressureUoM PoundForce_SqFoot = new PressureUoM("{E0EFC5C0-A6B1-4B89-82C8-229E1C4E3A73}", "lbf/ft^2", "pound-force (lbf) per square foot", 2.08854342E-2);
        public static readonly PressureUoM PoundForce_SqInch = new PressureUoM("{FA718745-0427-466B-91A3-61FFE37FC7C9}", "lbf/in^2", "pound-force (lbf) per square inch", 1.450377E-4);
        public static readonly PressureUoM Poz = new PressureUoM("UoM.PressureUoM.34", "poz", "ounces (a)", 0.00232);
        public static readonly PressureUoM Psf = new PressureUoM("UoM.PressureUoM.15", "psf", "psf or pound force per square foot", 2.08854342331501269805224677275e-2);
        public static readonly PressureUoM Psi = new PressureUoM("UoM.PressureUoM.14", "psi", "pound force per square inch", 1.45037737730209215148407201699e-4);
        public static readonly PressureUoM Psia = new PressureUoM("UoM.PressureUoM.12", "psia", "pound per square inch (a)", 1.45037737730209215148407201699e-4);
        public static readonly PressureUoM Psig = new PressureUoM("UoM.PressureUoM.13", "psig", "psig", 1.45037737730209215148407201699e-4, -14.695948775513427);
        public static readonly PressureUoM TonForce_SqFoot = new PressureUoM("UoM.PressureUoM.36", "tonf/ft^2", "ton force per sq ft", 1.04427135645854841492171107383e-5);
        public static readonly PressureUoM TonForce_SqInch = new PressureUoM("UoM.PressureUoM.35", "tonf/in^2", "ton force per sq inch", 7.25188499997409365610149254678e-8);
        public static readonly PressureUoM Torr = new PressureUoM("UoM.PressureUoM.24", "Torr", "torr (mmHg, 0 deg C)", 7.50064E-03);

        #endregion VALUES

        public PressureUoM(string uid, string text, string description, double number, double constant = 0) : base(uid, text, description, number, constant)
        {
            dict.TryAdd(uid, text);
        }

    }
}