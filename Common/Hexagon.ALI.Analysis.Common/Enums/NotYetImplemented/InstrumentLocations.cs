namespace Analysis2.SIO.Library.Enums
{
    public class InstrumentLocations : SIOEnum
    {
        #region VALUES
        public static readonly InstrumentLocations Field = new InstrumentLocations("{67fc5e07-454b-4f89-ba67-69a43a1ad6ad}", "Field", "", 50);
        public static readonly InstrumentLocations ControlPanel = new InstrumentLocations("{edef78f9-7234-425a-9ca6-5667a69d3d63}", "Control Panel", "Control Panel", 51);
        public static readonly InstrumentLocations Remote = new InstrumentLocations("{0ce15f61-f0cb-4e5e-b1d5-cf944da4e5be}", "Remote", "Remote", 52);
        #endregion
        public InstrumentLocations(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator InstrumentLocations(string text)
        {
            return FindByText<InstrumentLocations>(text);
        }
    }
}