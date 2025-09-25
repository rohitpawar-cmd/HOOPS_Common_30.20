using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class RotationalStiffnessUoM : SIOEnum
    {
        #region VALUES

        public static readonly RotationalStiffnessUoM N_m_rad = new RotationalStiffnessUoM("UoM.RotationalStiffnessUoM.01", "N-m/rad", "Newton-meter per radian", 1);
        public static readonly RotationalStiffnessUoM N_m_deg = new RotationalStiffnessUoM("UoM.RotationalStiffnessUoM.02", "N-m/deg", "Newton-meter per degree", 1.74532925199432957700000000000e-2);
        public static readonly RotationalStiffnessUoM N_mm_rad = new RotationalStiffnessUoM("UoM.RotationalStiffnessUoM.03", "N-mm/rad", "Newton-millimeter per radian", 1000);
        public static readonly RotationalStiffnessUoM N_mm_deg = new RotationalStiffnessUoM("UoM.RotationalStiffnessUoM.04", "N-mm/deg", "Newton-millimeter per degree", 1.745329251994329577000000000000E1);
        public static readonly RotationalStiffnessUoM kN_m_rad = new RotationalStiffnessUoM("UoM.RotationalStiffnessUoM.05", "kN-m/rad", "kilonewton-meter per radian", 0.001);
        public static readonly RotationalStiffnessUoM kN_m_deg = new RotationalStiffnessUoM("UoM.RotationalStiffnessUoM.06", "kN-m/deg", "kilonewton-meter per degree", 1.74532925199432957700000000000e-5);
        public static readonly RotationalStiffnessUoM lbf_in_rad = new RotationalStiffnessUoM("UoM.RotationalStiffnessUoM.07", "lbf-in/rad", "pound force-inch per radian", 8.8507457913271843665369847796527);
        public static readonly RotationalStiffnessUoM lbf_in_deg = new RotationalStiffnessUoM("UoM.RotationalStiffnessUoM.08", "lbf-in/deg", "pound force-inch per degree", 1.54474655315690000000E-01);
        public static readonly RotationalStiffnessUoM lbf_ft_rad = new RotationalStiffnessUoM("UoM.RotationalStiffnessUoM.09", "lbf-ft/rad", "pound force-foot per radian", 7.37562149277265000000E-01);
        public static readonly RotationalStiffnessUoM lbf_ft_deg = new RotationalStiffnessUoM("UoM.RotationalStiffnessUoM.10", "lbf-ft/deg", "pound force-foot per degree", 1.28728879429741960863191353510e-2);

        #endregion VALUES

        public RotationalStiffnessUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}