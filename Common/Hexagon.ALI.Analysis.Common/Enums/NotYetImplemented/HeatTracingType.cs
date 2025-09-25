namespace Analysis2.SIO.Library.Enums
{
    public class HeatTracingType : SIOEnum
    {
        #region VALUES
        public static readonly HeatTracingType None = new HeatTracingType("{AAF75DB1-E8F9-49B1-942F-F349515907FF}", "None", "", 1);
        public static readonly HeatTracingType Undefined = new HeatTracingType("{8C6774C0-D17C-4F13-8C52-4FD010E2E831}", "Undefined", "", 2);
        public static readonly HeatTracingType Electric = new HeatTracingType("{851C76CE-1529-419F-8ACF-BAC979C7B527}", "Electric", "", 3);
        public static readonly HeatTracingType Jacketed = new HeatTracingType("{39C33A9A-343E-43C5-A5D6-D61B0A80B123}", "Jackated", "", 4);
        public static readonly HeatTracingType NonJacketed = new HeatTracingType("{3F759F3D-B75A-4C64-BC19-C37520098878}", "Non-Jacketed", "", 5);
        #endregion
        public HeatTracingType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator HeatTracingType(string text)
        {
            return FindByText<HeatTracingType>(text);
        }
    }
}