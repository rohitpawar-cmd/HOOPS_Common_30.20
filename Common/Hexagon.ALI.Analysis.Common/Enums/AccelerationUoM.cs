using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class GLoadUoM : AccelerationUoM
    {
        public GLoadUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class AccelerationUoM : SIOEnum
    {
        #region VALUES

        public static readonly AccelerationUoM Cmps_Squared = new AccelerationUoM("UoM.Acceleration.01", "cm/s^2", "centimeter per second per second", 100);
        public static readonly AccelerationUoM Mts_Squared = new AccelerationUoM("UoM.Acceleration.02", "m/s^2", "meter per second per second", 1);
        public static readonly AccelerationUoM Kmps_Squared = new AccelerationUoM("UoM.Acceleration.03", "km/s^2", "kilometer per second per second", 0.001);
        public static readonly AccelerationUoM Ips_Squared = new AccelerationUoM("UoM.Acceleration.04", "in/s^2", "inch per second per second", 3.937007874015748031496062992126E+01);
        public static readonly AccelerationUoM Fps_Squared = new AccelerationUoM("UoM.Acceleration.05", "ft/s^2", "feet per second per second", 3.28083989501312);
        public static readonly AccelerationUoM Celo = new AccelerationUoM("UoM.Acceleration.06", "celo", "celo", 3.28083989501312);
        public static readonly AccelerationUoM Force = new AccelerationUoM("UoM.Acceleration.07", "force", "force", 0.10197162129779);
        public static readonly AccelerationUoM Gs_Earth_Gravity = new AccelerationUoM("UoM.Acceleration.08", "gs", "gs (Earth gravity)", 0.10197162129779);
        public static readonly AccelerationUoM Kmphps = new AccelerationUoM("UoM.Acceleration.09", "km/h/s", "kilometer per hour per second", 3.6);
        public static readonly AccelerationUoM Mphps = new AccelerationUoM("UoM.Acceleration.10", "mi/h/s", "mile per hour per second", 2.23693629205440);
        public static readonly AccelerationUoM Mphpm = new AccelerationUoM("UoM.Acceleration.11", "mi/h/min", "mile per hour per minute", 134.215577059874);
        public static readonly AccelerationUoM Mps_Squared = new AccelerationUoM("UoM.Acceleration.12", "mi/s^2", "mile per second per second", 6.2137119e-4);
        public static readonly AccelerationUoM Mmps_Squared = new AccelerationUoM("UoM.Acceleration.13", "mm/s^2", "millimeters per second per second", 1000);
        public static readonly AccelerationUoM Kmph_Squared = new AccelerationUoM("UoM.Acceleration.14", "km/h^2", "kilometers per hour per hour", 1.2959999999999999999523072E4);
        public static readonly AccelerationUoM Mph_Squared = new AccelerationUoM("UoM.Acceleration.15", "mi/h^2", "mile per hour per hour", 8.0529706513958482448008284446321E+03);
        public static readonly AccelerationUoM Galileo = new AccelerationUoM("{C4874937-DF93-48D8-980C-429E6CC5848B}", "Gal", "galileo", 100);
        public static readonly AccelerationUoM Milligal = new AccelerationUoM("{CBC10308-A80C-4501-BD49-8E96ED522C06}", "mGal", "milligal", 100000);



        #endregion VALUES

        public AccelerationUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}
