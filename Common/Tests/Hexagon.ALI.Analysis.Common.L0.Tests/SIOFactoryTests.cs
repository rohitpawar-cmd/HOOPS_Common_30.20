using Hexagon.ALI.Analysis.Common.Classes;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Helpers.Objects;
using Xunit;


namespace Hexagon.ALI.Analysis.Common.Entities.L0.Tests
{
    public class SIOFactoryTest
    {
        List<string> _listOfDefUID;
        ITestOutputHelper _output;
        public SIOFactoryTest(ITestOutputHelper output)
        {
            _listOfDefUID = Enum.GetNames(typeof(SIOFactory.DEFUID)).ToList();
            _output = output;
        }
        [Fact]
        public void Create_EmptyInput_ReturnsNull()
        {
            //arrange
            var obj = new SIORelation(new Pipe(), new PipeRun(), new RelDefAttribute(string.Empty));
            dynamic t = string.Empty;
            //act
            var entityFromt = SIOFactory.Create(t);
            var entityFromObj = SIOFactory.Create(obj.GetType());
            //assert
            Assert.Null(entityFromt);
            Assert.Null(entityFromObj);
        }
        [Theory, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_Factory_ValidEnumTypeAsInput_ReturnsSIPEntityExpected")]
        [ClassData(typeof(AllSIOEntity))]
        public void Create_ValidEnumValAsInput_ReturnsSIPEntityExpected(Type type)
        {
            //arrange
            Enum.TryParse<SIOFactory.DEFUID>(type.Name, out var val);
            //act
            var entity = SIOFactory.Create(val);
            //assert
            Assert.NotNull(entity);

        }

        [Theory, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_Factory_Create_ValidEnumTypeNameAsInput_ReturnsSIPEntityExpected")]
        [ClassData(typeof(AllSIOEntity))]
        public void Create_ValidEnumTypeNameAsInput_ReturnsSIPEntityExpected(Type type)
        {
            //arrange
            _output.WriteLine($"Creating {type.Name}");
            //act
            var entity = SIOFactory.Create(type.Name);
            //assert
            Assert.NotNull(entity);

        }

        [Theory, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_Factory_Create_ValidEnumAsInput_ReturnsSIPEntityExpected")]
        [ClassData(typeof(AllSIOEntity))]
        public void Create_ValidEnumAsInput_ReturnsSIPEntityExpected(Type typeOfEntity)
        {
            //arrange
            _output.WriteLine($"Creating {typeOfEntity.Name}");
            //act
            SIOEntity? entity = SIOFactory.Create(typeOfEntity);
            if (entity != null)
            {
                entity = TestHelper.SetDefaultProperties(entity);
            }
            //assert
            Assert.NotNull(entity);
        }

        [Theory, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_Factory_Check_EnumAsInput_AssertAllEntitiesPresent")]
        [ClassData(typeof(AllSIOEntity))]
        public void Check_DEFUIDAsInput_AssertAllEntitiesPresent(Type typeOfEntity)
        {
            //arrange //act //assert
            Assert.Contains(typeOfEntity.Name, _listOfDefUID);
        }

    }
}
