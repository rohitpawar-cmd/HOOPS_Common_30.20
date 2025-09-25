namespace Analysis2.SIO.Library.Enums
{
    public class InsulationRequirement : SIOEnum
    {
        #region VALUES
        public static readonly InsulationRequirement Undefined = new InsulationRequirement("{ad733a43-1af2-4706-bc4a-1b37af87cadf}", "Undefined", "", 1);
        public static readonly InsulationRequirement None = new InsulationRequirement("{930067d6-f4d6-4cea-aa42-08ca08c75492}", "None", "", 2);
        public static readonly InsulationRequirement Internal = new InsulationRequirement("{e53d7343-876e-498a-b45c-6f2569f8ff4a}", "Internal", "", 5);
        public static readonly InsulationRequirement External = new InsulationRequirement("{fa7e44a0-79bc-406b-9d3b-9e8f8c2cd1ca}", "External", "", 10);
        #endregion
        public InsulationRequirement(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator InsulationRequirement(string text)
        {
            return FindByText<InsulationRequirement>(text);
        }
    }
}