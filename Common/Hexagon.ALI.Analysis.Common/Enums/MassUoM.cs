using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class MassDynamicsUoM : MassUoM
    {
        public MassDynamicsUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class MassUoM : SIOEnum
    {
        #region VALUES
        public static readonly MassUoM Microgram = new MassUoM("UoM.MassUoM.01", "ug", "microgram", 1000000000);
        public static readonly MassUoM Milligram = new MassUoM("UoM.MassUoM.02", "mg", "milligram", 1000000);
        public static readonly MassUoM Gram = new MassUoM("UoM.MassUoM.03", "g", "gram", 1000);
        public static readonly MassUoM Kilogram = new MassUoM("UoM.MassUoM.04", "kg", "kilogram", 1);
        public static readonly MassUoM Megagram = new MassUoM("UoM.MassUoM.05", "Mg", "megagram", 0.001);
        public static readonly MassUoM Ounce_Avoidrdupois = new MassUoM("UoM.MassUoM.06", "oz_av", "ounce (avoirdupois)", 35.273961949580411);
        public static readonly MassUoM TroyOunce = new MassUoM("UoM.MassUoM.07", "oz_tr", "ounce (troy or apothecary)", 32.150743);
        public static readonly MassUoM Pound_Avoirdupois = new MassUoM("UoM.MassUoM.08", "lb_av", "pound (avoirdupois)", 2.2046226218487757);
        public static readonly MassUoM TroyPound = new MassUoM("UoM.MassUoM.09", "lb_tr", "pound (troy or apothecary)", 2.679229);
        public static readonly MassUoM PoundMass = new MassUoM("UoM.MassUoM.10", "lbm", "pound mass", 2.2046226218487757);
        public static readonly MassUoM Ton_Assay = new MassUoM("UoM.MassUoM.11", "ton_as", "ton (assay)", 34.285675);
        public static readonly MassUoM Ton_Long = new MassUoM("UoM.MassUoM.12", "ton_l", "ton (long, 2240 lb)", 0.00098420652761106058);
        public static readonly MassUoM Tonne = new MassUoM("UoM.MassUoM.13", "tonne", "ton (SI)", 0.001);
        public static readonly MassUoM Ton_Short = new MassUoM("UoM.MassUoM.14", "stn", "ton (short, 2000 lb)", 0.0011023113109243879);
        public static readonly MassUoM Slug = new MassUoM("UoM.MassUoM.15", "slug", "slug", 0.068521765856791761);
        public static readonly MassUoM Slinch = new MassUoM("UoM.MassUoM.16", "slinch", "slinch", 0.0057101471547326465);
        public static readonly MassUoM Grain = new MassUoM("UoM.MassUoM.17", "gr", "grain", 15432.35835294143);
        public static readonly MassUoM Dram = new MassUoM("UoM.MassUoM.18", "dr", "dram", 564.3978);
        public static readonly MassUoM Stone = new MassUoM("UoM.MassUoM.19", "stone", "stone (UK)", 0.157473);
        public static readonly MassUoM HundredWeight = new MassUoM("UoM.MassUoM.20", "cwt_UK", "hundredweight (UK)", 0.01968413);
        public static readonly MassUoM Short_HundredWeight = new MassUoM("UoM.MassUoM.21", "scw", "short hundredweight (US)", 0.02204622);
        public static readonly MassUoM Carat_Metric = new MassUoM("UoM.MassUoM.22", "carat_met", "carat (metric)", 5000);
        public static readonly MassUoM PennyWeight = new MassUoM("UoM.MassUoM.23", "pennyweight", "pennyweight", 643.0149);
        public static readonly MassUoM Poundal = new MassUoM("UoM.MassUoM.24", "poundal", "poundal", 70.98765);
        public static readonly MassUoM Quarter_US = new MassUoM("UoM.MassUoM.25", "quarter_US", "quarter (US)", 0.08818);
        #endregion VALUES

        public MassUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }
    }
}