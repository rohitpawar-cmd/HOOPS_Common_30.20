using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class WeightPerUnitLengthUoM : SIOEnum
    {
        #region VALUES
        public static readonly WeightPerUnitLengthUoM KilogramPerKilometer = new WeightPerUnitLengthUoM("{563F625B-0678-45A7-B085-E8819AC7506E}", "kg/km", "kilogram per kilometer", 1.00E3);
        public static readonly WeightPerUnitLengthUoM KilogramPerMeter = new WeightPerUnitLengthUoM("UoM.WeightPerUnitLength.01", "kg/m", "kilogram per meter", 1);
        public static readonly WeightPerUnitLengthUoM PoundPer1000Foot = new WeightPerUnitLengthUoM("{B665BF96-2E03-4FBF-B22B-EA9A98C2AD1D}", "lb/1000ft", "pound per thousand foot", 6.719689751E2);
        public static readonly WeightPerUnitLengthUoM PoundPerYard = new WeightPerUnitLengthUoM("{E5141EA0-9CA1-4CE8-957D-52BCA3C78EA2}", "lb/yd", "pound per yard", 2.015906925419);
        public static readonly WeightPerUnitLengthUoM PoundPerMile = new WeightPerUnitLengthUoM("{2333C3D6-39A3-4DA8-8A1B-8D0465D76B73}", "lb/mi_int", "pound per mile", 3.547996189E3);
        public static readonly WeightPerUnitLengthUoM PoundPerFoot = new WeightPerUnitLengthUoM("c2144cfc-0175-426e-8146-6865c06cd611", "lb/ft", "pound per foot", 0.671968975);
        #endregion VALUES

        public WeightPerUnitLengthUoM(string uid, string text, string description, double number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}