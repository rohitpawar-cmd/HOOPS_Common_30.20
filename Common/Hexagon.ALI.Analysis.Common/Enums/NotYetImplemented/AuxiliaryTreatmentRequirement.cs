namespace Analysis2.SIO.Library.Enums
{
    public class AuxiliaryTreatmentRequirement : SIOEnum
    {
        #region VALUES
        public static readonly AuxiliaryTreatmentRequirement Undefined = new AuxiliaryTreatmentRequirement("{D29CB6E0-206D-40D5-8498-9B97F2B55BB5}", "Undefined", "", 1);
        public static readonly AuxiliaryTreatmentRequirement None = new AuxiliaryTreatmentRequirement("{86EDCFCE-E4EC-4C2B-9B95-48827830E784}", "None", "", 5);
        public static readonly AuxiliaryTreatmentRequirement HeatTreatment = new AuxiliaryTreatmentRequirement("{9E031A48-671B-45D4-95DA-3C3A8E821CB0}", "Heat treatment", "", 10);
        #endregion
        public AuxiliaryTreatmentRequirement(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator AuxiliaryTreatmentRequirement(string text)
        {
            return FindByText<AuxiliaryTreatmentRequirement>(text);
        }
    }
}