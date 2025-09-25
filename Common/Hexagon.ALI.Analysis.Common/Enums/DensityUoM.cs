using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class FluidDensityUoM : DensityUoM
    {
        public FluidDensityUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class PipeDensityUoM : DensityUoM
    {
        public PipeDensityUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class InsulationDensityUoM : DensityUoM
    {
        public InsulationDensityUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class DensityUoM : SIOEnum
    {
        #region VALUES

        public static readonly DensityUoM g_cm_3 = new DensityUoM("UoM.DensityUoM.11", "g/cm^3", "gram per cubic centimeter", 0.001);
        public static readonly DensityUoM g_ft_3 = new DensityUoM("UoM.DensityUoM.22", "g/ft^3", "gram per cubic foot", 28.31701649);
        public static readonly DensityUoM g_kl = new DensityUoM("UoM.DensityUoM.20", "g/kl", "gram per kiloliter", 1000);
        public static readonly DensityUoM g_L = new DensityUoM("UoM.DensityUoM.18", "g/L", "gram per liter", 1);
        public static readonly DensityUoM g_ml_3 = new DensityUoM("UoM.DensityUoM.21", "g/ml^3", "gram per cubic milliliter", 0.001);
        public static readonly DensityUoM g_m_3 = new DensityUoM("UoM.DensityUoM.03", "g/m^3", "gram per cubic meter", 1000);
        public static readonly DensityUoM gr_gal_US_liq = new DensityUoM("UoM.DensityUoM.07", "gr/gal_US_liq", "grain per gal (US liquid)", 5.841783E+01);
        public static readonly DensityUoM gr_in_3 = new DensityUoM("UoM.DensityUoM.08", "gr/in^3", "grain per cubic inch", 0.252857580945184);
        public static readonly DensityUoM gr_m_3 = new DensityUoM("UoM.DensityUoM.10", "gr/m^3", "grain per cubic meter", 1.5432358352941430650608166094152E4);
        public static readonly DensityUoM kg_cm_3 = new DensityUoM("UoM.DensityUoM.06", "kg/cm^3", "kilogram per cubic centimeter", 1.00E-06);
        public static readonly DensityUoM kg_hl = new DensityUoM("UoM.DensityUoM.19", "kg/hl", "kilogram per hectoliter", 0.1);
        public static readonly DensityUoM kg_L = new DensityUoM("UoM.DensityUoM.23", "kg/L", "kilogram per liter", 0.001);
        public static readonly DensityUoM kg_mm_3 = new DensityUoM("UoM.DensityUoM.05", "kg/mm^3", "kilogram per cubic millimeter", 1.00E-09);
        public static readonly DensityUoM kg_m_3 = new DensityUoM("UoM.DensityUoM.04", "kg/m^3", "kilogram per cubic meter", 1);
        public static readonly DensityUoM kipm_ft_3 = new DensityUoM("UoM.DensityUoM.53", "kipm/ft^3", "kip mass per cubic foot", 6.24279605761446119549811798454E-05);
        public static readonly DensityUoM lb_bbl = new DensityUoM("UoM.DensityUoM.44", "lb/bbl", "pound per barrel", 0.3509);
        public static readonly DensityUoM lb_m_3 = new DensityUoM("UoM.DensityUoM.31", "lb/m^3", "pound per cubic meter", 2.204622476);
        public static readonly DensityUoM lb_yd_3 = new DensityUoM("UoM.DensityUoM.37", "lb/yd^3", "pound per cubic yard", 1.6855549959512968997249848468606);
        public static readonly DensityUoM lbm_ft_3 = new DensityUoM("UoM.DensityUoM.33", "lbm/ft^3", "pound mass per cubic foot", 6.24279605761446119549811798454e-2);
        public static readonly DensityUoM lbm_gal_Imp = new DensityUoM("UoM.DensityUoM.34", "lbm/gal_Imp", "pound per gallon (Imperial)", 1.002242E-02);
        public static readonly DensityUoM lbm_gal_UK_liq = new DensityUoM("UoM.DensityUoM.36", "lbm/gal_UK_liq", "pound per gallon (UK liquid)", 1.00224167155495097709069728461E-02);
        public static readonly DensityUoM lbm_gal_US_liq = new DensityUoM("UoM.DensityUoM.35", "lbm/gal_US_liq", "pound per gallon (US liquid)", 8.34540624789848509566689242549E-03);
        public static readonly DensityUoM lbm_in_3 = new DensityUoM("UoM.DensityUoM.32", "lbm/in^3", "pound mass per cubic inch", 3.61272920000836874794814104437E-05);
        public static readonly DensityUoM lb_apoth_m_3 = new DensityUoM("UoM.DensityUoM.38", "lb_apoth/m^3", "pound (apothecary) per cubic meter", 2.67922903);
        public static readonly DensityUoM lb_av_m_3 = new DensityUoM("UoM.DensityUoM.30", "lb_av/m^3", "pound (avoirdupois) per cubic meter", 2.204622476);
        public static readonly DensityUoM mg_cm_3 = new DensityUoM("UoM.DensityUoM.01", "mg/cm^3", "milligram per cubic centimeter", 1);
        public static readonly DensityUoM mg_kl = new DensityUoM("UoM.DensityUoM.24", "mg/kl", "milligram per kiloliter", 1000000);
        public static readonly DensityUoM mg_L = new DensityUoM("UoM.DensityUoM.17", "mg/L", "milligram per liter", 1000);
        public static readonly DensityUoM mg_ml = new DensityUoM("UoM.DensityUoM.15", "mg/ml", "milligram per milliliter", 1);
        public static readonly DensityUoM mg_m_3 = new DensityUoM("UoM.DensityUoM.02", "mg/m^3", "milligram per cubic meter", 1000000);
        public static readonly DensityUoM oz_m_3 = new DensityUoM("UoM.DensityUoM.28", "oz/m^3", "ounce per cubic meter", 35.27396583);
        public static readonly DensityUoM oz_av_gal_Imp = new DensityUoM("UoM.DensityUoM.25", "oz_av/gal_Imp", "ounce (avoirdupois) per gallon (Imperial)", 1.603586E-01);
        public static readonly DensityUoM oz_av_gal_US = new DensityUoM("UoM.DensityUoM.26", "oz_av/gal_US", "ounce (avoirdupois) per gallon (US liquid)", 1.335265E-01);
        public static readonly DensityUoM oz_av_in_3 = new DensityUoM("UoM.DensityUoM.27", "oz_av/in^3", "ounce (avoirdupois) per cubic inch", 5.780367E-04);
        public static readonly DensityUoM oz_av_m_3 = new DensityUoM("UoM.DensityUoM.29", "oz_av/m^3", "ounce (avoirdupois) per cubic meter", 35.27396853);
        public static readonly DensityUoM slinch_in_3 = new DensityUoM("UoM.DensityUoM.41", "slinch/in^3", "slinch per inch cu", 9.35725468740217772887762108349E-08);
        public static readonly DensityUoM slug_ft_3 = new DensityUoM("UoM.DensityUoM.39", "slug/ft^3", "slug per cubic foot", 1.94032033197971557281136881679E-03);
        public static readonly DensityUoM slug_m_3 = new DensityUoM("UoM.DensityUoM.40", "slug/m^3", "slug per cubic meter", 0.068521779);
        public static readonly DensityUoM ton_m_3 = new DensityUoM("UoM.DensityUoM.45", "ton/m^3", "ton per cubic meter", 0.00110231);
        public static readonly DensityUoM tonne_m_3 = new DensityUoM("UoM.DensityUoM.49", "tonne/m^3", "metric ton per cubic meter", 0.001);
        public static readonly DensityUoM ton_as_m_3 = new DensityUoM("UoM.DensityUoM.50", "ton_as/m^3", "assay ton per cubic meter", 34.28571036);
        public static readonly DensityUoM ton_l_m_3 = new DensityUoM("UoM.DensityUoM.47", "ton_l/m^3", "ton, long, per cubic meter", 0.000984206);
        public static readonly DensityUoM ton_l_yd_3 = new DensityUoM("UoM.DensityUoM.42", "ton_l/yd^3", "ton, long, per cubic yard", 7.524800E-04);
        public static readonly DensityUoM ton_s_ft_3 = new DensityUoM("UoM.DensityUoM.54", "ton_s/ft^3", "ton, short, per cubic foot", 0.00003121398);
        public static readonly DensityUoM ton_s_m_3 = new DensityUoM("UoM.DensityUoM.46", "ton_s/m^3", "ton, short, per cubic meter", 0.00110231);
        public static readonly DensityUoM ton_s_yd_3 = new DensityUoM("UoM.DensityUoM.43", "ton_s/yd^3", "ton, short, per cubic yard", 8.427774E-04);

        #endregion VALUES

        public DensityUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}