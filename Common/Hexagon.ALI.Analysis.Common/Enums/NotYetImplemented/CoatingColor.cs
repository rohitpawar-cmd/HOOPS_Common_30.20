namespace Analysis2.SIO.Library.Enums
{
    public class CoatingColor : SIOEnum
    {
        #region VALUES
        public static readonly CoatingColor Undefined = new CoatingColor("{18E05EF2-9438-4D11-AB9B-B6CE2A61120C}", "Undefined", "", 1);
        public static readonly CoatingColor None = new CoatingColor("{B3D06B48-E51E-4ED2-A306-36E4DBE78598}", "None", "", 1);
        public static readonly CoatingColor Green = new CoatingColor("{8E1C9265-54D1-4A8B-B8EB-AAC5960D077E}", "Green", "", 1);
        public static readonly CoatingColor Yellow = new CoatingColor("{DBF469C6-51CA-40B5-89E4-3B336AD260CB}", "Yellow", "", 1);
        public static readonly CoatingColor Red = new CoatingColor("{F9758A79-D4F2-4753-8086-31A65F6F3817}", "Red", "", 1);
        public static readonly CoatingColor Blue = new CoatingColor("{BCDDFD25-3470-4670-A8CC-D1FB9A4CDD80}", "Blue", "", 1);
        public static readonly CoatingColor Silver = new CoatingColor("{3BF22D2B-B4ED-4F95-B9D8-E267A4A6667F}", "Silver", "", 1);
        public static readonly CoatingColor Black = new CoatingColor("{2F284245-39ED-4350-BE41-46A9F1BB0613}", "Black", "", 1);
        #endregion
        public CoatingColor(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator CoatingColor(string text)
        {
            return FindByText<CoatingColor>(text);
        }
    }
}