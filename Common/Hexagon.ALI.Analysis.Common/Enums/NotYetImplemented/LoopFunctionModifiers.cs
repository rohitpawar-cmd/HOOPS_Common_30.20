namespace Analysis2.SIO.Library.Enums
{
    public class LoopFunctionModifiers : SIOEnum
    {
        #region VALUES
        public static readonly LoopFunctionModifiers C = new LoopFunctionModifiers("{5632ec53-3a46-46a7-a91c-ed9ed2e51851}", "C", "Control", 1);
        public static readonly LoopFunctionModifiers Ic = new LoopFunctionModifiers("{ad4c8328-d4c1-44e3-b47a-6c2daad14c75}", "IC", "Indicating and Control", 3);
        public static readonly LoopFunctionModifiers Irc = new LoopFunctionModifiers("{6299cc01-76c1-486b-9d6e-0063c00a4e4a}", "IRC", "Indicating Control & Recording", 4);
        public static readonly LoopFunctionModifiers Rc = new LoopFunctionModifiers("{94e3213b-5c58-4adc-a684-c745e7bfaefb}", "RC", "Control Recording", 5);
        public static readonly LoopFunctionModifiers Ia = new LoopFunctionModifiers("{6e734f36-afa4-4344-9ed0-99d5ee2a4c7d}", "IA", "Indication and Alarm", 2);
        #endregion
        public LoopFunctionModifiers(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator LoopFunctionModifiers(string text)
        {
            return FindByText<LoopFunctionModifiers>(text);
        }
    }
}