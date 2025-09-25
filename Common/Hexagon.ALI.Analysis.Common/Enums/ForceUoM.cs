using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class ForceUoM : SIOEnum
    {
        #region VALUES

        public static readonly ForceUoM Dyn = new ForceUoM("UoM.Force.11", "dyn", "dyne", 100000);
        public static readonly ForceUoM gf = new ForceUoM("UoM.Force.08", "gf", "gram-force", 101.9716);
        public static readonly ForceUoM kgf = new ForceUoM("UoM.Force.09", "kgf", "kilogram-force", 0.1019716);
        public static readonly ForceUoM kip = new ForceUoM("UoM.Force.12", "kip", "kip (1000 lbf)", 2.24808943099710482910039413403e-4);
        public static readonly ForceUoM kN = new ForceUoM("UoM.Force.04", "kN", "kiloNewton", 0.001);
        public static readonly ForceUoM kp = new ForceUoM("UoM.Force.10", "kp", "kilopond", 0.1019716);
        public static readonly ForceUoM lbf = new ForceUoM("UoM.Force.06", "lbf", "pound-force (lbf)", 2.2480894309971048291003941340318E-01);
        public static readonly ForceUoM mN = new ForceUoM("UoM.Force.02", "mN", "milliNewton", 1000);
        public static readonly ForceUoM N = new ForceUoM("UoM.Force.03", "N", "Newton", 1);
        public static readonly ForceUoM nN = new ForceUoM("UoM.Force.01", "nN", "nanoNewtons", 1000000000);
        public static readonly ForceUoM ozf = new ForceUoM("UoM.Force.05", "ozf", "ounce-force", 3.596942);
        public static readonly ForceUoM plf = new ForceUoM("UoM.Force.14", "plf", "unit shear force (plf)", 0.06852177);
        public static readonly ForceUoM Poundal = new ForceUoM("UoM.Force.13", "poundal", "poundal", 7.233011);
        public static readonly ForceUoM tonf = new ForceUoM("UoM.Force.07", "tonf", "ton-force (2000 lbf)", 0.0001124045);

        #endregion VALUES

        public ForceUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}