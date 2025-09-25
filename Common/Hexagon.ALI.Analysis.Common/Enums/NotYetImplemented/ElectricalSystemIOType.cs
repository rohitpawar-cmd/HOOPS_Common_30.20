namespace Analysis2.SIO.Library.Enums
{
    public class ElectricalSystemIOType : SIOEnum
    {
        #region VALUES
        public static readonly ElectricalSystemIOType Ai = new ElectricalSystemIOType("{1ee3a050-061d-4b4b-ad9a-131291b7845f}", "AI", "Analog Input", 10);
        public static readonly ElectricalSystemIOType Ao = new ElectricalSystemIOType("{a57b37d0-404b-4b70-bfad-b91aecdd60e7}", "AO", "Analog Output", 15);
        public static readonly ElectricalSystemIOType DiAc = new ElectricalSystemIOType("{5648f707-355b-4a2f-9136-ea84951bb96a}", "DI AC", "Discrete Input (Alternating Current)", 20);
        public static readonly ElectricalSystemIOType DoAc = new ElectricalSystemIOType("{b90cebe3-6cbb-405f-85b2-6a7bfefaec4a}", "DO AC", "Discrete Output (Alternating Current)", 25);
        public static readonly ElectricalSystemIOType Fieldbus = new ElectricalSystemIOType("{741ca31e-7977-4f66-8643-322063843f2c}", "Fieldbus", "", 30);
        public static readonly ElectricalSystemIOType Pi = new ElectricalSystemIOType("{5da81b2c-de9b-458b-9c6d-2718d835695b}", "PI", "Pulse Input", 35);
        public static readonly ElectricalSystemIOType Rtd = new ElectricalSystemIOType("{d0c8a4e1-bfac-4f2b-b969-6cde342e8dda}", "RTD", "Resistance Temperature Device", 40);
        public static readonly ElectricalSystemIOType SerialInterface = new ElectricalSystemIOType("{b6bf8e2e-d38c-4620-ab83-3e7ef0fd8096}", "SerialInterface", "", 45);
        public static readonly ElectricalSystemIOType Tc = new ElectricalSystemIOType("{d217fac4-63e9-4287-8014-9a723f324c1b}", "TC", "Thermocouple", 50);
        public static readonly ElectricalSystemIOType AiHart = new ElectricalSystemIOType("{61de74e8-d64d-437c-b8e4-46a8ef0eb4af}", "AI+HART", "Analog I/O Module (with HART Communication Function)", 5);
        public static readonly ElectricalSystemIOType DiDc = new ElectricalSystemIOType("{f8e64de3-7dce-4e53-a442-22df687390cd}", "DI DC", "Discrete Input (Direct Current)", 90);
        public static readonly ElectricalSystemIOType DoDc = new ElectricalSystemIOType("{b9a6c3eb-68c4-4a55-9b01-f6cbc43ad6c0}", "DO DC", "Discrete Output (Direct Current)", 91);
        public static readonly ElectricalSystemIOType Dv = new ElectricalSystemIOType("{171bc065-a35a-4149-8895-bd4fefed69cb}", "DV", "DeviceNet", 93);
        public static readonly ElectricalSystemIOType Vib = new ElectricalSystemIOType("{ebb2327e-fdff-413c-a166-4e504fbde8b4}", "VIB", "Vibration", 94);
        public static readonly ElectricalSystemIOType HartAo = new ElectricalSystemIOType("{871cf49b-8f5c-4d08-a1f7-d198ff60869c}", "HART AO", "HART Analog Output", 92);
        #endregion
        public ElectricalSystemIOType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator ElectricalSystemIOType(string text)
        {
            return FindByText<ElectricalSystemIOType>(text);
        }
    }
}