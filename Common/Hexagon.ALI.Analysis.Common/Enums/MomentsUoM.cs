using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]

    public class MomentsUoM : SIOEnum
    {
        #region VALUES

        public static readonly MomentsUoM FootPound = new MomentsUoM("UoM.Moments.03", "ft-lb", "foot-pound", 0.7376);
        public static readonly MomentsUoM NewtonMeter = new MomentsUoM("UoM.Moments.02", "Nm", "Newton-meter", 1);
        public static readonly MomentsUoM NewtonMillimeter = new MomentsUoM("UoM.Moments.01", "Nmm", "Newton-millimeter", 1000);

        #endregion VALUES

        public MomentsUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}