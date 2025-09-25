using System;

namespace Hexagon.ALI.Analysis.Common.Helpers
{
    public static class NumberExtensions
    {
        public enum ePrecsion { Three, Four, Five, Six, Seven }

        const ePrecsion Default = ePrecsion.Six;

        const double _3 = 0.001;
        const double _4 = 0.0001;
        const double _5 = 0.00001;
        const double _6 = 0.000001;
        const double _7 = 0.0000001;

        public static bool Equals(this double left, double right, ePrecsion ePrecision)
        {
            double precision;
            switch (ePrecision)
            {
                case ePrecsion.Three:
                    precision = _3; break;
                case ePrecsion.Four:
                    precision = _4; break;
                case ePrecsion.Five:
                    precision = _5; break;
                default:
                case ePrecsion.Six:
                    precision = _6; break;
                case ePrecsion.Seven:
                    precision = _7; break;
            }
            return Math.Abs(left - right) < precision;
        }

        public static bool IsZero(this double value, ePrecsion precsion = Default)
        {
            return value.Equals(0d, ePrecsion.Six);
        }
    }
}
