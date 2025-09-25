namespace Analysis2.SIO.Library.Enums
{
    public class InteriorSurfaceTreatmentRequirement : SIOEnum
    {
        #region VALUES
        public static readonly InteriorSurfaceTreatmentRequirement Undefined = new InteriorSurfaceTreatmentRequirement("{5D2C6E07-A94F-4743-BEBA-EB157460653E}", "Undefined", "", 1);
        public static readonly InteriorSurfaceTreatmentRequirement None = new InteriorSurfaceTreatmentRequirement("{B09DCECD-C6E6-4DAA-A54B-30AA49DD883B}", "None", "", 2);
        public static readonly InteriorSurfaceTreatmentRequirement PassivationDescaling = new InteriorSurfaceTreatmentRequirement("{B432F755-6755-4562-BE79-109156D6FA4A}", "Passivation/Descaling", "", 11);
        public static readonly InteriorSurfaceTreatmentRequirement RustAndOrCorrosionInhibition = new InteriorSurfaceTreatmentRequirement("{980579C0-3140-407F-901E-DFA7B8C0E5EA}", "Rust and/or corrosion inhibition", "", 16);
        #endregion
        public InteriorSurfaceTreatmentRequirement(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator InteriorSurfaceTreatmentRequirement(string text)
        {
            return FindByText<InteriorSurfaceTreatmentRequirement>(text);
        }
    }
}