using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class AnalysisRestraintType : SIOEnum
    {

        public static readonly AnalysisRestraintType ANC = new AnalysisRestraintType("c6b2538f-bb27-4fa0-a582-82862f5ce1e7", "ANC", "Anchor", 1);
        public static readonly AnalysisRestraintType X = new AnalysisRestraintType("026ac9cd-f2ad-4417-b83f-c202a30ed948", "X", "Translational Double Acting", 2);
        public static readonly AnalysisRestraintType Y = new AnalysisRestraintType("552ff0ee-6c96-441a-9c60-a61d82faec1d", "Y", "Translational Double Acting", 3);
        public static readonly AnalysisRestraintType Z = new AnalysisRestraintType("00de7999-3e1c-47db-b327-ba6909462671", "Z", "Translational Double Acting", 4);
        public static readonly AnalysisRestraintType RX = new AnalysisRestraintType("061ebff1-fcc9-4818-aa2c-9c2564e65f85", "RX", "Rotational Double Acting", 5);
        public static readonly AnalysisRestraintType RY = new AnalysisRestraintType("89eb2004-24f1-4076-95e4-9c553c55089b", "RY", "Rotational Double Acting", 6);
        public static readonly AnalysisRestraintType RZ = new AnalysisRestraintType("fafd5ce7-5567-4d16-9927-df74e57d6e3e", "RZ", "Rotational Double Acting", 7);
        public static readonly AnalysisRestraintType GUIDE = new AnalysisRestraintType("c9d26d8e-7157-4b6f-8f90-41b3cf621d67", "GUIDE", "Guide, Double Acting", 8);
        public static readonly AnalysisRestraintType LIM = new AnalysisRestraintType("c048c6a6-6a1b-4061-a2ea-7eeefd4246ac", "LIM", "Double Acting Limit Stop", 9);
        public static readonly AnalysisRestraintType XSNB = new AnalysisRestraintType("4ef87d69-5a0c-4290-aef3-eca3c3cc4d73", "XSNB", "Translational Double Acting Snubber", 10);
        public static readonly AnalysisRestraintType YSNB = new AnalysisRestraintType("c9eca829-644b-4645-94db-b9c5f4f55cd3", "YSNB", "Translational Double Acting Snubber", 11);
        public static readonly AnalysisRestraintType ZSNB = new AnalysisRestraintType("8fb37d76-8031-4cc0-a095-eda198248585", "ZSNB", "Translational Double Acting Snubber", 12);
        public static readonly AnalysisRestraintType PX = new AnalysisRestraintType("7069a0a3-7e8a-4ac1-8628-72348627a0a5", "+X", "Translational Directional", 13);
        public static readonly AnalysisRestraintType PY = new AnalysisRestraintType("e3eb479e-0f85-40c5-8db0-11bdad33a0ae", "+Y", "Translational Directional", 14);
        public static readonly AnalysisRestraintType PZ = new AnalysisRestraintType("061ebff1-fcc9-4818-aa2c-9c2564e65f85", "+Z", "Translational Directional", 15);
        public static readonly AnalysisRestraintType NX = new AnalysisRestraintType("7bf738ea-4fac-4fbe-944f-561013107cc9", "-X", "Translational Directional", 16);
        public static readonly AnalysisRestraintType NY = new AnalysisRestraintType("2f3bd729-9f04-4156-977a-9142d6e1c8b7", "-Y", "Translational Directional", 17);
        public static readonly AnalysisRestraintType NZ = new AnalysisRestraintType("4c3a4f6a-3ec5-46e6-8d22-acdcb8ed6232", "-Z", "Translational Directional", 18);
        public static readonly AnalysisRestraintType PRX = new AnalysisRestraintType("031c74a5-b217-409f-a38c-5eae62109d7e", "+RX", "Rotational Directional", 19);
        public static readonly AnalysisRestraintType PRY = new AnalysisRestraintType("fb4e1eae-3872-48cd-ab44-06277941605e", "+RY", "Rotational Directional", 20);
        public static readonly AnalysisRestraintType PRZ = new AnalysisRestraintType("5c53045e-1006-4206-b797-149c15d78920", "+RZ", "Rotational Directional", 21);
        public static readonly AnalysisRestraintType NRX = new AnalysisRestraintType("23968038-0f21-41bd-b5dd-a60bd522aac3", "-RX", "Rotational Directional", 22);
        public static readonly AnalysisRestraintType NRY = new AnalysisRestraintType("a2584f14-abbd-4fee-aaa2-5432e47cc10a", "-RY", "Rotational Directional", 23);
        public static readonly AnalysisRestraintType NRZ = new AnalysisRestraintType("8c35096b-7249-43c8-8d2f-05e6e6b9b876", "-RZ", "Rotational Directional", 24);
        public static readonly AnalysisRestraintType PLIM = new AnalysisRestraintType("0f0c0e0a-7476-4b59-8860-89b64f72d96d", "+LIM", "Directional Limit Stop", 25);
        public static readonly AnalysisRestraintType NLIM = new AnalysisRestraintType("5f7eb3a8-b2dc-48e5-bf59-d4e20950bf39", "-LIM", "Directional Limit Stop", 26);
        public static readonly AnalysisRestraintType XROD = new AnalysisRestraintType("6fbca760-0511-4e40-8726-4c7ef142e5cc", "XROD", "Large Rotation Rod", 27);
        public static readonly AnalysisRestraintType YROD = new AnalysisRestraintType("23a43a81-c38a-4bc6-92ee-bf5f1428bc93", "YROD", "Large Rotation Rod", 28);
        public static readonly AnalysisRestraintType ZROD = new AnalysisRestraintType("0f0c0e0a-7476-4b59-8860-89b64f72d96d", "ZROD", "Large Rotation Rod", 29);
        public static readonly AnalysisRestraintType PXROD = new AnalysisRestraintType("6498df0a-0278-46bf-be03-f71d95aba22a", "+XROD", "Large Rotation Rod", 30);
        public static readonly AnalysisRestraintType PYROD = new AnalysisRestraintType("60b6cc2e-6470-4fa7-82b0-84ce174c7c9d", "+YROD", "Large Rotation Rod", 31);
        public static readonly AnalysisRestraintType PZROD = new AnalysisRestraintType("71ea9476-6947-4325-8b68-62a8ff41f997", "+ZROD", "Large Rotation Rod", 32);
        public static readonly AnalysisRestraintType NXROD = new AnalysisRestraintType("e8c6e1ea-59fb-4928-bf00-0263bee4c626", "-XROD", "Large Directional Rotation Rod", 33);
        public static readonly AnalysisRestraintType NYROD = new AnalysisRestraintType("84765adf-905d-4e60-823e-89eaf3daf045", "-YROD", "Large Directional Rotation Rod", 34);
        public static readonly AnalysisRestraintType NZROD = new AnalysisRestraintType("ced30c20-2a5f-44ae-82c0-6d30c75f6289", "-ZROD", "Large Directional Rotation Rod", 35);
        public static readonly AnalysisRestraintType X2 = new AnalysisRestraintType("a059fd9d-e0dc-434b-8e65-0463adcca3d7", "X2", "Translational Double Acting Bilinear", 36);
        public static readonly AnalysisRestraintType Y2 = new AnalysisRestraintType("7b8eef21-4731-478a-b9e5-3840e7f16a7d", "Y2", "Translational Double Acting Bilinear", 37);
        public static readonly AnalysisRestraintType Z2 = new AnalysisRestraintType("5e0e4e21-b3c6-4b59-a373-15ce62862a19", "Z2", "Translational Double Acting Bilinear", 38);
        public static readonly AnalysisRestraintType RX2 = new AnalysisRestraintType("e91918a6-36c9-41d8-aff1-bff50a3f8026", "RX2", "Rotational Double Acting Bilinear", 39);
        public static readonly AnalysisRestraintType RY2 = new AnalysisRestraintType("c4bc6359-c91f-4c2c-a4e5-199689aad473", "RY2", "Rotational Double Acting Bilinear", 40);
        public static readonly AnalysisRestraintType RZ2 = new AnalysisRestraintType("16e9b1f4-a207-45a2-9751-ca25aa38bcab", "RZ2", "Rotational Double Acting Bilinear", 41);
        public static readonly AnalysisRestraintType PX2 = new AnalysisRestraintType("7fab543d-257f-4c86-aeb2-652b5138e61c", "+X2", "Translational Directional Bilinear", 42);
        public static readonly AnalysisRestraintType PY2 = new AnalysisRestraintType("0f5f6ea7-7667-4eee-aac7-6c61c48c3b78", "+Y2", "Translational Directional Bilinear", 43);
        public static readonly AnalysisRestraintType PZ2 = new AnalysisRestraintType("53723e56-24ac-4f01-8df6-2ced2a7cf2c4", "+Z2", "Translational Directional Bilinear", 44);
        public static readonly AnalysisRestraintType NX2 = new AnalysisRestraintType("8d2574a2-73a0-413c-91b7-c9d818dd0d75", "-X2", "Translational Directional Bilinear", 45);
        public static readonly AnalysisRestraintType NY2 = new AnalysisRestraintType("08fc08cf-8eb0-4c1b-a7a2-0a96ef0ae35a", "-Y2", "Translational Directional Bilinear", 46);
        public static readonly AnalysisRestraintType NZ2 = new AnalysisRestraintType("51b566d8-fa23-4932-8361-c92fad7df3c5", "-Z2", "Translational Directional Bilinear", 47);
        public static readonly AnalysisRestraintType PRX2 = new AnalysisRestraintType("de3d3252-f447-463e-a29d-c93aa65af775", "+RX2", "Rotational Double Acting Bilinear", 48);
        public static readonly AnalysisRestraintType PRY2 = new AnalysisRestraintType("34737605-d5fd-46f6-8c12-955f2386d4f1", "+RY2", "Rotational Double Acting Bilinear", 49);
        public static readonly AnalysisRestraintType PRZ2 = new AnalysisRestraintType("e9554ce9-b7dd-488e-b5ef-1079ef5eae4d", "+RZ2", "Rotational Double Acting Bilinear", 50);
        public static readonly AnalysisRestraintType NRX2 = new AnalysisRestraintType("295bc133-0afd-485e-8f5b-dd3ddfd71359", "-RX2", "Rotational Double Acting Bilinear", 51);
        public static readonly AnalysisRestraintType NRY2 = new AnalysisRestraintType("4161dd04-a160-48aa-b68d-54745983c855", "-RY2", "Rotational Double Acting Bilinear", 52);
        public static readonly AnalysisRestraintType NRZ2 = new AnalysisRestraintType("52fd3ae4-a018-4009-be08-9de1efa46c03", "-RZ2", "Rotational Double Acting Bilinear", 53);
        public static readonly AnalysisRestraintType XSPR = new AnalysisRestraintType("7ff59a3f-d39b-4ab2-8820-e939e6304450", "XSPR", "Bottom Out Spring", 54);
        public static readonly AnalysisRestraintType YSPR = new AnalysisRestraintType("98498b2a-5450-4676-b485-63b56a82ebf1", "YSPR", "Bottom Out Spring", 55);
        public static readonly AnalysisRestraintType ZSPR = new AnalysisRestraintType("2ab92155-ea5b-4e94-bdcf-aab52edada6f", "ZSPR", "Bottom Out Spring", 56);
        public static readonly AnalysisRestraintType PXSNB = new AnalysisRestraintType("6d7eae30-f755-4241-8821-fbc90f451f10", "+XSNB", "Directional Snubber", 57);
        public static readonly AnalysisRestraintType PYSNB = new AnalysisRestraintType("12f96697-cbb8-485d-a7a2-3d3975678b45", "+YSNB", "Directional Snubber", 58);
        public static readonly AnalysisRestraintType PZSNB = new AnalysisRestraintType("fd17a351-a3ac-456c-bc6e-455e2df3ef5f", "+ZSNB", "Directional Snubber", 59);
        public static readonly AnalysisRestraintType NXSNB = new AnalysisRestraintType("859e6f19-aa83-4ddb-b764-2cdc77ab0a5f", "-XSNB", "Directional Snubber", 60);
        public static readonly AnalysisRestraintType NYSNB = new AnalysisRestraintType("306fa127-21c5-43ff-897a-d74c8d117e42", "-YSNB", "Directional Snubber", 61);
        public static readonly AnalysisRestraintType NZSNB = new AnalysisRestraintType("c4cb2328-33de-469d-b189-a41dde409bc5", "-ZSNB", "Directional Snubber", 62);

        public AnalysisRestraintType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }
    }
}
