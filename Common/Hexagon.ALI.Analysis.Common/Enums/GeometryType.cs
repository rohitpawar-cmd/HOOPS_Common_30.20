using System.Diagnostics.CodeAnalysis;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    [ExcludeFromCodeCoverage]
    public class GeometryType : SIOEnum
    {
        #region VALUES

        public static readonly GeometryType VariableLengthPipeStockOrTubing = new GeometryType("{06937f30-afe4-4886-b993-ba2056b0ee6b}", "Variable length pipe stock or tubing", "", 5);
        public static readonly GeometryType FixedLengthPipeStockOrTubing = new GeometryType("{77bff1ed-b6c8-4eab-98f3-049e7238b0d4}", "Fixed length pipe stock or tubing", "", 10);
        public static readonly GeometryType VariableLengthIntegralCoreAndJacketPiping = new GeometryType("{aa4d703b-b1b3-4515-a353-e4277927b215}", "Variable length integral core and jacket piping", "", 11);
        public static readonly GeometryType LinearFullSize = new GeometryType("{7d6a37af-98f7-4772-b2b7-ebcf0d4b63db}", "Linear, full-size", "", 15);
        public static readonly GeometryType LinearWithSizeChangeOrConcentricWithSizeChange = new GeometryType("{17382de8-2f52-4ab7-97d8-d605a849b61c}", "Linear, with size change or concentric, with size change", "", 16);
        public static readonly GeometryType ElbowFixedAngle = new GeometryType("{1ba52d7d-ca2b-48b7-a18a-6786ee04309f}", "Elbow, fixed angle", "", 20);
        public static readonly GeometryType ElbowFixedTrimmableAngle = new GeometryType("{0c0d4c03-155d-4aec-b781-3151e8c0ab35}", "Elbow, fixed/trimmable angle", "", 25);
        public static readonly GeometryType ElbowSideOutlet = new GeometryType("{fc49f4d1-5e77-479c-ae39-24e57325fc6a}", "Elbow, side outlet", "", 30);
        public static readonly GeometryType ElbowRadialOutlet = new GeometryType("{74ed24af-7599-4b2f-a8a0-532895e21a25}", "Elbow, radial outlet", "", 35);
        public static readonly GeometryType ElbowReducing = new GeometryType("{53623d48-f9b0-400f-a68d-eb0a5dd3b2d5}", "Elbow, reducing", "", 36);
        public static readonly GeometryType ElbowGooseneck = new GeometryType("{d570ecdb-dda7-4bae-a13d-47d5835b3af0}", "Elbow, gooseneck", "", 37);
        public static readonly GeometryType Return = new GeometryType("{ff8ed5d0-06a0-4c0d-aace-6573c05f6e48}", "Return", "", 40);
        public static readonly GeometryType ReturnBottomOutlet = new GeometryType("{40aa19a6-cf33-429d-a144-ae767d7b5b7e}", "Return, bottom outlet", "", 45);
        public static readonly GeometryType ReturnSideOutlet = new GeometryType("{1d49c95f-578c-4032-9660-2af53f5614d9}", "Return, side outlet", "", 50);
        public static readonly GeometryType PipeBendNotDefinedAsAPart = new GeometryType("{effb761b-78a5-4cf8-81b0-560987429359}", "Pipe bend (not defined as a part)", "", 55);
        public static readonly GeometryType MiteredElbowPreFabricatedPartToBePurchased = new GeometryType("{1d962b8e-0553-49a4-89c9-ec49853177bb}", "Mitered elbow (pre-fabricated part to be purchased)", "", 60);
        public static readonly GeometryType EccentricWithSizeChange = new GeometryType("{fff8ea89-f4e3-48fb-a888-98ed3f351c68}", "Eccentric, with size change", "", 65);
        public static readonly GeometryType EccentricFullSize = new GeometryType("{26c3913e-5e54-4729-ad65-83d3a0822a53}", "Eccentric, full-size", "", 66);
        public static readonly GeometryType ConcentricSizeChange = new GeometryType("{e594182b-d36d-4e5d-ad20-e8579fe7b00f}", "Concentric size change", "", 70);
        public static readonly GeometryType TeeFullSizeIncluding3WayValves = new GeometryType("{acb5b937-54c9-49bb-ac43-5fcf2a839610}", "Tee, full-size (including 3-way valves)", "", 75);
        public static readonly GeometryType TeeReducingOrIncreasingBranch = new GeometryType("{ca94435b-1bd5-4e3f-8afe-e20d6208cb76}", "Tee, reducing (or increasing) branch", "", 80);
        public static readonly GeometryType TeeEccentricReducingBranch = new GeometryType("{ab3577a3-5c32-4952-acef-4305f7188511}", "Tee, eccentric reducing branch", "", 85);
        public static readonly GeometryType TeeReducingRunAndBranch = new GeometryType("{d3431281-8310-4326-b393-a061b1c8164e}", "Tee, reducing run and branch", "", 90);
        public static readonly GeometryType TeeReducingRuns = new GeometryType("{30993697-0cf2-4403-af37-180fdf0219c3}", "Tee, reducing runs", "", 95);
        public static readonly GeometryType TeeWithOffsetFullSize = new GeometryType("{76e74aed-5c0c-462f-af59-be8a6e878a20}", "Tee with offset, full-size", "", 100);
        public static readonly GeometryType TeeWithOffsetReducingBranch = new GeometryType("{a20d58da-86fa-46cf-a07f-19ce5f671255}", "Tee with offset, reducing branch", "", 105);
        public static readonly GeometryType TeeWithOffsetReducingRunAndBranch = new GeometryType("{1cd025b7-7c5f-4447-9d41-4bff67477a09}", "Tee with offset, reducing run and branch", "", 110);
        public static readonly GeometryType TeeWithOffsetReducingRuns = new GeometryType("{374c623d-0b23-40fe-acab-0e408d3d66e9}", "Tee with offset, reducing runs", "", 115);
        public static readonly GeometryType TeeWithDoubleOffsetFullSize = new GeometryType("{2f23ea18-f3d1-4970-8ada-c48fdc845142}", "Tee with double offset, full-size", "", 120);
        public static readonly GeometryType TeeWithDoubleOffsetReducingBranch = new GeometryType("{0e223bda-e127-4e62-815a-885bf1c4cfbe}", "Tee with double offset, reducing branch", "", 125);
        public static readonly GeometryType TeeWithDoubleOffsetReducingRunAndBranch = new GeometryType("{59e33ab0-e730-4b36-8b95-66f7cd4a2610}", "Tee with double offset, reducing run and branch", "", 130);
        public static readonly GeometryType TeeWithDoubleOffsetReducingRuns = new GeometryType("{c000caae-cbc1-4cfb-bb01-adb4fd0db70a}", "Tee with double offset, reducing runs", "", 135);
        public static readonly GeometryType TeeNonSymmetrical = new GeometryType("{366b0275-58be-4c1a-90e3-f87dcc6bf658}", "Tee, non-symmetrical", "", 140);
        public static readonly GeometryType CrossFullSizeIncluding4WayValves = new GeometryType("{9df9c121-1628-4267-82dc-1748aaf84c4c}", "Cross, full-size (including 4-way valves)", "", 145);
        public static readonly GeometryType CrossReducingBranches = new GeometryType("{0ccc3c83-bda5-42b7-b214-35229bdd923e}", "Cross, reducing branches", "", 150);
        public static readonly GeometryType CrossReducingRunAndOneBranch = new GeometryType("{8fa2cfc9-1fd0-44f5-9b22-269f70691ba9}", "Cross, reducing run and one branch", "", 155);
        public static readonly GeometryType CrossReducingRunAndTwoBranches = new GeometryType("{a5163d25-beae-4a5a-8eb2-66399c70966e}", "Cross, reducing run and two branches", "", 160);
        public static readonly GeometryType LateralFullSize = new GeometryType("{6a588f0b-4e83-48b6-9355-3b4a1d6bf777}", "Lateral, full-size", "", 165);
        public static readonly GeometryType LateralReducingBranch = new GeometryType("{52d56da0-c0f8-4509-89a9-3b683b894694}", "Lateral, reducing branch", "", 170);
        public static readonly GeometryType LateralReducingRunAndBranch = new GeometryType("{02576fc6-8fe6-4951-86ad-479fe0c7125f}", "Lateral, reducing run and branch", "", 175);
        public static readonly GeometryType LateralReducingRun = new GeometryType("{a322b213-8c19-4ad3-8986-216752e0e23b}", "Lateral reducing run", "", 180);
        public static readonly GeometryType OletTypeBranchFixedAngle = new GeometryType("{9c38c77b-3450-4709-ab28-fb83f42cc6b2}", "Olet-type branch, fixed angle", "", 185);
        public static readonly GeometryType OletTypeBranchFixedTrimmableAngle = new GeometryType("{174ffdb1-a321-4751-b036-90b43c71e51c}", "Olet-type branch, fixed/trimmable angle", "", 186);
        public static readonly GeometryType LatroletTypeBranch = new GeometryType("{4b367996-53b5-447b-8c78-efe0cd679dae}", "Latrolet®-type branch", "", 190);
        public static readonly GeometryType NonRadialBranch = new GeometryType("{59f0e393-0f51-496a-8c93-e93c86bfc9c3}", "Non-radial branch", "", 195);
        public static readonly GeometryType EndoletTypeBranchFlatolet = new GeometryType("{8f42f04b-f97c-49bf-b59b-099e4f652dd6}", "Endolet-type branch (Flatolet)", "", 200);
        public static readonly GeometryType Elbolet = new GeometryType("{4670c705-c135-48f3-b9f2-26ba63fc1def}", "Elbolet®", "", 205);
        public static readonly GeometryType WyeTypeBranch = new GeometryType("{420983b8-baee-48a9-b82b-859df8a7c99f}", "Wye-type branch", "", 210);
        public static readonly GeometryType DoubleWyeTypeBranch = new GeometryType("{ee46e1d7-b614-4aa2-94b4-c3be101796f6}", "Double wye-type branch", "", 215);
        public static readonly GeometryType ClosingFittingIncludingInstrumentIndicatorsAndInstrumentTransmitters = new GeometryType("{15b6a339-1611-4e86-a163-2b6719def48d}", "Closing fitting (including instrument indicators and instrument transmitters)", "", 220);
        public static readonly GeometryType OrificeFlange = new GeometryType("{95314fa0-9563-4e97-a43f-83209bab29be}", "Orifice flange", "", 225);
        public static readonly GeometryType MultiportValve = new GeometryType("{45512113-b4b6-42ce-b287-11bd1170dec9}", "Multiport valve", "", 230);
        public static readonly GeometryType SurfaceMounted = new GeometryType("{4de275bf-1256-4836-a5ee-4070abc44f1a}", "Surface-mounted", "", 235);
        public static readonly GeometryType TandemValveHorizontalMainAtDrainAngleWithVerticalTandem = new GeometryType("{1aff1459-c30f-4471-99ad-cbab22670b23}", "Tandem valve, horizontal main at drain angle with vertical tandem", "", 240);
        public static readonly GeometryType TandemValveHorizontalMainWithVerticalTandem = new GeometryType("{8f3fd33e-443d-4921-91df-1c4881ccee63}", "Tandem valve, horizontal main with vertical tandem", "", 245);
        public static readonly GeometryType TandemValveVerticalMainWithTandemAtDrainAngle = new GeometryType("{ec5c82f3-1635-4c80-97c9-64f562f3edbb}", "Tandem valve, vertical main with tandem at drain angle", "", 250);
        public static readonly GeometryType TandemValveHorizontalMainWithTandemAtDrainAngle = new GeometryType("{7017d5ee-ed68-4c31-b586-d74f31440a51}", "Tandem valve, horizontal main with tandem at drain angle", "", 255);
        public static readonly GeometryType AngleValve = new GeometryType("{c7d07d70-2475-418f-9805-da36d1b0cc04}", "Angle valve", "", 256);
        public static readonly GeometryType AngleValveReducing = new GeometryType("{3978949a-6791-4bb0-a5a2-7bf2d553d63b}", "Angle valve, reducing", "", 257);
        public static readonly GeometryType ValveFittingAssemblyHorizontalValveWithVerticalFittingAccess = new GeometryType("{e41381ec-5c0e-45fc-8bd2-1afdeb9b5d14}", "Valve fitting/assembly, horizontal valve with vertical fitting access", "", 260);
        public static readonly GeometryType ValveFittingAssemblyHorizontalValveAtDrainAngleWithVerticalFittingAccess = new GeometryType("{72abd312-95a4-4a46-b675-ac5d867db821}", "Valve fitting/assembly, horizontal valve at drain angle with vertical fitting access", "", 265);
        public static readonly GeometryType ValveFittingAssemblyHorizontalValveAtDrainAngleWithHorizontalFittingAccess = new GeometryType("{fb5ec6f0-1b4d-47c6-b5e9-461d5b65198e}", "Valve fitting/assembly, horizontal valve at drain angle with horizontal fitting access", "", 270);
        public static readonly GeometryType ValveFittingAssemblyVerticalValveWithHorizontalFittingAccess = new GeometryType("{1788497c-224c-4b8f-87d9-c026a3e119a5}", "Valve fitting/assembly, vertical valve with horizontal fitting access", "", 275);
        public static readonly GeometryType ValveFittingAssemblyVerticalMainWithHorizontalAccessAtDrainAngleBelowMainCenterAnd450FromAssemblyCenter = new GeometryType("{940b7f6f-73e2-4749-b608-7a75a8bef125}", "Valve/fitting assembly, vertical main with horizontal access at drain angle below main center and 450 from assembly center", "", 280);
        public static readonly GeometryType ValveFittingAssemblyVerticalMainWithHorizontalAccessAtDrainAngleAboveMainCenter = new GeometryType("{c7de95f1-a45e-4914-8dd5-dea2a3fd84a7}", "Valve/fitting assembly, vertical main with horizontal access at drain angle above main center", "", 285);
        public static readonly GeometryType ValveFittingAssemblyVerticalMainWithHorizontalAccessAtDrainAngleAboveMainCenterAnd450FromAssemblyCenter = new GeometryType("{b4251d1a-66b8-44a9-8f60-32c8db60f6ae}", "Valve/fitting assembly, vertical main with horizontal access at drain angle above main center and 450 from assembly center", "", 290);
        public static readonly GeometryType CheckValveHorizontalOrientationOnly = new GeometryType("{7aacad2b-c310-4c72-94f0-80256da7d7f3}", "Check valve, horizontal orientation only", "", 295);
        public static readonly GeometryType CheckValveVerticalOrientationOnly = new GeometryType("{5c53354d-57bb-477e-8ef8-836eb97fdc51}", "Check valve, vertical orientation only", "", 300);
        public static readonly GeometryType FittingWithMultipleBranchesEGBleedRingOrDripRingTee = new GeometryType("{23e83414-b93d-4efc-b27a-65a12f04980e}", "Fitting with multiple branches, e.g. bleed ring or drip ring tee", "", 305);
        public static readonly GeometryType WallPenetrationFitting = new GeometryType("{d1028da9-30c7-448e-b8ba-944909fc2d67}", "Wall penetration fitting", "", 310);
        public static readonly GeometryType ClampOnFitting = new GeometryType("{fe39c2c2-03ff-4028-bf91-82528fa3c31c}", "Clamp-on fitting", "", 315);
        public static readonly GeometryType Generic = new GeometryType("{983ff51c-a792-4f9a-9711-5fa63351fa51}", "Generic", "", 500);
        public static readonly GeometryType OletTypeBranchDoubleOutlet = new GeometryType("{2932261f-278a-4f3a-8e10-4e37ca077bc0}", "Olet-type branch, double outlet", "", 187);
        public static readonly GeometryType LinearFullSizeWithDrainS = new GeometryType("{7e31d2b8-ffee-4cec-aa24-0f7f425fd4f3}", "Linear, full-size, with drain(s)", "", 470);
        public static readonly GeometryType EccentricWye = new GeometryType("{8d5604d8-8f88-4831-9971-1348b6782c6f}", "Eccentric wye", "", 497);
        public static readonly GeometryType ElbowSideInlet = new GeometryType("{b4fe517d-9470-4498-aed4-3e210cba086a}", "Elbow, side inlet", "", 460);
        public static readonly GeometryType ElbowBottomOutlet = new GeometryType("{88378f50-697a-4d4d-a84d-55e7054df02a}", "Elbow, bottom outlet", "", 32);
        public static readonly GeometryType TeeDoubleBranchReducingBranch = new GeometryType("{0121b47e-55b6-4013-b692-8085400e8d83}", "Tee, double branch, reducing branch", "", 365);
        public static readonly GeometryType TeeDoubleBranchFullSize = new GeometryType("{a3838a08-cc1e-4653-b21f-4dc504f6b094}", "Tee, double branch, full-size", "", 360);
        public static readonly GeometryType TeeCoreAndJacket = new GeometryType("{016fd451-b274-4e00-a831-65c071e01f11}", "Tee, core and jacket", "", 450);
        public static readonly GeometryType ClosetTee = new GeometryType("{92fbac72-f61b-41c3-a11c-1b7eb489026e}", "Closet tee", "", 370);
        public static readonly GeometryType ClosetCross = new GeometryType("{2445c98b-9211-4981-b16c-65211451b991}", "Closet cross", "", 355);
        public static readonly GeometryType FourWayReducingBranches = new GeometryType("{51bb6081-ea13-428a-911b-c12c2f16e53c}", "4-way reducing branches", "", 375);
        public static readonly GeometryType FiveWayReducingBranches = new GeometryType("{7f3ee9f7-63df-4df7-bd21-498d17dc463a}", "5-way reducing branches", "", 380);
        public static readonly GeometryType TaperedSpacer = new GeometryType("{358aec70-373e-47ef-bdd3-074861293b3b}", "Tapered spacer", "", 435);
        public static readonly GeometryType DoubleTaperedSpacer = new GeometryType("{8d3a6085-ecc1-4cf1-b18e-4e0097c6d59d}", "Double tapered spacer", "", 440);
        public static readonly GeometryType TandemValveHorizontalMainAtDrainAngleWithHorizontalTandemAtDrainAngle = new GeometryType("{7e0c0dc0-0d2b-4758-be14-42041f7e43a0}", "Tandem valve, horizontal main at drain angle with horizontal tandem at drain angle", "", 320);
        public static readonly GeometryType TandemValveVerticalMainWithTandemAtDrainAngleTandemOffsetBy45OFromMainCenterline = new GeometryType("{2eec3f34-8498-4904-8b9c-3b9453731668}", "Tandem valve, vertical main with tandem at drain angle, tandem offset by 45o from main centerline", "", 325);
        public static readonly GeometryType TandemValveDouble = new GeometryType("{aeb69e95-fa02-4827-9d69-b81b8c18930e}", "Tandem valve, double", "", 330);
        public static readonly GeometryType TandemValveBioBlockMachined = new GeometryType("{adabb893-baf4-4573-ba80-9c50b4308c24}", "Tandem valve, bio-block machined", "", 335);
        public static readonly GeometryType ThreeWayValveWithOffset = new GeometryType("{f1eee886-acb2-4f3d-a9bc-0a458c227367}", "3-way valve with offset", "", 395);
        public static readonly GeometryType ThreeWayValveWithBackOutlet = new GeometryType("{ea0fa6e7-f57e-481a-a3b9-0c10c69d52f0}", "3-way valve with back outlet", "", 400);
        public static readonly GeometryType ThreeWayValveWithUBendHorizontalRunXVerticalValve = new GeometryType("{8b8c23fa-5025-4d5a-b3b8-e0921b59f866}", "3-way valve with U-bend, horizontal run x vertical valve", "", 405);
        public static readonly GeometryType ThreeWayValveWithUBendVerticalRunXVerticalValve = new GeometryType("{076fcdc9-2aac-4e4a-9dbc-562f3ea21cba}", "3-way valve with U-bend, vertical run x vertical valve", "", 410);
        public static readonly GeometryType ThreeWayValveWithUBendVerticalRunXHorizontalValve = new GeometryType("{c7c6f504-8d96-4a7a-896e-6a6c3864b092}", "3-way valve with U-bend, vertical run x horizontal valve", "", 415);
        public static readonly GeometryType TwoWayJacketedValve = new GeometryType("{8eec756d-1cc8-46e4-bc06-ec7231a4df37}", "2-way jacketed valve", "", 491);
        public static readonly GeometryType ThreeWayJacketedValve = new GeometryType("{942498e1-6045-4363-abd3-905ff16793a2}", "3-way jacketed valve", "", 492);
        public static readonly GeometryType InstrumentManifold2Valves = new GeometryType("{09c5314a-a4af-4d42-a047-f71ed66740af}", "Instrument manifold, 2 valves", "", 420);
        public static readonly GeometryType InstrumentManifold3Valves = new GeometryType("{5fb1d10f-3336-44db-b09b-d7d6447af8c2}", "Instrument manifold, 3 valves", "", 425);
        public static readonly GeometryType InstrumentManifold5Valves = new GeometryType("{96d7a979-8f2f-4229-847d-d1c7c8a61c74}", "Instrument manifold, 5 valves", "", 430);
        public static readonly GeometryType CheckValveHorizontalOrVerticalOrientationOnly = new GeometryType("{b5370cde-59a1-4076-8a92-8eff820d009c}", "Check valve, horizontal or vertical orientation only", "", 385);
        public static readonly GeometryType OtherValve = new GeometryType("{fb7e0465-b47a-48b7-a17f-dd73d7a5679c}", "Other valve", "", 390);
        public static readonly GeometryType SanitaryPTrap = new GeometryType("{3734def6-9987-4baf-97ba-ec0dfe768a65}", "Sanitary P-trap", "", 340);
        public static readonly GeometryType SanitaryRunningTrap = new GeometryType("{c413b31f-c179-41f1-b801-7a04fcb59716}", "Sanitary running trap", "", 345);
        public static readonly GeometryType SanitaryCombinationTrapAndTee = new GeometryType("{0de806f1-aa01-4bd3-bbbe-5ec67261c2f6}", "Sanitary combination trap and tee", "", 350);
        public static readonly GeometryType InstrumentTemperatureTransmitter = new GeometryType("{83d6a3fb-b0fb-4a61-b6d4-e5dc11256613}", "Instrument temperature transmitter", "", 484);
        public static readonly GeometryType UBoltBracket = new GeometryType("{6876a6f1-978c-4013-a6c5-bcd6ba9f67cb}", "U-bolt bracket", "", 486);
        public static readonly GeometryType FireHydrant = new GeometryType("{cb034a2e-e02e-4a22-85b0-8baeb77fcfc7}", "Fire hydrant", "", 489);
        public static readonly GeometryType FireHydrantMonitorStyle = new GeometryType("{c772bf9a-ea90-4e72-b707-196c66724699}", "Fire hydrant, monitor style", "", 487);
        public static readonly GeometryType FireMonitor = new GeometryType("{79e91bce-f194-4cd4-bc19-b0c329d4593d}", "Fire monitor", "", 485);
        public static readonly GeometryType FireHydrantMount = new GeometryType("{a67d75c3-8b2f-447c-b71b-809ce1b500c7}", "Fire hydrant mount", "", 488);
        public static readonly GeometryType HeatJacket = new GeometryType("{8b2aebf9-90d8-4e4a-a622-18761ae18140}", "Heat jacket", "", 480);
        public static readonly GeometryType SleevedPenetrationFitting = new GeometryType("{c04daa61-bf0f-4a34-aae5-2580ffc5688f}", "Sleeved penetration fitting", "", 493);
        public static readonly GeometryType SleevedPenetrationFittingWithFlange = new GeometryType("{7e65f4cf-7ca1-4daa-adb7-2be6af474fdf}", "Sleeved penetration fitting with flange", "", 494);
        public static readonly GeometryType SteamTrapAngleWithOffset = new GeometryType("{bb7329a7-2325-4647-9813-36790daba19c}", "Steam trap, angle with offset", "", 495);
        public static readonly GeometryType NonWettedInstrument = new GeometryType("{3ea1ecd0-8fad-432e-8b15-7188dd85c87c}", "Non-wetted instrument", "", 496);
        public static readonly GeometryType SteamTrapAngle = new GeometryType("{c2a45abb-75d9-41e7-a6f1-f83bc6dc38f0}", "Steam trap, angle", "", 499);

        #endregion VALUES

        public GeometryType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
            dict.TryAdd(uid, text);
        }

    }
}