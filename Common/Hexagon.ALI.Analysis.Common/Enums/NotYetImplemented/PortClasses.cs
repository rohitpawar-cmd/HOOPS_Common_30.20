namespace Analysis2.SIO.Library.Enums
{
    public class PortClasses : SIOEnum
    {
        #region VALUES
        public static readonly PortClasses Pipingport = new PortClasses("{e00068d3-bcbb-4f88-aba4-fd8f1e7129e9}", "PipingPort", "", 1);
        public static readonly PortClasses Pipetapport = new PortClasses("{1004966e-7844-4d4a-b66f-0053090a5a97}", "PipeTapPort", "", 2);
        public static readonly PortClasses Pipenozzle = new PortClasses("{4def9c4c-9e78-4b1d-8422-7aa99350dd03}", "PipeNozzle", "", 3);
        public static readonly PortClasses Conductorport = new PortClasses("{30e83c17-dca4-444e-9a52-e7c57d94a91f}", "ConductorPort", "", 4);
        public static readonly PortClasses Cableport = new PortClasses("{0b036b83-e76c-4e24-8735-f8750cea6811}", "CablePort", "", 6);
        public static readonly PortClasses Cablenozzle = new PortClasses("{728f807b-8c7f-4d5b-af36-5728cd67efa1}", "CableNozzle", "", 7);
        public static readonly PortClasses Cabletrayport = new PortClasses("{5205e23f-4905-4000-aa65-98ccf28dc252}", "CableTrayPort", "", 8);
        public static readonly PortClasses Conduitport = new PortClasses("{496db250-8996-4ff4-868e-5c42fbde20c4}", "ConduitPort", "", 9);
        public static readonly PortClasses Cabletraynozzle = new PortClasses("{1e7b704e-5225-4f1b-ae29-59e04b6c83f7}", "CableTrayNozzle", "", 10);
        public static readonly PortClasses Conduitnozzle = new PortClasses("{eec69b66-a0dd-45e9-bf40-f3ce7fae1dee}", "ConduitNozzle", "", 11);
        public static readonly PortClasses Ductport = new PortClasses("{2e2ae8a4-db11-43fe-9edf-d55b7c774f06}", "DuctPort", "", 14);
        public static readonly PortClasses Ductnozzle = new PortClasses("{9ac893b1-f5b2-4997-aad7-345232363058}", "DuctNozzle", "", 15);
        public static readonly PortClasses Structuralport = new PortClasses("{52044ca2-d987-4dc9-9816-961ba1756255}", "StructuralPort", "", 16);
        public static readonly PortClasses Foundationport = new PortClasses("{9991d288-d0bc-4caa-91b1-7814fb026f48}", "FoundationPort", "", 17);
        public static readonly PortClasses Signalport = new PortClasses("{7047ddd9-c61a-4096-8ab2-86fe538e6fdc}", "SignalPort", "", 24);
        public static readonly PortClasses Branchendport = new PortClasses("{2f0277ca-f0a1-47c1-b47d-05ec51b3b6b2}", "BranchEndPort", "", 25);
        #endregion
        public PortClasses(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator PortClasses(string text)
        {
            return FindByText<PortClasses>(text);
        }
    }
}