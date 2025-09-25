namespace Analysis2.SIO.Library.Enums
{
    public class InsulationCriteria : SIOEnum
    {
        #region VALUES
        public static readonly InsulationCriteria None = new InsulationCriteria("{bb16fd59-14bf-4bfc-b74a-6dd8bf1049ce}", "None", "", 0);
        public static readonly InsulationCriteria Neckonly = new InsulationCriteria("{c7bda8c0-791d-4496-b879-344f9b4b98af}", "NeckOnly", "", 1);
        public static readonly InsulationCriteria Complete = new InsulationCriteria("{36cc8ee8-fa48-4bc4-b623-b39ec416ad7f}", "Complete", "", 2);
        #endregion
        public InsulationCriteria(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator InsulationCriteria(string text)
        {
            return FindByText<InsulationCriteria>(text);
        }
    }
}