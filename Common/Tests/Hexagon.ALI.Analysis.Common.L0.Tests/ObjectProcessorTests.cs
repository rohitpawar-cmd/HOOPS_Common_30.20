using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Helpers.Objects;
using Xunit;

namespace Hexagon.ALI.Analysis.Common.Tests.L0
{
    public class ObjectProcessorTests
    {
        private ObjectProcessor objectProcessor;
        private PipingSystem pingSystem;
        public ObjectProcessorTests()
        {
            objectProcessor = new ObjectProcessor();
            pingSystem = TestHelper.GetPipingSystem();
        }
        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_GetInnerEntitiesAndRelations_ReturnsExpected")]
        public void GetInnerEntitiesAndRelations_ForPipingSystem_ReturnsExpected()
        {
            //arrange
            var objs = new List<SIOObject>();
            //act
            var listOfEnt = objectProcessor.GetInnerEntitiesAndRelations(pingSystem);
            objs.AddRange(listOfEnt.Relations);
            objs.AddRange(listOfEnt.Entities);
            //assert
            Assert.Equal(33, listOfEnt.Entities.Count());
            Assert.Equal(40, listOfEnt.Relations.Count());
            Assert.True(objs.Count() == 73);
        }

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_ConstructBatch_ReturnsExpected")]
        public void ConstructBatch_ForPSObjects_ReturnsExpected()
        {
            //arrange
            var objs = new List<SIOObject>();
            var listOfEnt = objectProcessor.GetInnerEntitiesAndRelations(pingSystem);
            objs.AddRange(listOfEnt.Relations);
            objs.AddRange(listOfEnt.Entities);
            //act
            var result = objectProcessor.ConstructBatch(objs);
            //assert
            Assert.True(result.ConnectedEntities.Count() == 18);
            Assert.True(result.ConnectedRelation.Count() == 22);
            Assert.True(result.OtherEntitiesAndRelations.Count() == 33);
        }

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_ConstructObjectsForPPMGeneration_ReturnsExpected")]
        public void ConstructObjects_ForPPMGeneration_ReturnsExpected()
        {
            //arrange
            var objs = new List<SIOObject>();
            var listOfEnt = objectProcessor.GetInnerEntitiesAndRelations(pingSystem);
            var relation = listOfEnt.Relations;
            var entities = listOfEnt.Entities;
            objs.AddRange(relation);
            objs.AddRange(entities);
            //act
            var result = objectProcessor.ConstructBatch(objs);
            //assert
            Assert.True(result.ConnectedEntities.Count() == 18);
            Assert.True(result.ConnectedRelation.Count() == 22);
            Assert.True(result.OtherEntitiesAndRelations.Count() == 33);
        }


        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_GetChildObjects_ReturnsExpected")]
        public void GetChildObjects_ForPipingSystem_ReturnsExpected()
        {
            //arrange
            PipingSystem PipingSystem = new()
            {
                Name = $"PipingSystem-CASCoreModel",
                
                Description = "PipingSystem used for L1 CASCore Model Testing purposes."
            };

            Pipeline pl = new()
            {
                Name = $"Pipeline-CASCoreModel",
                
                Description = "Pipeline used for L1 CASCore Model Testing purposes.",
                PipelineFluidCode = FluidCode.G.Text,
                PipelineFluidSystem = FluidSystem.Gas.Text,
                PipelineSequenceNumber = "10"
            };
            PipingSystem.OwnsPipelines.Add(pl);

            var objectProc = new ObjectProcessor();
            //var sets = objectProc.SetInnerElements(PipingSystem);
            //act
            var result = objectProc.GetInnerElements(PipingSystem);
            //assert
            Assert.NotEmpty(result);
            Assert.Equal(result.FirstOrDefault().Entity, pl);

        }


        [Theory, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_CreateBatchFromConnectedSubGraphsNumberOfBatches_ReturnsExpected")]
        [InlineData(1, 1)]
        [InlineData(5, 5)]
        [InlineData(2, 2)]
        [InlineData(100, 18)]
        public void CreateBatch_FromConnectedSubGraphsNumberOfBatches_ReturnsExpected(int numberOfBatches, int expected)
        {
            //arrange
            var objs = new List<SIOObject>();
            var ents = objectProcessor.GetInnerEntitiesAndRelations(pingSystem);
            objs.AddRange(ents.Relations);
            objs.AddRange(ents.Entities);
            var res = objectProcessor.ConstructBatch(objs);
            //act
            var batch = objectProcessor.CreateBatchFromConnectedSubGraphsNumberOfBatches(res.ConnectedEntities, res.ConnectedRelation, numberOfBatches);
            //assert
            Assert.True(batch.Count() == expected);
        }

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_CreateBatchFromConnectedSubGraphsBatchSize_ReturnsExpected")]
        public void CreateBatch_FromConnectedSubGraphsBatchSize_ReturnsExpected()
        {
            //arrange
            var objs = new List<SIOObject>();
            var batchSize = 2;
            var ents = objectProcessor.GetInnerEntitiesAndRelations(pingSystem);
            objs.AddRange(ents.Relations);
            objs.AddRange(ents.Entities);
            var res = objectProcessor.ConstructBatch(objs);

            //act
            var batch = objectProcessor.CreateBatchFromConnectedSubGraphsBatchSize(res.Item1, res.Item2, batchSize);

            //assert
            Assert.True(batch.Count() == 18);
            Assert.True(batch.First().Count() == 2);
            Assert.True(batch.Last().Count() == 2);
        }


        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_CreateBatchFromConnectedSubGraphsBatchSize_ReturnsExpected")]
        public void CreateBatch_FromConnectedSubGraphsBatchSizeForLoadCase_ReturnsExpected()
        {
            //arrange 
            var pipingsystem = new PipingSystem();
            var an = new AnalysisNode();
            var al = new AnalysisLoadCase();
            var aDisp = new AnalysisDisplacementOutput();
            var objs = new List<SIOObject>();
            var batchSize = 2;

            pipingsystem.OwnsAnalysisLoadCase.Add(al);
            pipingsystem.OwnsAnalysisNode.Add(an);

            an.OwnsAnalysisNodeAuxiliaries.Add(aDisp);
            al.NodeAuxiliaries.Add(aDisp);

            var ents = objectProcessor.GetInnerEntitiesAndRelations(pipingsystem);

            objs.AddRange(ents.Relations);
            objs.AddRange(ents.Entities);
            var res = objectProcessor.ConstructBatch(objs);

            //act
            var batch = objectProcessor.CreateBatchFromConnectedSubGraphsBatchSize(res.Item1, res.Item2, batchSize);
            //assert
            Assert.True(batch.Count() == 2);
            Assert.True(batch.First().Count() == 2);
            Assert.True(batch.Last().Count() == 4);
        }
    }
}
