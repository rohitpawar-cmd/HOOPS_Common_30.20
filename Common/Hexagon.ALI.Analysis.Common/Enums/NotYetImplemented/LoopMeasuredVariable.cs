namespace Analysis2.SIO.Library.Enums
{
    public class LoopMeasuredVariable : SIOEnum
    {
        #region VALUES
        public static readonly LoopMeasuredVariable A = new LoopMeasuredVariable("{3efedc2b-16b4-4253-808d-d354cdb95f68}", "A", "Analysis", 0);
        public static readonly LoopMeasuredVariable B = new LoopMeasuredVariable("{0dfc3652-71ba-49a3-8b9b-f698d82967ba}", "B", "Burner Flame", 1);
        public static readonly LoopMeasuredVariable C = new LoopMeasuredVariable("{d2e5e20b-3f24-4c0a-9c64-42fb52eddeba}", "C", "Conductivity", 2);
        public static readonly LoopMeasuredVariable D = new LoopMeasuredVariable("{f77e1e4d-5bd3-47bf-8e08-adbd892d9df0}", "D", "Density", 3);
        public static readonly LoopMeasuredVariable E = new LoopMeasuredVariable("{65621cfc-2ea2-4839-9cb4-13100b8a6c96}", "E", "Voltage (EMF)", 5);
        public static readonly LoopMeasuredVariable H = new LoopMeasuredVariable("{91f7eef5-070a-4141-b89f-76dcd5a3f746}", "H", "Hand-operated", 7);
        public static readonly LoopMeasuredVariable I = new LoopMeasuredVariable("{e38efff7-eece-4a5e-923d-ccd19594f976}", "I", "Electric Current", 8);
        public static readonly LoopMeasuredVariable J = new LoopMeasuredVariable("{e038c5e8-23ae-4b2c-a974-cb697055af71}", "J", "Power", 9);
        public static readonly LoopMeasuredVariable K = new LoopMeasuredVariable("{66675253-a860-4bab-aab0-4d6e00943249}", "K", "Time & Time Schedule", 10);
        public static readonly LoopMeasuredVariable L = new LoopMeasuredVariable("{612bf454-75bf-4617-8f3f-cadbc2231157}", "L", "Level", 11);
        public static readonly LoopMeasuredVariable M = new LoopMeasuredVariable("{a26d70ff-2663-483b-a924-0f8030883d73}", "M", "Moisture / Humidity", 12);
        public static readonly LoopMeasuredVariable N = new LoopMeasuredVariable("{1e4de193-bb13-40e9-a8b3-46859ceecde6}", "N", "", 13);
        public static readonly LoopMeasuredVariable O = new LoopMeasuredVariable("{159fc22c-921a-4e81-8b31-11a20ba77fd2}", "O", "", 14);
        public static readonly LoopMeasuredVariable P = new LoopMeasuredVariable("{50eb19e1-4826-45c4-8e1d-73a2b33b85d3}", "P", "Pressure / Vacuum", 15);
        public static readonly LoopMeasuredVariable Q = new LoopMeasuredVariable("{83601f97-b1da-4302-869b-a3808aba2d5a}", "Q", "Quantity / Event", 17);
        public static readonly LoopMeasuredVariable R = new LoopMeasuredVariable("{4230b8b5-55e4-40b3-80ca-be68c6e8c44f}", "R", "Radioactivity", 18);
        public static readonly LoopMeasuredVariable S = new LoopMeasuredVariable("{cd4a146b-bf93-4d48-81c5-7006321fc209}", "S", "Speed / Frequency", 19);
        public static readonly LoopMeasuredVariable T = new LoopMeasuredVariable("{486ac16b-1365-4cef-adfb-002a68c31566}", "T", "Temperature", 20);
        public static readonly LoopMeasuredVariable U = new LoopMeasuredVariable("{17f4e1a9-d478-4c03-8c9f-9110a767e75b}", "U", "Multivariable", 21);
        public static readonly LoopMeasuredVariable V = new LoopMeasuredVariable("{274bdb7e-34c4-4b4e-91dd-e97c69f86b70}", "V", "Viscosity", 22);
        public static readonly LoopMeasuredVariable W = new LoopMeasuredVariable("{bd4728c6-022a-4d06-83bb-83066ab68362}", "W", "Weight / Force", 23);
        public static readonly LoopMeasuredVariable X = new LoopMeasuredVariable("{99288d76-ee48-4a4b-a5fd-a419339e8ba4}", "X", "Unclassified", 24);
        public static readonly LoopMeasuredVariable Y = new LoopMeasuredVariable("{27225ce8-de14-4ace-baea-2bf488f35205}", "Y", "", 25);
        public static readonly LoopMeasuredVariable Z = new LoopMeasuredVariable("{475626d9-27f1-4d7e-a3e3-9d4530c6031c}", "Z", "Position", 26);
        public static readonly LoopMeasuredVariable Dp = new LoopMeasuredVariable("{7dfce792-13c4-4769-8a52-ab6329c7edc9}", "DP", "Pressure", 4);
        public static readonly LoopMeasuredVariable Pd = new LoopMeasuredVariable("{3ada852f-4091-4a96-8502-2fe7a3f08184}", "PD", "Pressure Differential", 16);
        public static readonly LoopMeasuredVariable F = new LoopMeasuredVariable("{243ab030-8f25-450f-a90c-fb952c38a522}", "F", "Flow", 6);
        #endregion
        public LoopMeasuredVariable(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator LoopMeasuredVariable(string text)
        {
            return FindByText<LoopMeasuredVariable>(text);
        }
    }
}