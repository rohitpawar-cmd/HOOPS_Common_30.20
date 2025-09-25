namespace Analysis2.SIO.Library.Enums
{
    public class CoatingRequirement : SIOEnum
    {
        #region VALUES
        public static readonly CoatingRequirement Undefined = new CoatingRequirement("{7731B640-B7B2-4FA0-8DA1-7654BA7F2102}", "Undefined", "", 1);
        public static readonly CoatingRequirement None = new CoatingRequirement("{576AF4BE-9E44-11D6-BDA6-00104BCC2B69}", "None", "", 2);
        public static readonly CoatingRequirement MetallicCoating = new CoatingRequirement("{576AF4C4-9E44-11D6-BDA6-00104BCC2B69}", "Metallic coating", "", 3);
        public static readonly CoatingRequirement NonMetallicCoating = new CoatingRequirement("{576AF4CA-9E44-11D6-BDA6-00104BCC2B69}", "Non-metallic coating", "", 5);
        public static readonly CoatingRequirement CoatingForBolting = new CoatingRequirement("{04116D83-D592-442A-A3BE-B18E03B72B84}", "Coating for bolting", "", 15);
        public static readonly CoatingRequirement Painting = new CoatingRequirement("{576AF4D0-9E44-11D6-BDA6-00104BCC2B69}", "Painting", "", 10);
        #endregion
        public CoatingRequirement(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator CoatingRequirement(string text)
        {
            return FindByText<CoatingRequirement>(text);
        }
    }
}