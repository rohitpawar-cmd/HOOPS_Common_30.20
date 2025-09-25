using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class MomentInputUoM : MomentTorqueUoM
    {
        public MomentInputUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class MomentOutputUoM : MomentTorqueUoM
    {
        public MomentOutputUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
        }
    }
    [ExcludeFromCodeCoverage]
    public class MomentTorqueUoM : SIOEnum
    {
        #region VALUES

        public static readonly MomentTorqueUoM Nm = new MomentTorqueUoM("UoM.MomentTorque.01", "Nm", "Newton-meter", 1);
        public static readonly MomentTorqueUoM dyncm = new MomentTorqueUoM("UoM.MomentTorque.06", "dyn-cm", "dyne-centimeter", 10000000);
        public static readonly MomentTorqueUoM kNm = new MomentTorqueUoM("UoM.MomentTorque.02", "kNm", "kilonewton-meter", 0.001);
        public static readonly MomentTorqueUoM kgfm = new MomentTorqueUoM("UoM.MomentTorque.05", "kgf-m", "kilogram force per meter", 0.1019716);
        public static readonly MomentTorqueUoM lbfft = new MomentTorqueUoM("UoM.MomentTorque.03", "lbf-ft", "foot-pound force", 0.7375621);
        public static readonly MomentTorqueUoM lbfin = new MomentTorqueUoM("UoM.MomentTorque.04", "lbf-in", "inch-pound force", 8.850748);
        public static readonly MomentTorqueUoM ozfin = new MomentTorqueUoM("UoM.MomentTorque.07", "ozf-in", "inch-ounce force", 141.6119);

        #endregion VALUES

        public MomentTorqueUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}