namespace Analysis2.SIO.Library.Enums
{
    public class PipePartTypes : SIOEnum
    {
        #region VALUES
        public static readonly PipePartTypes Valve = new PipePartTypes("{057c43b8-93f7-4016-bd46-87b641ea0560}", "Valve", "", 5);
        public static readonly PipePartTypes InlineFitting = new PipePartTypes("{1bb8e08c-bfe0-4ecf-bbd1-86f66fbbccbc}", "Inline fitting", "", 10);
        public static readonly PipePartTypes DirectionChangeFitting = new PipePartTypes("{d881c239-f05d-48dc-a8e3-af306eeeebbd}", "Direction change fitting", "", 15);
        public static readonly PipePartTypes BranchFitting = new PipePartTypes("{23c0b766-d6e9-49bb-990f-daa1355bcfad}", "Branch fitting", "", 20);
        public static readonly PipePartTypes EndFitting = new PipePartTypes("{cdcd13cc-99f6-4a96-858c-a91fa8687811}", "End fitting", "", 25);
        public static readonly PipePartTypes StraightSection = new PipePartTypes("{7c46b533-d9eb-4b90-8bfe-c3e3e2ea0771}", "Straight section", "", 40);
        public static readonly PipePartTypes FireAndSafety = new PipePartTypes("{385baa75-200a-4e4e-b351-61cc4da75fd2}", "Fire and safety", "", 45);
        public static readonly PipePartTypes Accessory = new PipePartTypes("{9070c877-f6b0-4a16-ac70-991fd1828da1}", "Accessory", "", 50);
        public static readonly PipePartTypes OtherSpecialtyComponent = new PipePartTypes("{1910c7c0-1789-4337-9c86-2d92692973e2}", "Other specialty component", "", 100);
        public static readonly PipePartTypes SurfaceMountedFitting = new PipePartTypes("{0400f7d8-4452-4b5c-a645-5ab92d841c08}", "Surface-mounted fitting", "", 101);
        public static readonly PipePartTypes OfflineInstrument = new PipePartTypes("{08312f1d-af8b-4b1f-9095-477a275684c6}", "Offline instrument", "", 150);
        public static readonly PipePartTypes Conduit = new PipePartTypes("{2abac13d-1480-4595-95e2-357a397c0cae}", "Conduit", "", 300);
        public static readonly PipePartTypes ConduitInlineFitting = new PipePartTypes("{e9106dac-8fd2-4d4a-adc8-cbc7e478f79b}", "Conduit inline fitting", "", 305);
        public static readonly PipePartTypes ConduitDirectionChangeFitting = new PipePartTypes("{d1580b30-9775-4804-b5b9-ab27946cf3a4}", "Conduit direction change fitting", "", 310);
        public static readonly PipePartTypes ConduitBranch = new PipePartTypes("{f042cb47-7421-49fc-9514-158649c33eed}", "Conduit branch", "", 315);
        public static readonly PipePartTypes ConduitEndFitting = new PipePartTypes("{ad38ffd7-19d6-49b7-96e5-a90c30e6ccda}", "Conduit end fitting", "", 320);
        public static readonly PipePartTypes ConduitPullBox = new PipePartTypes("{46ed43cc-a107-4007-a6ca-776637a1cddc}", "Conduit pull box", "", 325);
        public static readonly PipePartTypes ConduitJunctionBox = new PipePartTypes("{75bd5701-5a0d-4b25-8db6-3784400d8a4f}", "Conduit junction box", "", 335);
        public static readonly PipePartTypes OtherInLineConduitFitting = new PipePartTypes("{d5b2c317-51d7-4991-bf5a-30c55779d7bf}", "Other in-line conduit fitting", "", 307);
        #endregion
        public PipePartTypes(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator PipePartTypes(string text)
        {
            return FindByText<PipePartTypes>(text);
        }
    }
}