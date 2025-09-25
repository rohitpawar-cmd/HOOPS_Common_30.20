using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class AreaUoM : SIOEnum
    {
        #region VALUES

        public static readonly AreaUoM SquareMilimeter = new AreaUoM("UoM.AreaUoM.01", "mm^2", "square millimeter", 1000000);
        public static readonly AreaUoM SquareCentimeter = new AreaUoM("UoM.AreaUoM.02", "cm^2", "square centimeter", 10000);
        public static readonly AreaUoM SquareDecimeter = new AreaUoM("UoM.AreaUoM.03", "dm^2", "square decimeter", 100);
        public static readonly AreaUoM SquareMeter = new AreaUoM("UoM.AreaUoM.04", "m^2", "square meter", 1);
        public static readonly AreaUoM SquareDekameter = new AreaUoM("UoM.AreaUoM.05", "dam^2", "square dekameter", 0.01);
        public static readonly AreaUoM SquareHectometer = new AreaUoM("UoM.AreaUoM.06", "hm^2", "square hectometer", 0.001);
        public static readonly AreaUoM SquareKiloMeter = new AreaUoM("UoM.AreaUoM.07", "km^2", "square kilometer", 0.000001);
        public static readonly AreaUoM SquareInch = new AreaUoM("UoM.AreaUoM.08", "in^2", "square inch", 1.55E+03);
        public static readonly AreaUoM SquareFootUS = new AreaUoM("UoM.AreaUoM.09", "ft^2_US", "square foot (US)", 1.08E+01);
        public static readonly AreaUoM SquareYard = new AreaUoM("UoM.AreaUoM.10", "yd^2", "square yard", 1.195990046);
        public static readonly AreaUoM SquareMileInternational = new AreaUoM("UoM.AreaUoM.11", "mi^2_int", "square mile (international)", 3.86E-07);
        public static readonly AreaUoM SquareMileUS = new AreaUoM("UoM.AreaUoM.12", "mi^2", "square mile (US survey foot)", 3.86E-07);
        public static readonly AreaUoM CircularInch = new AreaUoM("UoM.AreaUoM.13", "in_circ", "circular inch", 1973.525241);
        public static readonly AreaUoM CircularFoot = new AreaUoM("UoM.AreaUoM.14", "ft_circ", "circular foot", 13.7050364);
        public static readonly AreaUoM CircularMilimeter = new AreaUoM("UoM.AreaUoM.15", "mm_circ", "circular mm", 1273239.49);
        public static readonly AreaUoM CircularCentimeter = new AreaUoM("UoM.AreaUoM.16", "cm_circ", "circular cm", 12732.3955);
        public static readonly AreaUoM Acre = new AreaUoM("UoM.AreaUoM.17", "ac", "acre", 2.47E-04);
        public static readonly AreaUoM Hektare = new AreaUoM("UoM.AreaUoM.18", "ha", "hektare", 0.0001);
        public static readonly AreaUoM Are = new AreaUoM("UoM.AreaUoM.19", "ar", "are", 0.01);
        public static readonly AreaUoM Centare = new AreaUoM("UoM.AreaUoM.20", "centare", "", 1);
        public static readonly AreaUoM SquareMil = new AreaUoM("UoM.AreaUoM.21", "mil^2", "square mil", 1550003100);
        public static readonly AreaUoM CircularMil = new AreaUoM("UoM.AreaUoM.22", "circ mil", "circular mil", 1.97E+09);
        public static readonly AreaUoM QuarterSection = new AreaUoM("UoM.AreaUoM.23", "quartersection_US", "quartersection (US)", 1.54E-06);
        public static readonly AreaUoM Section = new AreaUoM("UoM.AreaUoM.24", "section", "", 3.86E-07);
        public static readonly AreaUoM Rood = new AreaUoM("UoM.AreaUoM.25", "rood", "rood (UK)", 9.88E-04);
        public static readonly AreaUoM Darcy = new AreaUoM("UoM.AreaUoM.26", "darcy", "", 1.01E+12);
        public static readonly AreaUoM SquareRood = new AreaUoM("UoM.AreaUoM.27", "rod^2", "square rod", 0.03953686);
        public static readonly AreaUoM SquarePerch = new AreaUoM("UoM.AreaUoM.28", "perch^2", "square perch", 0.03953686);
        public static readonly AreaUoM SquareLink = new AreaUoM("UoM.AreaUoM.29", "link^2", "square link (Gunter's)", 24.71053799);
        public static readonly AreaUoM SquareChain = new AreaUoM("UoM.AreaUoM.30", "chain^2", "square chain (Gunter's)", 0.002471053);
        public static readonly AreaUoM SquarePole = new AreaUoM("UoM.AreaUoM.31", "pole^2", "square pole (UK)", 3.95E-02);
        public static readonly AreaUoM SquareFoot = new AreaUoM("UoM.AreaUoM.32", "ft^2", "square foot (US)", 1.08E+01);

        #endregion VALUES

        public AreaUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}