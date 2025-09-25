using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class AngleUoM : SIOEnum
    {
        #region VALUES

        public static readonly AngleUoM Circle = new AngleUoM("UoM.AngleUoM.07", "circle", "circle", 1.5915494309189533576699125506102E-01);
        public static readonly AngleUoM Circumference = new AngleUoM("UoM.AngleUoM.11", "circumf", "circumference", 1.5915494309189533576699125506102E-01);
        public static readonly AngleUoM Degree = new AngleUoM("UoM.AngleUoM.02", "deg", "degree", 57.295779513082320874293070516404);
        public static readonly AngleUoM Gradian = new AngleUoM("UoM.AngleUoM.05", "gr", "gradian", 6.3661977236758134316928620388641E+01);
        public static readonly AngleUoM Mil_Angular = new AngleUoM("UoM.AngleUoM.10", "mil_angular", "mil (Angular)", 1018.591636946850000);
        public static readonly AngleUoM Minute = new AngleUoM("UoM.AngleUoM.03", "min", "minute", 3.4377467707849392532454577549871E+03);
        public static readonly AngleUoM Quadrant = new AngleUoM("UoM.AngleUoM.08", "quad", "quadrant", 6.3661977236758134306796502024407E-01);
        public static readonly AngleUoM Radian = new AngleUoM("UoM.AngleUoM.01", "rad", "radian", 1.000000000000000);
        public static readonly AngleUoM Revolution = new AngleUoM("UoM.AngleUoM.06", "rev", "revolution", 1.5915494309189533576699125506102E-01);
        public static readonly AngleUoM Second = new AngleUoM("UoM.AngleUoM.04", "sec", "second", 2.0626480624709635515218229500307E+05);
        public static readonly AngleUoM Sign = new AngleUoM("UoM.AngleUoM.09", "sign", "sign", 1.909859317000000);

        #endregion VALUES

        public AngleUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}