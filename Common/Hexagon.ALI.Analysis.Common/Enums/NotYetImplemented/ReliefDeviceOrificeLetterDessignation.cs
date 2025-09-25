namespace Analysis2.SIO.Library.Enums
{
    public class ReliefDeviceOrificeLetterDessignation : SIOEnum
    {
        #region VALUES
        public static readonly ReliefDeviceOrificeLetterDessignation D = new ReliefDeviceOrificeLetterDessignation("{02c8b75e-58fd-4f7b-96dd-5d0ab2a95c51}", "D", "", 1);
        public static readonly ReliefDeviceOrificeLetterDessignation E = new ReliefDeviceOrificeLetterDessignation("{11eb3d06-2392-47fe-acfe-e093080f749c}", "E", "", 2);
        public static readonly ReliefDeviceOrificeLetterDessignation F = new ReliefDeviceOrificeLetterDessignation("{74a4dce9-9281-4566-813c-a3afa0b683b1}", "F", "", 3);
        public static readonly ReliefDeviceOrificeLetterDessignation G = new ReliefDeviceOrificeLetterDessignation("{ea680929-b5ee-44e0-9610-49c768ed881b}", "G", "", 4);
        public static readonly ReliefDeviceOrificeLetterDessignation H = new ReliefDeviceOrificeLetterDessignation("{2735a3f5-81a2-4825-815c-907857b67c0c}", "H", "", 5);
        public static readonly ReliefDeviceOrificeLetterDessignation J = new ReliefDeviceOrificeLetterDessignation("{45374eb2-739f-4cad-b920-dcc49ac7bc64}", "J", "", 6);
        public static readonly ReliefDeviceOrificeLetterDessignation K = new ReliefDeviceOrificeLetterDessignation("{8ac4db50-2a8d-461e-9f68-6447663fa335}", "K", "", 7);
        public static readonly ReliefDeviceOrificeLetterDessignation L = new ReliefDeviceOrificeLetterDessignation("{a7adfe5c-e6b4-43de-9eca-46c745cecbd2}", "L", "", 8);
        public static readonly ReliefDeviceOrificeLetterDessignation M = new ReliefDeviceOrificeLetterDessignation("{0969272b-dd50-46d0-be93-9a1fca36ca75}", "M", "", 9);
        public static readonly ReliefDeviceOrificeLetterDessignation N = new ReliefDeviceOrificeLetterDessignation("{1e08155d-82db-4710-abc6-b17517ec9614}", "N", "", 10);
        public static readonly ReliefDeviceOrificeLetterDessignation P = new ReliefDeviceOrificeLetterDessignation("{f8deca7d-c358-49eb-91f6-c7140444bd3b}", "P", "", 11);
        public static readonly ReliefDeviceOrificeLetterDessignation Q = new ReliefDeviceOrificeLetterDessignation("{2018de87-564b-43c5-831e-cd72961d254d}", "Q", "", 12);
        public static readonly ReliefDeviceOrificeLetterDessignation R = new ReliefDeviceOrificeLetterDessignation("{c542044c-4642-4105-bdea-23a23041f5a0}", "R", "", 13);
        public static readonly ReliefDeviceOrificeLetterDessignation T = new ReliefDeviceOrificeLetterDessignation("{579b2ad4-c4d6-46ca-ac5f-1c918561fc4b}", "T", "", 14);
        #endregion
        public ReliefDeviceOrificeLetterDessignation(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator ReliefDeviceOrificeLetterDessignation(string text)
        {
            return FindByText<ReliefDeviceOrificeLetterDessignation>(text);
        }
    }
}