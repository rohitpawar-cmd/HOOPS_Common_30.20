namespace Analysis2.SIO.Library.Enums
{
    public class InstallationResponsibility : SIOEnum
    {
        #region VALUES
        public static readonly InstallationResponsibility Undefined = new InstallationResponsibility("{B993B8F9-DCDB-423D-BAAB-8C4C25961AC7}", "Undefined", "", 1);
        public static readonly InstallationResponsibility None = new InstallationResponsibility("{1117B197-81B4-424B-B815-21E672EEDD7A}", "None", "", 5);
        public static readonly InstallationResponsibility Contractor = new InstallationResponsibility("{953EB0B4-0166-412B-AAB7-6496447664C0}", "Contractor", "", 10);
        public static readonly InstallationResponsibility Owner = new InstallationResponsibility("{3F3772C9-EBB7-467C-B3FA-BBB6B0D0792C}", "Owner", "", 15);
        public static readonly InstallationResponsibility EquipmentVendor = new InstallationResponsibility("{FB2413F8-7540-4338-A9CB-8082ED047581}", "Equipment Vendor", "", 20);
        public static readonly InstallationResponsibility Piping = new InstallationResponsibility("{714411AC-9129-4F89-BD41-ED670FC8A64E}", "Piping", "", 25);
        public static readonly InstallationResponsibility Instruments = new InstallationResponsibility("{0EC3B581-5078-4A31-9F83-3B36C8ADCD0F}", "Instruments", "", 30);
        public static readonly InstallationResponsibility Others = new InstallationResponsibility("{4E881F7D-B173-45FE-A78E-0D33C155C727}", "Others", "", 35);
        #endregion
        public InstallationResponsibility(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator InstallationResponsibility(string text)
        {
            return FindByText<InstallationResponsibility>(text);
        }
    }
}