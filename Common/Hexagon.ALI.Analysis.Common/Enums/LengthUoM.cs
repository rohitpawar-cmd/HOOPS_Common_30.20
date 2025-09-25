using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class ElevationUoM : LengthUoM
    {
        public ElevationUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class CompoundLengthUoM : LengthUoM
    {
        public CompoundLengthUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class DiameterUoM : LengthUoM
    {
        public DiameterUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class ThicknessUoM : LengthUoM
    {
        public ThicknessUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class LengthUoM : SIOEnum
    {
        #region VALUES

        public static readonly LengthUoM Angstrom = new LengthUoM("UoM.LengthUoM.01", "A", "Angstrom", 10000000000);
        public static readonly LengthUoM Cable_US = new LengthUoM("UoM.LengthUoM.31", "cable_US", "cable (US)", 0.00546806649168854);
        public static readonly LengthUoM Cable_US_Navy = new LengthUoM("UoM.LengthUoM.32", "cable_US_Navy", "navy cable length (US)", 0.004556722);
        public static readonly LengthUoM Chain = new LengthUoM("UoM.LengthUoM.27", "chain", "chain (surveyor)", 0.0497096953789867);
        public static readonly LengthUoM Centimeter = new LengthUoM("UoM.LengthUoM.05", "cm", "centimeter", 100);
        public static readonly LengthUoM Cubit = new LengthUoM("UoM.LengthUoM.41", "cubit", "cubit", 2.18722659);
        public static readonly LengthUoM Dekameter = new LengthUoM("UoM.LengthUoM.08", "dam", "dekameter", 0.1);
        public static readonly LengthUoM Decimeter = new LengthUoM("UoM.LengthUoM.06", "dm", "decimeter", 10);
        public static readonly LengthUoM Ell_UK = new LengthUoM("UoM.LengthUoM.30", "ell_UK", "ell (UK)", 0.874890638);
        public static readonly LengthUoM Fathom = new LengthUoM("UoM.LengthUoM.20", "fathom", "fathom", 0.546806659);
        public static readonly LengthUoM Foot = new LengthUoM("UoM.LengthUoM.14", "ft", "foot", 3.2808398950131233595800524934383);
        public static readonly LengthUoM Furlong = new LengthUoM("UoM.LengthUoM.28", "furlong", "furlong", 0.00497096953789867);
        public static readonly LengthUoM Hand = new LengthUoM("UoM.LengthUoM.39", "hand", "hand", 9.842519685);
        public static readonly LengthUoM Hectometer = new LengthUoM("UoM.LengthUoM.09", "hm", "hectometer", 0.01);
        public static readonly LengthUoM Hundredth_Inch = new LengthUoM("UoM.LengthUoM.45", "hundredth", "hundredth of inch", 3.937007874015748031496062992126E+03);
        public static readonly LengthUoM Inch = new LengthUoM("UoM.LengthUoM.13", "in", "inch", 39.37007874015748031496062992126);
        public static readonly LengthUoM Kilometer = new LengthUoM("UoM.LengthUoM.10", "km", "kilometer", 0.001);
        public static readonly LengthUoM League = new LengthUoM("UoM.LengthUoM.21", "league", "league", 2.07123730745778E-04);
        public static readonly LengthUoM Marine_League = new LengthUoM("UoM.LengthUoM.22", "league_ma", "marine league", 0.000179985601151908);
        public static readonly LengthUoM Line_UK = new LengthUoM("UoM.LengthUoM.42", "line_UK", "line (UK)", 472.4409448);
        public static readonly LengthUoM Link = new LengthUoM("UoM.LengthUoM.26", "link", "link (surveyor)", 4.97096953789867);
        public static readonly LengthUoM Meter = new LengthUoM("UoM.LengthUoM.07", "m", "meter", 1);
        public static readonly LengthUoM Micro_Inch = new LengthUoM("UoM.LengthUoM.12", "uin", "microinch", 39370078.74015748031496062992126);
        public static readonly LengthUoM Mil_Inch = new LengthUoM("UoM.LengthUoM.23", "mil", "mil (thousandths of an inch)", 3.937007874015748031496062992126E+04);
        public static readonly LengthUoM Mile_International = new LengthUoM("UoM.LengthUoM.16", "mi_Int", "mile (international)", 6.21371192237333969617434184363e-4);
        public static readonly LengthUoM Mile_Nautical_International = new LengthUoM("UoM.LengthUoM.18", "mi_naut_Int", "mile (nautical, international)", 0.0005399568);
        public static readonly LengthUoM Mile_Nautical_US = new LengthUoM("UoM.LengthUoM.19", "mi_naut_US", "mile (US nautical)", 0.0005399568);
        public static readonly LengthUoM Mile_US_Statute = new LengthUoM("UoM.LengthUoM.17", "mi_US_statute", "mile (US statute)", 0.0006213882);
        public static readonly LengthUoM Megameter = new LengthUoM("UoM.LengthUoM.11", "Mm", "megameter", 0.000001);
        public static readonly LengthUoM Milimeter = new LengthUoM("UoM.LengthUoM.04", "mm", "millimeter", 1000);
        public static readonly LengthUoM Micron = new LengthUoM("UoM.LengthUoM.03", "mu", "micron", 1000000);
        public static readonly LengthUoM Nanometer = new LengthUoM("UoM.LengthUoM.02", "nm", "nanometer", 1000000000);
        public static readonly LengthUoM Pace_Military = new LengthUoM("UoM.LengthUoM.36", "pace", "pace (Military)", 1.312335958);
        public static readonly LengthUoM Palm = new LengthUoM("UoM.LengthUoM.37", "palm", "palm", 13.12335958);
        public static readonly LengthUoM Perch = new LengthUoM("UoM.LengthUoM.33", "perch", "perch", 0.19883878);
        public static readonly LengthUoM Pica = new LengthUoM("UoM.LengthUoM.43", "pica", "pica", 237.1062992);
        public static readonly LengthUoM Pole = new LengthUoM("UoM.LengthUoM.25", "pole", "pole", 0.198838781515947);
        public static readonly LengthUoM Point = new LengthUoM("UoM.LengthUoM.29", "pt", "point", 2.83464566929133858249860499721E+3);
        public static readonly LengthUoM Quarter_UK = new LengthUoM("UoM.LengthUoM.35", "quarter_UK", "quarter (UK linear)", 4.374453193);
        public static readonly LengthUoM Rod = new LengthUoM("UoM.LengthUoM.24", "rod", "rod (surveyor)", 0.198838781515947);
        public static readonly LengthUoM Rope_UK = new LengthUoM("UoM.LengthUoM.34", "rope", "rope (UK)", 0.164041994);
        public static readonly LengthUoM Skein = new LengthUoM("UoM.LengthUoM.40", "skein", "skein", 0.00911344);
        public static readonly LengthUoM Span = new LengthUoM("UoM.LengthUoM.38", "span", "span", 4.374453193);
        public static readonly LengthUoM Tenth_Inch = new LengthUoM("UoM.LengthUoM.44", "tenth", "tenths of inch", 3.937007874015748031496062992126E+02);
        public static readonly LengthUoM Yard = new LengthUoM("UoM.LengthUoM.15", "yd", "yard", 1.0936132983377077865266841644794);

        #endregion VALUES

        public LengthUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}