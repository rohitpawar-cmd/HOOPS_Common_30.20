namespace Analysis2.SIO.Library.Enums
{
    public class FluidSystem : SIOEnum
    {
        #region VALUES
        public static readonly FluidSystem Undefined = new FluidSystem("{0AC10D02-97DA-477C-B9B8-92431183AAAC}", "Undefined", "", 1);
        public static readonly FluidSystem Air = new FluidSystem("{FD96270A-FFE2-4417-B90A-4DF8551A9F05}", "Air", "", 5);
        public static readonly FluidSystem Refrigerant = new FluidSystem("{D1D4194E-7EDD-479A-BBF8-2A06C3194402}", "Refrigerant", "", 10);
        public static readonly FluidSystem Sewer = new FluidSystem("{09531480-4E25-4C2A-9173-2C34F63E977A}", "Sewer", "", 15);
        public static readonly FluidSystem Foam = new FluidSystem("{F10C1F68-0179-4034-9F47-294EBDEE239E}", "Foam", "", 20);
        public static readonly FluidSystem Gas = new FluidSystem("{D8598A99-A0B6-4216-B8DD-1E60262E91EE}", "Gas", "", 25);
        public static readonly FluidSystem Solvent = new FluidSystem("{26AE2C17-6DCF-4A74-856D-432B7328E8EE}", "Solvent", "", 30);
        public static readonly FluidSystem Chemical = new FluidSystem("{A729B087-24B7-4418-A185-53CAA90C2286}", "Chemical", "", 35);
        public static readonly FluidSystem Oil = new FluidSystem("{104E7730-99EF-49C6-A928-D8CD78394381}", "Oil", "", 40);
        public static readonly FluidSystem Process = new FluidSystem("{9EF097AE-2FAB-4FB1-9C60-D1ADAA6DFCE9}", "Process", "", 45);
        public static readonly FluidSystem Relief = new FluidSystem("{7B759427-CEED-4672-B96D-2C57A5640A23}", "Relief", "", 50);
        public static readonly FluidSystem Steam = new FluidSystem("{7B1F67ED-B033-4BF3-BC63-A4A0DE4876CF}", "Steam", "", 55);
        public static readonly FluidSystem SteamCondensate = new FluidSystem("{C3EC3487-489B-4518-AB34-604B4777F76A}", "Steam Condensate", "", 60);
        public static readonly FluidSystem Vent = new FluidSystem("{2A485334-43DE-4C22-AB33-ACED686DCBF6}", "Vent", "", 65);
        public static readonly FluidSystem Water = new FluidSystem("{FBDB1100-74A7-4E14-B4D7-C5995D00456E}", "Water", "", 70);
        public static readonly FluidSystem Acid = new FluidSystem("{0BE55A79-D405-4E63-927C-18B83AA5CB64}", "Acid", "", 75);
        public static readonly FluidSystem Catalyst = new FluidSystem("{CFDF4B69-8A4E-4CA4-8B77-CC13D6DC5024}", "Catalyst", "", 80);
        #endregion
        public FluidSystem(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator FluidSystem(string text)
        {
            return FindByText<FluidSystem>(text);
        }
    }
}