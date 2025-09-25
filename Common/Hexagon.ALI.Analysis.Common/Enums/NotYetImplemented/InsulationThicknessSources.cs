namespace Analysis2.SIO.Library.Enums
{
    public class InsulationThicknessSources : SIOEnum
    {
        #region VALUES
        public static readonly InsulationThicknessSources BySystem = new InsulationThicknessSources("{0b35985d-e509-4448-a08a-bce438464efa}", "BySystem", "", 5);
        public static readonly InsulationThicknessSources ByUser = new InsulationThicknessSources("{55e75ac6-46d4-4874-9b3a-9d621ebac704}", "ByUser", "", 10);
        #endregion
        public InsulationThicknessSources(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator InsulationThicknessSources(string text)
        {
            return FindByText<InsulationThicknessSources>(text);
        }
    }
}