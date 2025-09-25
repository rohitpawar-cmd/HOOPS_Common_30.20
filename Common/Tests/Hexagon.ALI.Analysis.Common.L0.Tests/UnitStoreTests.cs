using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers.Units;
using Xunit;


namespace Hexagon.ALI.Analysis.Common.Tests.L0
{

    public class UnitStoreTests
    {
        ITestOutputHelper output;
        UnitStore unitStore;
        public UnitStoreTests(ITestOutputHelper outputHelper)
        {
            output = outputHelper;
            unitStore = new UnitStore();
        }

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_AddUnit")]
        public void Add_UnitToUnitStore_ShouldReturnAddedUnit()
        {
            //arrange
            unitStore.AddUserUnit("LengthUoM", "in", 39.37007874015748031496062992126);
            //act
            UserUnits units = unitStore.GetUserUnit("LengthUoM");

            //assert
            Assert.NotNull(units);
            Assert.Equal("in", units.UomSymbol);
            Assert.Equal(0, units.Constant);
            Assert.Equal(39.37007874015748031496062992126, units.ConversionFactorToSI);
            Assert.Equal("LengthUoM", units.UomType);
        }

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_ChangeExistingUnit")]
        public void ChangeExisting_UnitInUnitStore_ShouldReturnChangedUnit()
        {
            //arrange
            unitStore.AddUserUnit("LengthUoM", "in", 39.37007874015748031496062992126);
            unitStore.AddUserUnit("LengthUoM", "mm", 1000);
            //act
            UserUnits units = unitStore.GetUserUnit("LengthUoM");

            //assert
            Assert.NotNull(units);
            Assert.Equal("mm", units.UomSymbol);
            Assert.Equal(0, units.Constant);
            Assert.Equal(1000, units.ConversionFactorToSI);
            Assert.Equal("LengthUoM", units.UomType);
        }


        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_GetUserUnit_ReturnsNull")]
        public void Get_NonExistUserUnit_ReturnsNull()
        {
            //arrange//act
            UserUnits units = unitStore.GetUserUnit("NonExist");
            //assert
            Assert.Null(units);
        }

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_GetUserUnit_ReturnsExpectedl")]
        public void AddAndRetrieve_UserUnit_AddsAndReturnsExpected()
        {
            //arrange
            unitStore.AddUserUnit("LengthUoM", "m", 1);
            //act
            UserUnits units = unitStore.GetUserUnit("LengthUoM");
            //assert
            Assert.NotNull(units);
            Assert.Equal("LengthUoM", units.UomType);
        }

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_UnitsNotExist_ReturnsNull")]
        public void Create_InstanceOfUSClass_CreatesNewInstanceOfClass()
        {
            //arrange //act
            UnitStore units = new UnitStore();
            //assert
            Assert.NotNull(units);
            // 10/20/2023 - Units now has 33 values with the addition of AreaUoM
            // 31/01/2024 - Units now has 0 values as we are not setting default units.
            Assert.Empty(units.GetUnitsDictionary());
        }
        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_UnitsNotExist_ReturnsNull")]
        public void Create_InstanceOfClassFromPipingSystem_CreatesNewInstanceOfClass()
        {
            //arrange
            var ps = new PipingSystem();
            //act
            var unitsDict = ps.UserUnits.GetUnitsDictionary();
            //assert            
            Assert.NotNull(unitsDict);
            // 10/20/2023 - Units now has 33 values with the addition of AreaUoM
            // 31/01/24 - Units now has 0 values as we are not setting default units.
            Assert.Empty(unitsDict);

        }
        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_UnitsExists_ReturnsDictionary")]
        public void GetUnitsDictionary_ForUnitStore_ReturnsDictionary()
        {
            //arrange
            unitStore.AddUserUnit("LengthUoM", "in", 39.37007874015748031496062992126);
            //act
            var unitsDict = unitStore.GetUnitsDictionary();
            //assert
            Assert.NotNull(unitsDict);
        }
    }
}
