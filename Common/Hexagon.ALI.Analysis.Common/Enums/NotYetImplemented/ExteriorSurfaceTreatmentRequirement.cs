namespace Analysis2.SIO.Library.Enums
{
    public class ExteriorSurfaceTreatmentRequirement : SIOEnum
    {
        #region VALUES
        public static readonly ExteriorSurfaceTreatmentRequirement Undefined = new ExteriorSurfaceTreatmentRequirement("{26CA2B1B-29FD-4C84-A8DB-CF373A7FAE3C}", "Undefined", "", 1);
        public static readonly ExteriorSurfaceTreatmentRequirement None = new ExteriorSurfaceTreatmentRequirement("{312A20FF-058A-433E-88F4-FA292C279E58}", "None", "", 2);
        public static readonly ExteriorSurfaceTreatmentRequirement PassivationDescaling = new ExteriorSurfaceTreatmentRequirement("{669F9F86-2B6C-4FB2-8AC0-5CA2E15DB960}", "Passivation/Descaling", "", 11);
        public static readonly ExteriorSurfaceTreatmentRequirement RustAndOrCorrosionInhibition = new ExteriorSurfaceTreatmentRequirement("{C16A30B3-B42A-4528-A751-62F2DC528988}", "Rust inhibition", "", 16);
        #endregion
        public ExteriorSurfaceTreatmentRequirement(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator ExteriorSurfaceTreatmentRequirement(string text)
        {
            return FindByText<ExteriorSurfaceTreatmentRequirement>(text);
        }
    }
}