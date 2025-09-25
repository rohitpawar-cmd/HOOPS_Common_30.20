namespace Analysis2.SIO.Library.Enums
{
    public class ConstructionType : SIOEnum
    {
        #region VALUES
        public static readonly ConstructionType Undefined = new ConstructionType("{E6857082-A050-430B-880A-6B44A5D8A0F1}", "Undefined", "", 1);
        public static readonly ConstructionType New = new ConstructionType("{78398AB4-9F3D-11D6-BDA7-00104BCC2B69}", "New", "", 2);
        public static readonly ConstructionType Revamp = new ConstructionType("{78398AC6-9F3D-11D6-BDA7-00104BCC2B69}", "Revamp", "", 4);
        public static readonly ConstructionType Temporary = new ConstructionType("{78398AD2-9F3D-11D6-BDA7-00104BCC2B69}", "Temporary", "", 6);
        public static readonly ConstructionType Dismantle = new ConstructionType("{78398AD8-9F3D-11D6-BDA7-00104BCC2B69}", "Dismantle", "", 7);
        public static readonly ConstructionType Existing = new ConstructionType("{78398ADE-9F3D-11D6-BDA7-00104BCC2B69}", "Existing", "", 10);
        public static readonly ConstructionType ExistingToBeModified = new ConstructionType("{78398AE4-9F3D-11D6-BDA7-00104BCC2B69}", "Existing, to be modified", "", 15);
        public static readonly ConstructionType ExistingToBeReusedInPlace = new ConstructionType("{4ABC4303-89AC-4FEF-851F-B0E154085FE5}", "Existing, to be reused in place", "", 17);
        public static readonly ConstructionType ExistingToBeModifiedAndRelocated = new ConstructionType("{78398AEA-9F3D-11D6-BDA7-00104BCC2B69}", "Existing, to be modified and relocated", "", 20);
        public static readonly ConstructionType ExistingToBeRelocatedAndReUsed = new ConstructionType("{78398AF0-9F3D-11D6-BDA7-00104BCC2B69}", "Existing, to be relocated and re-used", "", 25);
        public static readonly ConstructionType ExistingNotToBeRevamped = new ConstructionType("{3DF6943A-51DB-434C-9CF4-02805077B42E}", "Existing, not to be revamped", "", 27);
        public static readonly ConstructionType Recalibrate = new ConstructionType("{78398AF6-9F3D-11D6-BDA7-00104BCC2B69}", "Recalibrate", "", 30);
        public static readonly ConstructionType Relocate = new ConstructionType("{28904EF8-F0AD-4498-AED9-A45DF0E9739D}", "Relocate", "", 31);
        public static readonly ConstructionType Future = new ConstructionType("{78398AFC-9F3D-11D6-BDA7-00104BCC2B69}", "Future", "", 8);
        public static readonly ConstructionType Proposed = new ConstructionType("{78398B02-9F3D-11D6-BDA7-00104BCC2B69}", "Proposed", "", 9);
        #endregion
        public ConstructionType(string uid, string text, string description, int number) : base(uid, text, description, number)
        {
        }

        public static implicit operator ConstructionType(string text)
        {
            return FindByText<ConstructionType>(text);
        }
    }
}