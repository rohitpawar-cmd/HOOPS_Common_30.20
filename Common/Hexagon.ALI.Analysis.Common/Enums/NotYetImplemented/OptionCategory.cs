namespace Analysis2.SIO.Library.Enums
{
    public class OptionCategory : SIOEnum
    {
        #region VALUES
        public static readonly OptionCategory Default = new OptionCategory("{dd3ef8e3-e4e3-43f5-be51-4c13511469e7}", "Default", "", 1);
        public static readonly OptionCategory TypeOptions = new OptionCategory("{642c6eca-23a0-4fcb-9526-8c11cfa06665}", "Type Options", "", 5);
        public static readonly OptionCategory ValveTypeOptions = new OptionCategory("{00a7b2f4-d663-46ee-909f-13f183920f27}", "Valve type options", "", 10);
        public static readonly OptionCategory ValveOperatorOptions = new OptionCategory("{97aae9e7-d4a4-4b09-8993-2ecc0100bedc}", "Valve Operator Options", "", 15);
        public static readonly OptionCategory BendRadiusOptions = new OptionCategory("{598e084e-8170-4e10-bf7d-e6ebea6d5fe1}", "Bend Radius Options", "", 20);
        public static readonly OptionCategory HeadTypeOptions = new OptionCategory("{dd3013dc-b8d9-4312-b433-9c4fc4a1b31f}", "Head Type Options", "", 25);
        public static readonly OptionCategory MiterOptions = new OptionCategory("{846ab456-c9db-4386-b6d3-8a554febbdfa}", "Miter Options", "", 30);
        public static readonly OptionCategory MiscellaneousOptions = new OptionCategory("{6ddb1d4e-2c42-459c-90cd-8743fe8b0bde}", "Miscellaneous Options", "", 35);
        public static readonly OptionCategory FlangeTypeOptions = new OptionCategory("{54f17b80-49be-4499-8c49-c2c7f5701e7b}", "Flange Type Options", "", 40);
        public static readonly OptionCategory BoltedEndOptions = new OptionCategory("{b58fd983-2805-4d98-be31-47d66149c912}", "Bolted End Options", "", 45);
        public static readonly OptionCategory MaleEndOptions = new OptionCategory("{35c187fe-554e-4dba-9546-4dcf01e8a9fa}", "Male End Options", "", 50);
        public static readonly OptionCategory FemaleEndOptions = new OptionCategory("{ad970a6c-26f3-40c6-943c-b68ecccb63f3}", "Female End Options", "", 55);
        public static readonly OptionCategory MixedEndOptions = new OptionCategory("{e643039c-92f6-4f06-92fc-e123e35d0a19}", "Mixed End Options", "", 60);
        public static readonly OptionCategory NippleOptions = new OptionCategory("{f0227684-d3ad-4b02-b99c-4ff496712617}", "Nipple Options", "", 65);
        public static readonly OptionCategory PressureRatingOptions = new OptionCategory("{96de6970-a10a-41bd-bc2c-9a0f2d316ab2}", "Pressure Rating options", "", 70);
        public static readonly OptionCategory ScheduleAndThicknessOptions = new OptionCategory("{339a50f0-b612-46b7-bdf0-b19c7e919257}", "Schedule and thickness options", "", 75);
        public static readonly OptionCategory FlangeSurfaceFinishOptions = new OptionCategory("{d30b699d-1b0c-440b-a63a-1ff17a291c7a}", "Flange surface finish options", "", 80);
        public static readonly OptionCategory CodeOptions = new OptionCategory("{2479bb91-8e57-4aa7-a3fc-13b49f8f418b}", "Code Options", "", 90);
        public static readonly OptionCategory ManufacturerOptions = new OptionCategory("{10a318ee-27a0-40b8-bbfe-78e3a8e67ac0}", "Manufacturer Options", "", 95);
        public static readonly OptionCategory MechanicalEndOptions = new OptionCategory("{6811e207-4b63-49e2-a860-6e185f33c0c1}", "Mechanical End Options", "", 100);
        public static readonly OptionCategory TaperedSpacerOptions = new OptionCategory("{89e1ffcc-9721-44e6-838e-b4cb6d8216b5}", "Tapered Spacer options", "", 105);
        public static readonly OptionCategory PurchaseLengthOptions = new OptionCategory("{a01fe8f2-5784-4174-833d-5cb67095ede7}", "Purchase Length options", "", 1740);
        public static readonly OptionCategory ManufacturingMethodOptions = new OptionCategory("{3e47d0e6-84a7-42cb-855d-31421811e546}", "Manufacturing method options", "", 85);
        public static readonly OptionCategory MaterialsGradeOptions = new OptionCategory("{42796933-0daa-4818-aeab-47feafc11008}", "Materials Grade options", "", 110);
        public static readonly OptionCategory LinedFlangedSpoolOptions = new OptionCategory("{131a3120-baf7-4699-b91a-b4e9247c3211}", "Lined, Flanged Spool options", "", 26);
        public static readonly OptionCategory SolidAndLinedSpacerOptions = new OptionCategory("{f5803435-ea9e-4796-a6e6-68d4b8c5819e}", "Solid and Lined Spacer options", "", 101);
        public static readonly OptionCategory HeavierScheduleHeaderPipeAtBranchOptions = new OptionCategory("{4107a037-1be7-4894-b064-f8d9cfa4ee64}", "Heavier Schedule Header Pipe at Branch options", "", 4281);
        #endregion
        public OptionCategory(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator OptionCategory(string text)
        {
            return FindByText<OptionCategory>(text);
        }
    }
}