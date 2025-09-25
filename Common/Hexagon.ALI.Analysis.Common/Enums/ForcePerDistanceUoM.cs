using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class UniformLoadUoM : ForcePerDistanceUoM
    {
        public UniformLoadUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class TranslationalUoM : ForcePerDistanceUoM
    {
        public TranslationalUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class ForcePerDistanceUoM : SIOEnum
    {
        #region VALUES

        public static readonly ForcePerDistanceUoM DynPerCm = new ForcePerDistanceUoM("UoM.ForcePerDistanceUoM.11", "dyn/cm", "dyne per centimeter", 1000);
        public static readonly ForcePerDistanceUoM DynPerM = new ForcePerDistanceUoM("UoM.ForcePerDistanceUoM.09", "dyn/m", "dyne per meter", 100000);
        public static readonly ForcePerDistanceUoM DynPerMM = new ForcePerDistanceUoM("UoM.ForcePerDistanceUoM.10", "dyn/mm", "dyne per millimeter", 100);
        public static readonly ForcePerDistanceUoM kNPerM = new ForcePerDistanceUoM("UoM.ForcePerDistanceUoM.04", "kN/m", "kilonewton per meter", 0.001);
        public static readonly ForcePerDistanceUoM KipsPerFoot = new ForcePerDistanceUoM("UoM.ForcePerDistanceUoM.08", "kpf", "kips per foot", 6.85217658567917551881456209451e-5);
        public static readonly ForcePerDistanceUoM KipsPerInch = new ForcePerDistanceUoM("UoM.ForcePerDistanceUoM.07", "kpi", "kips/in or kpi", 5.71014715473264626437457052428e-6);
        public static readonly ForcePerDistanceUoM mNPerM = new ForcePerDistanceUoM("UoM.ForcePerDistanceUoM.12", "mN/m", "millinewton per meter", 1000);
        public static readonly ForcePerDistanceUoM NPerCm = new ForcePerDistanceUoM("UoM.ForcePerDistanceUoM.03", "N/cm", "Newton per centimeter", 0.01);
        public static readonly ForcePerDistanceUoM NPerM = new ForcePerDistanceUoM("UoM.ForcePerDistanceUoM.01", "N/m", "Newton per meter", 1);
        public static readonly ForcePerDistanceUoM NPerMm = new ForcePerDistanceUoM("UoM.ForcePerDistanceUoM.02", "N/mm", "Newton per millimeter", 0.001);
        public static readonly ForcePerDistanceUoM PoundsPerFoot = new ForcePerDistanceUoM("UoM.ForcePerDistanceUoM.06", "ppf", "lbf/ft or ppf", 6.85217658567912856649060076491e-2);
        public static readonly ForcePerDistanceUoM PoundsPerInch = new ForcePerDistanceUoM("UoM.ForcePerDistanceUoM.05", "ppi", "lbf/in or ppi", 5.71014715473264626437457052428e-3);

        #endregion VALUES

        public ForcePerDistanceUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}