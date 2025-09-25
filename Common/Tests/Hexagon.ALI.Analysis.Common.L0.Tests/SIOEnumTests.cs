using Hexagon.ALI.Analysis.Common.Enums;
using Xunit;

namespace Hexagon.ALI.Analysis.Common.Entities.L0.Tests
{
    public class SIOEnumTests
    {

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - nl"),
        Trait("Description", "L0_SIOEnum_FindByTypeAndID")]
        public void Find_ByTypeAndID_ShouldReturnSIOEnum()
        {
            //arrange
            var expectedVal = AnalysisRestraintType.NLIM;
            //act
            var retVal = SIOEnum.FindByTypeAndID("AnalysisRestraintType", "5f7eb3a8-b2dc-48e5-bf59-d4e20950bf39");
            //assert
            if (retVal != null)
            {
                Assert.Equal(expectedVal, retVal);
            }
        }

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - nl"),
        Trait("Description", "L0_SIOEnum_FindByTypeAndText")]
        public void Find_ByTypeAndText_ShouldReturnSIOEnum()
        {
            //arrange
            var expectedVal = AnalysisRestraintType.NLIM;
            //act
            var retVal = SIOEnum.FindByTypeAndText("AnalysisRestraintType", "-LIM");
            //assert
            if (retVal != null)
            {
                Assert.Equal(expectedVal, retVal);
            }
        }


        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - nl"),
        Trait("Description", "L0_SIOEnum_FindByTypeAndNumber")]
        public void Find_ByTypeAndNumber_ShouldReturnSIOEnum()
        {
            //arrange
            var expectedVal = AnalysisRestraintType.NLIM;
            //act
            var retVal = SIOEnum.FindByTypeAndNumber("AnalysisRestraintType", "26");
            //assert
            if (retVal != null)
            {
                Assert.Equal(expectedVal, retVal);
            }
        }

    }
}