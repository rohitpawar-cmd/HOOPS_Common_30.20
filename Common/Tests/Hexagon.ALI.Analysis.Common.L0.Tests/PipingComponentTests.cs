using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Xunit;
using static Hexagon.ALI.Analysis.Common.Classes.SIO.PipingComponent;

namespace Hexagon.ALI.Analysis.Common.Entities.L0.Tests
{
    public class PipingComponentTests
    {

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo")]
        public void Set_ConcentricReducer_CorrectlySetTags()
        {
            //arrange
            PipingComponent p = new PipingComponent();
            //act
            p.SetAsConcentricReducer();
            //assert
            Assert.Equal((int)ePipingComponentType.ConcentricReducer, p.PipingComponentType);
        }
        // hello world
        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo")]
        public void Set_EccentricReducer_CorrectlySetTags()
        {
            //arrange
            PipingComponent p = new PipingComponent();
            //act
            p.SetAsEccentricReducer();
            //assert
            Assert.Equal((int)ePipingComponentType.EccentricReducer, p.PipingComponentType);

        }
    }
}
