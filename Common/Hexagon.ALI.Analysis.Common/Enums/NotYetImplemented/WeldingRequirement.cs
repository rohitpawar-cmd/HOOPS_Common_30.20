using System;

namespace Analysis2.SIO.Library.Enums
{
    public class WeldingRequirement : SIOEnum
    {
        #region VALUES
        public static readonly WeldingRequirement WeldAtEachWeldedEnd = new WeldingRequirement("{99DA2324-689E-4950-8BC1-C6C3537ABFED}", "Weld at each welded end", "", 5);
        public static readonly WeldingRequirement AdditionalWeldAtFlangeFace = new WeldingRequirement("{BD04D9E5-6A84-4F75-A2DC-379057284D45}", "Additional weld at flange face", "", 10);
        public static readonly WeldingRequirement OptionalAdditionalWeldAtFlangeFace = new WeldingRequirement("{59701EE7-B2C3-426D-BA11-C1471CDB8A19}", "Optional additional weld at flange face", "", 15);
        public static readonly WeldingRequirement WeldBasedOnWeldTypeExceptionForSleeves = new WeldingRequirement("{01807C12-FF14-45DE-AF1C-6C118131292B}", "Weld based on Weld Type Exception for Sleeves", "", 20);
        public static readonly WeldingRequirement NoWeldsRequired = new WeldingRequirement("{20F2C78E-D382-4FF5-9ED0-3F87F32258D4}", "No welds required", "", 50);
        #endregion
        public WeldingRequirement(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator WeldingRequirement(string text)
        {
            return FindByText<WeldingRequirement>(text);
        }
    }
}