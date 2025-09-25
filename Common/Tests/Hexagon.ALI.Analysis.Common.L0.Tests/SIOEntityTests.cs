using Hexagon.ALI.Analysis.Common.Classes;
using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs.NozzleFlex;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Helpers.Objects;
using Xunit;

using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Reports;
using System.ComponentModel.DataAnnotations.Schema;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Reports;

namespace Hexagon.ALI.Analysis.Common.Entities.L0.Tests
{
    public class SIOEntityTests
    {
        ITestOutputHelper _output;
        ObjectProcessor _objProc;
        public SIOEntityTests(ITestOutputHelper output)
        {
            _output = output;
            _objProc = new ObjectProcessor();
        }

        [Theory, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_Validate_ForValidUoMValue_ShouldAssertCalculations")]
        [InlineData("10", 10.0)]
        [InlineData("1.00e1", 10.0)]
        [InlineData("1.00E1", 10.0)]
        [InlineData("-1.00E1", -10.0)]
        [InlineData(null, null)]
        public void Validate_ForValidUoMValue_ShouldAssertCalculations(string? value, double? excepted)
        {
            //arrange
            Globals.userUnits.AddUserUnit("SlopeUoM", "ft/ft", 1);
            var pipeRun = new PipeRun();
            pipeRun.MinSlope = value;
            pipeRun.SetUomValues(Globals.userUnits);
            Assert.Equal(excepted, pipeRun.MinSlopeSiValue);
        }

        [InlineData("          ")]
        [InlineData(" ")]
        [Theory, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_Validate_ForInvalidUoMValue_ThrowsIncorrectSiValueException")]
        public void Validate_ForInvalidUoMValue_ThrowsIncorrectSiValueException(string value)
        {
            //arrange
            var pipeRun = new PipeRun();
            pipeRun.MinSlope = value;
            Assert.Throws<IncorrectSiValueException>(() => pipeRun.SetUomValues(Globals.userUnits));
        }

        [Fact, Trait("Priority", "0"),
Trait("Author", "Hermes - oo"),
Trait("Description", "L0_UniformLoad_ReassignValue")]
        public void UniformLoad_ReassignValue()
        {
            //arrange
            PipingSystem ps = new();
            ps.UserUnits.AddUserUnit("UniformLoadUoM", "N/m", 1);
            ps.UserUnits.AddUserUnit("GLoadUoM", "p", 1000);
            var uniformLoad = new AnalysisUniformLoadDataSet();
            uniformLoad.UniformLoadX = "10";
            uniformLoad.SetUomValues(ps.UserUnits);
            Assert.Equal(uniformLoad.UniformLoadXSiValue, 10);

            //act
            uniformLoad.UniformLoadType = true;
            Assert.Null(uniformLoad.UniformLoadXSiValue);
            //assert

            uniformLoad.SetUomValues(ps.UserUnits);
            Assert.Equal(uniformLoad.UniformLoadXSiValue, .01);

        }

        [Theory, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_Init")]
        [InlineData("true m/m")]
        [InlineData("truem/m")]
        [InlineData("true T")]
        [InlineData("10M")]
        [InlineData(" m/m")]
        [InlineData("10 m/m")]
        [InlineData("10 T")]
        public void Init_AssignedValuesForUoM_ShouldAssertLoadValues(string data)
        {
            var pipeRun = new PipeRun();
            pipeRun.MinSlope = data;
            Assert.Throws<IncorrectSiValueException>(() => pipeRun.SetUomValues(Globals.userUnits));
        }

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_Init")]
        public void OtherUoMTest()
        {
            PipingSystem ps = new();
            ps.UserUnits.AddUserUnit("UniformLoadUoM", "mN/m", 1000);
            ps.UserUnits.AddUserUnit("GLoadUoM", "gs", 0.10197162129779);
            var uniformLoad = new AnalysisUniformLoadDataSet();
            uniformLoad.UniformLoadX = "10";

            var uniformLoadForTrueType = new AnalysisUniformLoadDataSet();
            uniformLoadForTrueType.UniformLoadX = "10";
            uniformLoadForTrueType.UniformLoadType = true;

            var uniformLoadG = new AnalysisUniformLoadDataSet(true);
            uniformLoadG.UniformLoadX = "50";

            var postUniformLoad = new AnalysisUniformLoadDataSet();
            postUniformLoad.UniformLoadX = "100";

            _objProc.InitializeSiValue(new List<SIOEntity> { uniformLoad, uniformLoadG, postUniformLoad }, ps.UserUnits);

            Assert.Equal(0.01, uniformLoad.UniformLoadXSiValue);
            Assert.Equal(490.33250000001357, uniformLoadG.UniformLoadXSiValue);
            Assert.Equal(0.1, postUniformLoad.UniformLoadXSiValue);

            uniformLoad.UniformLoadType = true;

            Assert.Null(uniformLoad.UniformLoadXSiValue);

            uniformLoad.SetUomValues(ps.UserUnits);
            Assert.Equal(98.066500000002719, uniformLoad.UniformLoadXSiValue);

        }

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_Init")]
        public void LoadCaseTest()
        {
            var lc1 = new AnalysisLoadCase();
            lc1.LoadCaseDefinition.LoadCaseComponents.Add(new AnalysisLoadCaseComponent() { Primitive = new AnalysisOperatingPrimitive() {PrimitiveType = PrimitiveType.T } });

            var combolc = new AnalysisLoadCase();
            combolc.LoadCaseDefinition.LoadCaseComponents.Add(new AnalysisLoadCaseComponent() { Primitive = new AnalysisLoadCasePrimitive() { PrimitiveType = PrimitiveType.LC, LoadCase = lc1 } });

            Assert.False(lc1.IsCombonation);
            Assert.True(combolc.IsCombonation);

        }

        [Fact, Trait("Priority", "0"),
        Trait("Author", "Hermes - oo"),
        Trait("Description", "L0_Init")]
        public void Init_AssignedDefaults_ShouldInitilizeObjects()
        {
            var plant = new Plant();
            plant.Description = "";
            plant.Id = "";
            plant.Name = "";


            var pipingSystem = new PipingSystem();
            pipingSystem.Description = "";
            pipingSystem.Id = "";
            pipingSystem.Name = "";
            pipingSystem.BreakdownTypeDescription = "";
            pipingSystem.BreakdownClass = "";
            pipingSystem.BreakdownType = "";
            pipingSystem.SpecificBreakdownType = "";
            pipingSystem.OwnsAnalysisLoadCase = null;
            pipingSystem.OwnsAnalysisNode = null;
            pipingSystem.OwnsPipelines = null;

            var pipeline = new Pipeline("1");
            pipeline.Description = "";
            pipeline.Id = "";
            pipeline.Name = "";
            pipeline.OwnsPipeRuns = null;
            pipeline.OwnsSupports = null;
            pipeline.PipelineFluidCode = "";
            pipeline.PipelineFluidSystem = "";
            pipeline.PipelineSequenceNumber = "";

            var pipe = new Pipe();
            pipe.Description = "";
            pipe.Id = "";
            pipe.Name = "";
            pipe.LocationX = "";
            pipe.LocationY = "";
            pipe.LocationZ = "";
            pipe.OrientationX = 0;
            pipe.OrientationY = 0;
            pipe.OrientationZ = 0;
            pipe.RadialOrientX = 0;
            pipe.RadialOrientY = 0;
            pipe.RadialOrientZ = 0;
            pipe.UVectorX = 0;
            pipe.UVectorY = 0;
            pipe.UVectorZ = 0;
            pipe.RteBendDataBendAngle = "";
            pipe.RteBendDataBendRadius = "";
            pipe.RteBendDataBRadMulti = "";
            pipe.RteBendDataThroatRadius = "";
            pipe.RteBendDataNoOfMiters = "";
            pipe.AnalysisAbstractPipe = null;
            pipe.OwnsRoutePorts = null;
            pipe.PartOverrides = null;
            pipe.SupportHasSupportedObject = null;

            var pipingComponent = new PipingComponent();
            pipingComponent.Description = "";
            pipingComponent.Id = "";
            pipingComponent.Name = "";
            pipingComponent.PipeComponentGeometryType = "";
            pipingComponent.PipePartIsSpecialty = false;
            pipingComponent.PipePartMaterialCategory = "";
            pipingComponent.PipePartMaterialGradePractice = "";
            pipingComponent.PipePartShortMatlDesc = "";
            pipingComponent.PipePartMaterialGrade = "";
            pipingComponent.RteBendDataBendAngle = "";
            pipingComponent.RteBendDataBendRadius = "";
            pipingComponent.RteBendDataBRadMulti = "";
            pipingComponent.RteBendDataThroatRadius = "";
            pipingComponent.RteBendDataNoOfMiters = "";
            pipingComponent.AnalysisAbstractPipe = null;
            pipingComponent.OwnsRoutePorts = null;
            pipingComponent.PartOverrides = null;
            pipingComponent.SupportHasSupportedObject = null;

            var pipeStraightOverride = new PipeStraightOverride();
            pipeStraightOverride.Description = "";
            pipeStraightOverride.Id = "";
            pipeStraightOverride.Name = "";
            pipeStraightOverride.StraightPathOverrideLength = "";
            pipeStraightOverride.AnalysisBeams = null;
            pipeStraightOverride.StartLocX = "";
            pipeStraightOverride.StartLocY = "";
            pipeStraightOverride.StartLocZ = "";
            pipeStraightOverride.EndLocX = "";
            pipeStraightOverride.EndLocY = "";
            pipeStraightOverride.EndLocZ = "";
            pipeStraightOverride.PipePathOverrideNPD = "";
            pipeStraightOverride.PipePathOverrideOuterDiameter = "";

            var pipeTurnOverride = new PipeTurnOverride();
            pipeTurnOverride.Description = "";
            pipeTurnOverride.Id = "";
            pipeTurnOverride.Name = "";
            pipeTurnOverride.TurnPathOverrideBendAngle = "";
            pipeTurnOverride.TurnPathOverrideBendRadius = "";
            pipeTurnOverride.TurnPathOverrideBRadMulti = "";
            pipeTurnOverride.TurnPathOverrideThroatRadius = "";
            pipeTurnOverride.AnalysisBeams = null;
            pipeTurnOverride.StartLocX = "";
            pipeTurnOverride.StartLocY = "";
            pipeTurnOverride.StartLocZ = "";
            pipeTurnOverride.EndLocX = "";
            pipeTurnOverride.EndLocY = "";
            pipeTurnOverride.EndLocZ = "";
            pipeTurnOverride.PipePathOverrideNPD = "";
            pipeTurnOverride.PipePathOverrideOuterDiameter = "";

            var pipingPort = new PipingPort();
            pipingPort.Description = "";
            pipingPort.Id = "";
            pipingPort.Name = "";
            pipingPort.LocationX = "";
            pipingPort.LocationY = "";
            pipingPort.LocationZ = "";
            pipingPort.PhysicalPortToPort = null;
            pipingPort.ReinforcedWallThickness = "";
            pipingPort.WallThicknessOrGrooveSetback = "";
            pipingPort.PipePortSchedulePractice = "";
            pipingPort.PipePortScheduleThickness = "";
            pipingPort.PipePortIndex = "";
            pipingPort.PipePortNpd = "";
            pipingPort.PipingOutsideDiameter = "";


            var branchEndPort = new BranchEndPort();
            branchEndPort.Description = "";
            branchEndPort.Id = "";
            branchEndPort.Name = "";

            var support = new Support();
            support.Description = "";
            support.Id = "";
            support.Name = "";
            support.LocationX = "";
            support.LocationY = "";
            support.LocationZ = "";
            support.OrientationX = 0;
            support.OrientationY = 0;
            support.OrientationZ = 0;
            support.RadialOrientX = 0;
            support.RadialOrientY = 0;
            support.RadialOrientZ = 0;
            support.UVectorX = 0;
            support.UVectorY = 0;
            support.UVectorZ = 0;
            support.HgrSupportDirection = "";
            support.IsogenKey = "";
            support.IsoSheetNo = "";
            support.StressSystemNo = "";

            var analysisNode = new AnalysisNode();
            analysisNode.Description = "";
            analysisNode.Id = "";
            analysisNode.Name = "";
            analysisNode.NodeNumber = "";
            analysisNode.LocationX = "";
            analysisNode.LocationY = "";
            analysisNode.LocationZ = "";
            analysisNode.Flags = (int)InputOutputFlags.Input;

            var analysisPipe = new AnalysisPipe();
            analysisPipe.Description = "";
            analysisPipe.Id = "";
            analysisPipe.Name = "";
            analysisPipe.BaseDX = "";
            analysisPipe.BaseDY = "";
            analysisPipe.BaseDZ = "";
            analysisPipe.GraphicsCoordinates = "";
            analysisPipe.OwnsAnalysisNodes = null;
            analysisPipe.OwnsAnalysisProcessInfoDataSet = null;
            analysisPipe.ElementType =  AnalysisLineElementType.AnalysisPipe;

            var analysisReducer = new AnalysisReducer();
            analysisReducer.Description = "";
            analysisReducer.Id = "";
            analysisReducer.Name = "";
            analysisReducer.BaseDX = "";
            analysisReducer.BaseDY = "";
            analysisReducer.BaseDZ = "";
            analysisReducer.GraphicsCoordinates = "";
            analysisReducer.OwnsAnalysisNodes = null;
            analysisReducer.OwnsAnalysisProcessInfoDataSet = null;
            analysisReducer.Alpha = "";
            analysisReducer.L1 = "";
            analysisReducer.L2 = "";
            analysisReducer.R1 = "";
            analysisReducer.R2 = "";
            analysisReducer.ElementType = AnalysisLineElementType.AnalysisReducer;

            var analysisBend = new AnalysisBend();
            analysisBend.Description = "";
            analysisBend.Id = "";
            analysisBend.Name = "";
            analysisBend.BaseDX = "";
            analysisBend.BaseDY = "";
            analysisBend.BaseDZ = "";
            analysisBend.GraphicsCoordinates = "";
            analysisBend.OwnsAnalysisNodes = null;
            analysisBend.OwnsAnalysisProcessInfoDataSet = null;
            analysisBend.OverlayThickness = "";
            analysisBend.WeldReductionFactor = 0;
            analysisBend.BendType = null;
            analysisBend.FittingThickness = "";
            analysisBend.KFactorIn = 0;
            analysisBend.SeamWelded = false;
            analysisBend.ElementType = AnalysisLineElementType.AnalysisBend;
            analysisBend.Tangent1XSiValue = 0.0;
            analysisBend.Tangent1YSiValue = 0.0;
            analysisBend.Tangent1ZSiValue = 0.0;
            analysisBend.Tangent2XSiValue = 0.0;
            analysisBend.Tangent2YSiValue = 0.0;
            analysisBend.Tangent2ZSiValue = 0.0;

            var analysisLoadCase = new AnalysisLoadCase();
            analysisLoadCase.Description = "";
            analysisLoadCase.Id = "";
            analysisLoadCase.Name = "";
            analysisLoadCase.LoadCaseName = "";
            analysisLoadCase.LoadCaseNumber = 0;
            analysisLoadCase.NodeAuxiliaries = null;

            var analysisAppliedPointForce = new AnalysisAppliedPointForce();
            analysisAppliedPointForce.Description = "";
            analysisAppliedPointForce.Id = "";
            analysisAppliedPointForce.Name = "";
            analysisAppliedPointForce.MX = "";
            analysisAppliedPointForce.MY = "";
            analysisAppliedPointForce.MZ = "";
            analysisAppliedPointForce.FX = "";
            analysisAppliedPointForce.FY = "";
            analysisAppliedPointForce.FZ = "";

            var analysisForceMomentOutputL = new AnalysisLocalForceMoments();
            analysisForceMomentOutputL.Description = "";
            analysisForceMomentOutputL.Id = "";
            analysisForceMomentOutputL.Name = "";
            analysisForceMomentOutputL.MX = "";
            analysisForceMomentOutputL.MY = "";
            analysisForceMomentOutputL.MZ = "";
            analysisForceMomentOutputL.FX = "";
            analysisForceMomentOutputL.FY = "";
            analysisForceMomentOutputL.FZ = "";

            var analysisForceMomentOutputG = new AnalysisGlobalForceMoments();
            analysisForceMomentOutputG.Description = "";
            analysisForceMomentOutputG.Id = "";
            analysisForceMomentOutputG.Name = "";
            analysisForceMomentOutputG.MX = "";
            analysisForceMomentOutputG.MY = "";
            analysisForceMomentOutputG.MZ = "";
            analysisForceMomentOutputG.FX = "";
            analysisForceMomentOutputG.FY = "";
            analysisForceMomentOutputG.FZ = "";
            analysisForceMomentOutputG.Shear = "";
            analysisForceMomentOutputG.Bending = "";
            analysisForceMomentOutputG.Axial = "";
            analysisForceMomentOutputG.Torsion = "";

            var analysisDisplacement = new AnalysisDisplacement();
            analysisDisplacement.Description = "";
            analysisDisplacement.Id = "";
            analysisDisplacement.Name = "";
            analysisDisplacement.DX = "";
            analysisDisplacement.DY = "";
            analysisDisplacement.DZ = "";
            analysisDisplacement.RX = "";
            analysisDisplacement.RY = "";
            analysisDisplacement.RZ = "";

            var analysisDisplacementOutput = new AnalysisDisplacementOutput();
            analysisDisplacementOutput.Description = "";
            analysisDisplacementOutput.Id = "";
            analysisDisplacementOutput.Name = "";
            analysisDisplacementOutput.DX = "";
            analysisDisplacementOutput.DY = "";
            analysisDisplacementOutput.DZ = "";
            analysisDisplacementOutput.RX = "";
            analysisDisplacementOutput.RY = "";
            analysisDisplacementOutput.RZ = "";

            var analysisHanger = new AnalysisHanger();
            analysisHanger.Description = "";
            analysisHanger.Id = "";
            analysisHanger.Name = "";
            analysisHanger.AnalysisHangerFreeRestaintAtNode = null;
            analysisHanger.AnalysisSupportToCAnalysisNode = null;
            analysisHanger.OwnsSupport = null;
            analysisHanger.AvailableSpace = "";
            analysisHanger.ColdLoad = false;
            analysisHanger.ExtendedRange = false;
            analysisHanger.FreeCodeType = null;
            analysisHanger.HangerTable = null;
            analysisHanger.HardwareWeight = "";
            analysisHanger.OperatingLoad = "";
            analysisHanger.HotLoadCentered = false;
            analysisHanger.LoadVariation = 0.0;
            analysisHanger.MaxTravelLimit = "";
            analysisHanger.MultiLoadCaseOption = null;
            analysisHanger.InputNumberofHangers = 0;
            analysisHanger.OperatingLoad = "";
            analysisHanger.RigidDisplacement = "";
            analysisHanger.ShortRangeSprings = false;
            analysisHanger.UserConstantLoad = "";
            analysisHanger.UserSpringRate = "";
            analysisHanger.UserColdLoad = "";

            var analysisRestraint = new AnalysisRestraint();
            analysisRestraint.Description = "";
            analysisRestraint.Id = "";
            analysisRestraint.Name = "";
            analysisRestraint.AnalysisSupportToCAnalysisNode = null;
            analysisRestraint.OwnsSupport = null;
            analysisRestraint.AngularGap = "";
            analysisRestraint.BiLinear2ndStiffnessK2 = "";
            analysisRestraint.BiLinearYieldLoadFy = "";
            analysisRestraint.BiRotational2ndStiffnessK2 = "";
            analysisRestraint.BiRotationalYieldMoment = "";
            analysisRestraint.BottomOutSpringF = "";
            analysisRestraint.BottomOutSpringx = "";
            analysisRestraint.FrictionCoefficient = 0;
            analysisRestraint.Gap = "";
            analysisRestraint.RestraintType = null;
            analysisRestraint.RodInitialLoadFi = "";
            analysisRestraint.RodLength = "";
            analysisRestraint.RotationalStiffness = "";
            analysisRestraint.ZDirectionCosine = 0;
            analysisRestraint.YDirectionCosine = 0;
            analysisRestraint.XDirectionCosine = 0;
            analysisRestraint.Stiffness = "";

            var analysisProcessInfoDataSet = new AnalysisProcessInfo();
            analysisProcessInfoDataSet.Description = "";
            analysisProcessInfoDataSet.Id = "";
            analysisProcessInfoDataSet.Name = "";
            analysisProcessInfoDataSet.AnalysisTemp = "";
            analysisProcessInfoDataSet.AnalysisPressure = "";
            analysisProcessInfoDataSet.AnalysisFluidDensity = "";
            analysisProcessInfoDataSet.AlphaDeltaT = "";
            
            #region A20-179-43
            var analysisSIFFitting = new AnalysisSIFFitting();
            analysisSIFFitting.Description = "";
            analysisSIFFitting.Id = "";
            analysisSIFFitting.Name = "";
            analysisSIFFitting.SurfaceNode = null;
            analysisSIFFitting.SIFOption1 = false;
            analysisSIFFitting.SIFOption2 = false;
            analysisSIFFitting.WeldStrFactWc = 0.0;
            analysisSIFFitting.PressureStressMultiplier = 0.0;
            analysisSIFFitting.ReinforcedType = 0;
            analysisSIFFitting.NumberOfFlanges = 0;
            analysisSIFFitting.FatigueClass = "";
            analysisSIFFitting.ReinforcedLength = "";
            analysisSIFFitting.ReinforcedAngleTheta = "";
            analysisSIFFitting.ReinforcedTaperLargeEnd = "";
            analysisSIFFitting.ReinforcedThickness = "";
            analysisSIFFitting.PadThickness = "";
            analysisSIFFitting.ReinforcedRadius = "";
            analysisSIFFitting.EffectiveBranchThickness = "";
            analysisSIFFitting.FittingOutsideRadius = "";
            analysisSIFFitting.FittingCrotchRadius = "";
            analysisSIFFitting.FittingCrotchThickness = "";
            analysisSIFFitting.EncirclementPadSaddleThickness = "";            
            analysisSIFFitting.HeaderFittingPipeOD = "";
            analysisSIFFitting.BranchReinforcedLength = "";
            analysisSIFFitting.BranchFittingPipeOD = "";
            analysisSIFFitting.FilletRadii1 = "";
            analysisSIFFitting.FilletRadii2 = "";
            analysisSIFFitting.FilletRadii3 = "";
            analysisSIFFitting.HeaderFittingWallThickness = "";
            analysisSIFFitting.Theta = "";
            analysisSIFFitting.BranchNominalWallThickness = "";
            analysisSIFFitting.BranchReinforcedNominalWallThickness = "";
            analysisSIFFitting.HeaderReinforcedHalfWidthLength = "";
            analysisSIFFitting.BranchReinforcedOrInfluenceHeight = "";

            var analysisSIFUserDefinedData = new AnalysisSIFUserDefinedData();
            analysisSIFUserDefinedData.ElasticModulusPrimitive = null;
            analysisSIFUserDefinedData.PressurePrimitive = null;
            analysisSIFUserDefinedData.InplaneIndex = 0;
            analysisSIFUserDefinedData.OutplaneIndex = 0;
            analysisSIFUserDefinedData.TorsionIndex = 0;
            analysisSIFUserDefinedData.AxialIndex = 0;
            analysisSIFUserDefinedData.PressureIndex = 0;
            analysisSIFUserDefinedData.InplaneSIF = 0;
            analysisSIFUserDefinedData.OutplaneSIF = 0;
            analysisSIFUserDefinedData.TorsionSIF = 0;
            analysisSIFUserDefinedData.AxialSIF = 0;
            analysisSIFUserDefinedData.PressureSIF = 0;
            analysisSIFUserDefinedData.InplaneFlexibility = 0;
            analysisSIFUserDefinedData.OutplaneFlexibility = 0;
            analysisSIFUserDefinedData.TorsionFlexibility = 0;
            analysisSIFUserDefinedData.AxialFlexibility = 0;
            analysisSIFUserDefinedData.PressureFlexibility = 0;

            var analysisSIFFittingOutput = new AnalysisSIFFittingOutput();
            analysisSIFFittingOutput.Description = "";
            analysisSIFFittingOutput.Id = "";
            analysisSIFFittingOutput.Name = "";
            analysisSIFFittingOutput.MeanDiameterMatchingPipe = "";
            analysisSIFFittingOutput.OutisdeDiameterMatchingPipe = "";
            analysisSIFFittingOutput.MeanRadiusMatchingPipe = "";
            analysisSIFFittingOutput.NominalWallThicknessMatchingPipe = "";
            analysisSIFFittingOutput.MeanDiameterMatchingBranchPipe = "";
            analysisSIFFittingOutput.OutisdeDiameterMatchingBranchPipe = "";
            analysisSIFFittingOutput.EffectiveBranchDiameterBranchReinforcement = "";
            analysisSIFFittingOutput.MeanRadiusMatchingBranchPipe = "";
            analysisSIFFittingOutput.NominalWallThicknessBranchPipe = "";
            analysisSIFFittingOutput.ReinforcementPadSaddleThichkness = "";
            analysisSIFFittingOutput.UserDefinedEffectiveBranchThicknessUsedBranchReinforcement = "";
            analysisSIFFittingOutput.CrotchThickness = "";
            analysisSIFFittingOutput.ExternalCrotchRadiusWeldingTee = "";
            analysisSIFFittingOutput.RadiusOutsideLegFitting = "";
            analysisSIFFittingOutput.LengthTaperThickerBranchSectionUsedBranchReinforcement = "";
            analysisSIFFittingOutput.RadiiBranchReinforcement = "";
            analysisSIFFittingOutput.LocalBranchThicknessBranchReinforcement = "";
            analysisSIFFittingOutput.LargeEndTaperBranchReinforcement = "";
            analysisSIFFittingOutput.ThetaAngleBranchReinforcement = "";

            var analysisSIFOutput = new AnalysisSIFOutput();
            analysisSIFOutput.Description = "";
            analysisSIFOutput.Id = "";
            analysisSIFOutput.Name = "";
            analysisSIFOutput.Composition = TeeComposition.Undefined;
            analysisSIFOutput.SIFFittingOutput = null;            
            analysisSIFOutput.ElasticModulusPrimitive = null;
            analysisSIFOutput.PressurePrimitive = null;
            analysisSIFOutput.InplaneIndex = 0;
            analysisSIFOutput.OutplaneIndex = 0;
            analysisSIFOutput.TorsionIndex = 0;
            analysisSIFOutput.AxialIndex = 0;
            analysisSIFOutput.PressureIndex = 0;
            analysisSIFOutput.InplaneSIF = 0;
            analysisSIFOutput.OutplaneSIF = 0;
            analysisSIFOutput.TorsionSIF = 0;
            analysisSIFOutput.AxialSIF = 0;
            analysisSIFOutput.PressureSIF = 0;
            analysisSIFOutput.InplaneFlexibility = 0;
            analysisSIFOutput.OutplaneFlexibility = 0;
            analysisSIFOutput.TorsionFlexibility = 0;
            analysisSIFOutput.AxialFlexibility = 0;
            analysisSIFOutput.PressureFlexibility = 0;            

            var analysisSpecialJoint = new AnalysisSpecialJoint();
            analysisSpecialJoint.Description = "";
            analysisSpecialJoint.Id = "";
            analysisSpecialJoint.Name = "";
            analysisSpecialJoint.SocketFilletLength = "";
            analysisSpecialJoint.MaximumCircumferentialWeldMismatch = "";
            analysisSpecialJoint.AverageCircumferentialWeldMismatch = "";
            analysisSpecialJoint.WeldStrFactWc = 0.0;
            #endregion        

            var analysisExpansionJoint = new AnalysisExpansionJoint();
            analysisExpansionJoint.Description = "";
            analysisExpansionJoint.Id = "";
            analysisExpansionJoint.Name = "";
            analysisExpansionJoint.AxialStiffness = "";
            analysisExpansionJoint.TransverseStiffness = "";
            analysisExpansionJoint.BendingStiffness = "";
            analysisExpansionJoint.TorsionalStiffness = "";
            analysisExpansionJoint.ElementType = AnalysisLineElementType.AnalysisExpansionJoint;

            var analysisRigid = new AnalysisRigid();
            analysisRigid.Description = "";
            analysisRigid.Id = "";
            analysisRigid.Name = "";
            analysisRigid.RigidType = null;
            analysisRigid.ElementType = AnalysisLineElementType.AnalysisRigid;

            #region NOZZLE FLEX
            var analysisNozzleFlexWRC297 = new AnalysisNozzleFlexWRC297();
            analysisNozzleFlexWRC297.AnalysisNozzleFlexToTankVesselNode = null;
            analysisNozzleFlexWRC297.CosX = 0.0;
            analysisNozzleFlexWRC297.CosY = 0.0;
            analysisNozzleFlexWRC297.CosZ = 0.0;
            analysisNozzleFlexWRC297.NozzleVesselOuterDiameter = "";
            analysisNozzleFlexWRC297.NozzleWallThickness = "";
            analysisNozzleFlexWRC297.TankVesselOuterDiameter = "";
            analysisNozzleFlexWRC297.TankVesselWallThickness = "";
            analysisNozzleFlexWRC297.TankVesselPadThickness = "";
            analysisNozzleFlexWRC297.TankVesselMaterial = "";
            analysisNozzleFlexWRC297.NozzleDistanceToStiffenerHead = "";
            analysisNozzleFlexWRC297.NozzleDistanceToOppositeStiffener = "";
            analysisNozzleFlexWRC297.VesselTemperature = "";

            var analysisNozzleFlexPD5500 = new AnalysisNozzleFlexPD5500();
            analysisNozzleFlexPD5500.AnalysisNozzleFlexToTankVesselNode = null;
            analysisNozzleFlexPD5500.CosX = 0.0;
            analysisNozzleFlexPD5500.CosY = 0.0;
            analysisNozzleFlexPD5500.CosZ = 0.0;
            analysisNozzleFlexPD5500.NozzleVesselOuterDiameter = "";
            analysisNozzleFlexPD5500.NozzleWallThickness = "";
            analysisNozzleFlexPD5500.TankVesselOuterDiameter = "";
            analysisNozzleFlexPD5500.TankVesselWallThickness = "";
            analysisNozzleFlexPD5500.TankVesselPadThickness = "";
            analysisNozzleFlexPD5500.TankVesselMaterial = "";
            analysisNozzleFlexPD5500.NozzleDistanceToStiffenerHead = "";
            analysisNozzleFlexPD5500.NozzleDistanceToOppositeStiffener = "";
            analysisNozzleFlexPD5500.VesselTemperature = "";
            analysisNozzleFlexPD5500.VesselType = null;

            var analysisNozzleFlexAPI650 = new AnalysisNozzleFlexAPI650();
            analysisNozzleFlexAPI650.AnalysisNozzleFlexToTankVesselNode = null;
            analysisNozzleFlexAPI650.CosX = 0.0;
            analysisNozzleFlexAPI650.CosY = 0.0;
            analysisNozzleFlexAPI650.CosZ = 0.0;
            analysisNozzleFlexAPI650.NozzleVesselOuterDiameter = "";
            analysisNozzleFlexAPI650.NozzleWallThickness = "";
            analysisNozzleFlexAPI650.TankVesselOuterDiameter = "";
            analysisNozzleFlexAPI650.TankVesselWallThickness = "";
            analysisNozzleFlexAPI650.TankVesselPadThickness = "";
            analysisNozzleFlexAPI650.TankVesselMaterial = "";
            analysisNozzleFlexAPI650.AnalysisDisplacementPrimitive = null;
            analysisNozzleFlexAPI650.NozzleDistanceToTank = "";
            analysisNozzleFlexAPI650.NozzleReinforcingType = null;
            analysisNozzleFlexAPI650.TankModulusOfElasticity = "";
            analysisNozzleFlexAPI650.TankCoefficientOfThermalExpansion = "";
            analysisNozzleFlexAPI650.TankTemperatureChange = "";
            analysisNozzleFlexAPI650.TankFluidHeight = "";
            analysisNozzleFlexAPI650.TankFluidStandardOfGravity = 0.0;

            var analysisNozzleFlexCustom = new AnalysisNozzleFlexCustom();
            analysisNozzleFlexCustom.AnalysisNozzleFlexToTankVesselNode = null;
            analysisNozzleFlexCustom.CosX = 0.0;
            analysisNozzleFlexCustom.CosY = 0.0;
            analysisNozzleFlexCustom.CosZ = 0.0;
            analysisNozzleFlexCustom.NozzleVesselOuterDiameter = "";
            analysisNozzleFlexCustom.NozzleWallThickness = "";
            analysisNozzleFlexCustom.TankVesselOuterDiameter = "";
            analysisNozzleFlexCustom.TankVesselWallThickness = "";
            analysisNozzleFlexCustom.TankVesselPadThickness = "";
            analysisNozzleFlexCustom.TankVesselMaterial = "";
            analysisNozzleFlexCustom.NozzleAxial = "";
            analysisNozzleFlexCustom.NozzleTorsional = "";
            analysisNozzleFlexCustom.InPlaneBending = "";
            analysisNozzleFlexCustom.OutPlaneBending = "";
            #endregion

            var analysisLoadCasePrimitive = new AnalysisLoadCasePrimitive();
            analysisLoadCasePrimitive.Description = "";
            analysisLoadCasePrimitive.Id = "";
            analysisLoadCasePrimitive.Name = "";
            analysisLoadCasePrimitive.Number = 0;
            analysisLoadCasePrimitive.LoadCase = null;

            var uniformLoadDataSetG = new AnalysisUniformLoadDataSet(true);
            uniformLoadDataSetG.Description = "";
            uniformLoadDataSetG.Id = "";
            uniformLoadDataSetG.Name = "";

            var uniformLoadDataSet = new AnalysisUniformLoadDataSet();
            uniformLoadDataSet.Description = "";
            uniformLoadDataSet.Id = "";
            uniformLoadDataSet.Name = "";


            var analysisGlobalRestraintReaction = new AnalysisGlobalRestraintReaction();
            analysisGlobalRestraintReaction.Description = "";
            analysisGlobalRestraintReaction.Id = "";
            analysisGlobalRestraintReaction.Name = "";
            analysisGlobalRestraintReaction.MX = "";
            analysisGlobalRestraintReaction.MY = "";
            analysisGlobalRestraintReaction.MZ = "";
            analysisGlobalRestraintReaction.FX = "";
            analysisGlobalRestraintReaction.FY = "";
            analysisGlobalRestraintReaction.FZ = "";
            analysisGlobalRestraintReaction.ResultantForce = "";
            analysisGlobalRestraintReaction.ResultantMoment = "";

            var analysisLocalRestraintReaction = new AnalysisLocalRestraintReaction();
            analysisLocalRestraintReaction.Description = "";
            analysisLocalRestraintReaction.Id = "";
            analysisLocalRestraintReaction.Name = "";
            analysisLocalRestraintReaction.MX = "";
            analysisLocalRestraintReaction.MY = "";
            analysisLocalRestraintReaction.MZ = "";
            analysisLocalRestraintReaction.FX = "";
            analysisLocalRestraintReaction.FY = "";
            analysisLocalRestraintReaction.FZ = "";

            var analysisFlangeCheckASME = new AnalysisFlangeCheckNC();
            analysisFlangeCheckASME.Description = "";
            analysisFlangeCheckASME.Id = "";
            analysisFlangeCheckASME.Name = "";
            analysisFlangeCheckASME.BoltArea = "";
            analysisFlangeCheckASME.BoltCircleDiameter = "";

            var analysisFlangeCheckKellogg = new AnalysisFlangeCheckPeq();
            analysisFlangeCheckKellogg.Description = "";
            analysisFlangeCheckKellogg.Id = "";
            analysisFlangeCheckKellogg.Name = "";
            analysisFlangeCheckKellogg.GasketDiameter = "";

            var analysisFlangeCheckPressureRating = new AnalysisFlangeCheckPressureRating();
            analysisFlangeCheckPressureRating.Description = "";
            analysisFlangeCheckPressureRating.Id = "";
            analysisFlangeCheckPressureRating.Name = "";
            analysisFlangeCheckPressureRating.Temperature = "";
            analysisFlangeCheckPressureRating.PressureRating = "";

            var analysisFlangeCheckYieldStrength = new AnalysisFlangeCheckYieldStrength();
            analysisFlangeCheckYieldStrength.Description = "";
            analysisFlangeCheckYieldStrength.Id = "";
            analysisFlangeCheckYieldStrength.Name = "";
            analysisFlangeCheckYieldStrength.VectorNumber = 0;
            analysisFlangeCheckYieldStrength.YieldStrength = "";

            var analysisNozzleLimitCheck = new AnalysisNozzleLimitCheck();
            analysisNozzleLimitCheck.Description = "";
            analysisNozzleLimitCheck.Id = "";
            analysisNozzleLimitCheck.Name = "";
            analysisNozzleLimitCheck.ComparisonMethod = null;
            analysisNozzleLimitCheck.RefVectorX = 0.0;
            analysisNozzleLimitCheck.RefVectorY = 0.0;
            analysisNozzleLimitCheck.RefVectorZ = 0.0;
            analysisNozzleLimitCheck.LocalForceA = "";
            analysisNozzleLimitCheck.LocalForceB = "";
            analysisNozzleLimitCheck.LocalForceC = "";
            analysisNozzleLimitCheck.LocalMomentA = "";
            analysisNozzleLimitCheck.LocalMomentB = "";
            analysisNozzleLimitCheck.LocalMomentC = "";

            var analysisPipePropertyDataSet = new AnalysisPipeProperty();
            analysisPipePropertyDataSet.Description = "";
            analysisPipePropertyDataSet.Id = "";
            analysisPipePropertyDataSet.Name = "";
            analysisPipePropertyDataSet.SeamWelded = false;
            analysisPipePropertyDataSet.WIFactor = 0.0;
            analysisPipePropertyDataSet.OvalityAllowance = 0.0;
            analysisPipePropertyDataSet.PositiveMillTolerance = 0.0;
            analysisPipePropertyDataSet.NegativeMillTolerance = 0.0;
            analysisPipePropertyDataSet.TVarAllowance = 0.0;
            analysisPipePropertyDataSet.Corrosion = "";

            var analysisModelOrganization = new AnalysisModelOrganization();
            analysisModelOrganization.Description = "";
            analysisModelOrganization.Id = "";
            analysisModelOrganization.Name = "";
            analysisModelOrganization.CAESARIILineNumber = "";
            analysisModelOrganization.Visibility = 0.0;

            #region MATERIAL ALLOWABLES
            var analysisMaterialAllowableASME = new AnalysisMaterialAllowableASME();
            analysisMaterialAllowableASME.Description = "";
            analysisMaterialAllowableASME.Id = "";
            analysisMaterialAllowableASME.Name = "";
            analysisMaterialAllowableASME.Pvar = "";
            analysisMaterialAllowableASME.Sy = "";

            var analysisMaterialAllowableB31 = new AnalysisMaterialAllowableB31();
            analysisMaterialAllowableB31.Description = "";
            analysisMaterialAllowableB31.Id = "";
            analysisMaterialAllowableB31.Name = "";
            analysisMaterialAllowableB31.Eff = 0.0;
            analysisMaterialAllowableB31.MinimumWallThicknessCalculation = 0.0;
            analysisMaterialAllowableB31.DesignFactor = null;
            analysisMaterialAllowableB31.HoopStressFactor = 0.0;
            analysisMaterialAllowableB31.AllowableStressIndicator = null;
            analysisMaterialAllowableB31.Fac = 0.0;
            analysisMaterialAllowableB31.Sy = "";
            analysisMaterialAllowableB31.SpecifiedMinimumYieldStress = "";
            analysisMaterialAllowableB31.CoefficientY = 0.0;
            analysisMaterialAllowableB31.DesignFactorF = 0.0;
            analysisMaterialAllowableB31.AllowMaximumStressRangeFactor = null;

            var analysisMaterialAllowableBS7159 = new AnalysisMaterialAllowableBS7159();
            analysisMaterialAllowableBS7159.Description = "";
            analysisMaterialAllowableBS7159.Id = "";
            analysisMaterialAllowableBS7159.Name = "";
            analysisMaterialAllowableBS7159.MaterialName = "";
            analysisMaterialAllowableBS7159.PoissonsRatio = 0.0;
            analysisMaterialAllowableBS7159.RatioHoopModulusAxialElasticityModulus = 0.0;
            analysisMaterialAllowableBS7159.MeanTemperatureChangeMultiplier = 0.0;

            var analysisMaterialAllowableBS806 = new AnalysisMaterialAllowableBS806();
            analysisMaterialAllowableBS806.Description = "";
            analysisMaterialAllowableBS806.Id = "";
            analysisMaterialAllowableBS806.Name = "";
            analysisMaterialAllowableBS806.MaterialName = "";
            analysisMaterialAllowableBS806.PoissonsRatio = 0.0;
            analysisMaterialAllowableBS806.FactorForMinimumWallThickness = 0.0;
            analysisMaterialAllowableBS806.SustainedStressLimit = "";

            var analysisMaterialAllowableCANZ662 = new AnalysisMaterialAllowableCANZ662();
            analysisMaterialAllowableCANZ662.Description = "";
            analysisMaterialAllowableCANZ662.Id = "";
            analysisMaterialAllowableCANZ662.Name = "";
            analysisMaterialAllowableCANZ662.MaterialName = "";
            analysisMaterialAllowableCANZ662.PoissonsRatio = 0.0;
            analysisMaterialAllowableCANZ662.LocationFactor = 0.0;
            analysisMaterialAllowableCANZ662.TemperatureDeratingFactor = 0.0;
            analysisMaterialAllowableCANZ662.ConditionADesignFactor = 0.0;
            analysisMaterialAllowableCANZ662.ConditionBDesignFactor = 0.0;
            analysisMaterialAllowableCANZ662.LongitudinalWeldJointEfficiency = 0.0;
            analysisMaterialAllowableCANZ662.RestrainedFactor = 0.0;
            analysisMaterialAllowableCANZ662.MinimumYieldStrength = 0.0;

            var analysisMaterialAllowableCODETI = new AnalysisMaterialAllowableCODETI();
            analysisMaterialAllowableCODETI.Description = "";
            analysisMaterialAllowableCODETI.Id = "";
            analysisMaterialAllowableCODETI.Name = "";
            analysisMaterialAllowableCODETI.MaterialName = "";
            analysisMaterialAllowableCODETI.PoissonsRatio = 0.0;
            analysisMaterialAllowableCODETI.LongitudinalWeldJointEfficiency = 0.0;
            analysisMaterialAllowableCODETI.HydroTestAllowablePressure = "";            
            analysisMaterialAllowableCODETI.ElementID = "";
                        
            var analysisMaterialAllowableDNV = new AnalysisMaterialAllowableDNV();
            analysisMaterialAllowableDNV.Description = "";
            analysisMaterialAllowableDNV.Id = "";
            analysisMaterialAllowableDNV.Name = "";
            analysisMaterialAllowableDNV.MaterialName = "";
            analysisMaterialAllowableDNV.PoissonsRatio = 0.0;
            analysisMaterialAllowableDNV.PressureYieldingUsageFactor = 0.0;
            analysisMaterialAllowableDNV.PressureBurstingUsageFactor = 0.0;
            analysisMaterialAllowableDNV.EquivalentStressCheckUsageFactor = 0.0;
            analysisMaterialAllowableDNV.SupplementaryRequirement = false;
            analysisMaterialAllowableDNV.MaterialLuderPlateau = false;
            analysisMaterialAllowableDNV.StrainHardeningFactor = 0.0;
            analysisMaterialAllowableDNV.FabricationStringResisteanceFactor = 0.0;
            analysisMaterialAllowableDNV.BurstFailureOperation = "";
            analysisMaterialAllowableDNV.BurstFailureTesing = "";
            analysisMaterialAllowableDNV.CollapseFailure = "";
            analysisMaterialAllowableDNV.PropagationBuckling = "";
            analysisMaterialAllowableDNV.LoadControlCondition = "";
            analysisMaterialAllowableDNV.DisplacementControlledCondition = "";
            analysisMaterialAllowableDNV.LoadEffectFactor = 0.0;
            analysisMaterialAllowableDNV.GirthWeldStrainResisteanceFactor = 0.0;
            analysisMaterialAllowableDNV.ReactionForce = "";
            analysisMaterialAllowableDNV.PressureYieldingUsageFactor = 0.0;
            analysisMaterialAllowableDNV.PressureBurstingUsageFactor = 0.0;
            analysisMaterialAllowableDNV.EquivalentStressCheckUsageFactor = 0.0;

            var analysisMaterialAllowableFDBR = new AnalysisMaterialAllowableFDBR();
            analysisMaterialAllowableFDBR.Description = "";
            analysisMaterialAllowableFDBR.Id = "";
            analysisMaterialAllowableFDBR.Name = "";
            analysisMaterialAllowableFDBR.MaterialName = "";
            analysisMaterialAllowableFDBR.PoissonsRatio = 0.0;
            analysisMaterialAllowableFDBR.LongitudinalWeldJointEfficiency = 0.0;
            analysisMaterialAllowableFDBR.ElasticModulusRatio = 0.0;
            analysisMaterialAllowableFDBR.HydroTestAllowable = "";

            var analysisMaterialAllowableGPTCZ380 = new AnalysisMaterialAllowableGPTCZ380();
            analysisMaterialAllowableGPTCZ380.Description = "";
            analysisMaterialAllowableGPTCZ380.Id = "";
            analysisMaterialAllowableGPTCZ380.Name = "";
            analysisMaterialAllowableGPTCZ380.MaterialName = "";
            analysisMaterialAllowableGPTCZ380.PoissonsRatio = 0.0;
            analysisMaterialAllowableGPTCZ380.LongitudinalWeldJointEfficiency = 0.0;
            analysisMaterialAllowableGPTCZ380.ConstructionDesignFactor = 0.0;
            analysisMaterialAllowableGPTCZ380.MinimumYieldStress = "";

            var analysisMaterialAllowableHPSGL = new AnalysisMaterialAllowableHPSGL();
            analysisMaterialAllowableHPSGL.Description = "";
            analysisMaterialAllowableHPSGL.Id = "";
            analysisMaterialAllowableHPSGL.Name = "";
            analysisMaterialAllowableHPSGL.MaterialName = "";
            analysisMaterialAllowableHPSGL.PoissonsRatio = 0.0;
            analysisMaterialAllowableHPSGL.LongitudinaWeldJointEfficiency = 0.0;
            analysisMaterialAllowableHPSGL.CompositionType = "";            

            var analysisMaterialAllowableISO146922005 = new AnalysisMaterialAllowableISO146922005();
            analysisMaterialAllowableISO146922005.Description = "";
            analysisMaterialAllowableISO146922005.Id = "";
            analysisMaterialAllowableISO146922005.Name = "";
            analysisMaterialAllowableISO146922005.MaterialName = "";
            analysisMaterialAllowableISO146922005.PoissonsRatio = 0.0;
            analysisMaterialAllowableISO146922005.LongTermAxialStressRatio01 = "";
            analysisMaterialAllowableISO146922005.LongTermAxialStressRatio11 = "";
            analysisMaterialAllowableISO146922005.LongTermHoopStressRatio11 = "";
            analysisMaterialAllowableISO146922005.LongTermAxialStressRatio21 = "";
            analysisMaterialAllowableISO146922005.LongTermHoopStressRatio21 = "";
            analysisMaterialAllowableISO146922005.QualifiedStressJoint = "";
            analysisMaterialAllowableISO146922005.BiAxialStressRatioJoint = 0.0;
            analysisMaterialAllowableISO146922005.QualifiedStressTee = "";
            analysisMaterialAllowableISO146922005.QualifiedStressBend = "";
            analysisMaterialAllowableISO146922005.BiAxialStressRatioBend = 0.0;
            analysisMaterialAllowableISO146922005.HoopModulusAxialModulusOfElasticity = 0.0;
            analysisMaterialAllowableISO146922005.HandLay = false;
            analysisMaterialAllowableISO146922005.ChemicalResistancePartialFactor = 0.0;
            analysisMaterialAllowableISO146922005.CyclicServicePartialFactor = 0.0;
            analysisMaterialAllowableISO146922005.SystemDesignFactor = 0.0;
            analysisMaterialAllowableISO146922005.ThermalFactor = 0.0;

            var analysisMaterialAllowableISO146922017 = new AnalysisMaterialAllowableISO146922017();
            analysisMaterialAllowableISO146922017.Description = "";
            analysisMaterialAllowableISO146922017.Id = "";
            analysisMaterialAllowableISO146922017.Name = "";
            analysisMaterialAllowableISO146922017.MaterialName = "";
            analysisMaterialAllowableISO146922017.PoissonsRatio = 0.0;
            analysisMaterialAllowableISO146922017.LongTermAxialStressRatio01 = "";
            analysisMaterialAllowableISO146922017.LongTermAxialStressPartiallyRestrainedHydraulic = "";
            analysisMaterialAllowableISO146922017.LongTermHoopStressPartiallyRestrainedHydraulic = "";
            analysisMaterialAllowableISO146922017.LongTermAxialStressRatio21 = "";
            analysisMaterialAllowableISO146922017.LongTermHoopStressRatio21 = "";
            analysisMaterialAllowableISO146922017.DesignLifetimeFactor = 0.0;
            analysisMaterialAllowableISO146922017.ChemicalResistancePartialFactor = 0.0;
            analysisMaterialAllowableISO146922017.CyclicServicePartialFactor = 0.0;
            analysisMaterialAllowableISO146922017.SystemDesignFactor = 0.0;
            analysisMaterialAllowableISO146922017.HoopModulusAxialModulusOfElasticity = 0.0;
            analysisMaterialAllowableISO146922017.CurveRadius = "";
            analysisMaterialAllowableISO146922017.Buried = false;
            analysisMaterialAllowableISO146922017.HoopBendingModulus = "";
            analysisMaterialAllowableISO146922017.ShapeFactorPipeZoneEmbedment = "";
            analysisMaterialAllowableISO146922017.VerticalPipeDeflection = "";
            analysisMaterialAllowableISO146922017.PipeRestrainedStatus = "";            

            var analysisMaterialAllowableJPI = new AnalysisMaterialAllowableJPI();
            analysisMaterialAllowableJPI.Description = "";
            analysisMaterialAllowableJPI.Id = "";
            analysisMaterialAllowableJPI.Name = "";
            analysisMaterialAllowableJPI.MaterialName = "";
            analysisMaterialAllowableJPI.PoissonsRatio = 0.0;
            analysisMaterialAllowableJPI.LongitudinaWeldJointEfficiency = 0.0;
            analysisMaterialAllowableJPI.CompositionType = "";

            var analysisMaterialAllowableNavy505 = new AnalysisMaterialAllowableNavy505();
            analysisMaterialAllowableNavy505.Description = "";
            analysisMaterialAllowableNavy505.Id = "";
            analysisMaterialAllowableNavy505.Name = "";
            analysisMaterialAllowableNavy505.MaterialName = "";
            analysisMaterialAllowableNavy505.PoissonsRatio = 0.0;
            analysisMaterialAllowableNavy505.FactorForMinimumWallThickness = 0.0;

            var analysisMaterialAllowableNorwegianTBK6 = new AnalysisMaterialAllowableNorwegianTBK6();
            analysisMaterialAllowableNorwegianTBK6.Description = "";
            analysisMaterialAllowableNorwegianTBK6.Id = "";
            analysisMaterialAllowableNorwegianTBK6.Name = "";
            analysisMaterialAllowableNorwegianTBK6.MaterialName = "";
            analysisMaterialAllowableNorwegianTBK6.PoissonsRatio = 0.0;
            analysisMaterialAllowableNorwegianTBK6.CircumferentialJointFactor = 0.0;
            analysisMaterialAllowableNorwegianTBK6.AllowableStress7000LoadCycles = 0.0;
            analysisMaterialAllowableNorwegianTBK6.UltimateTensileStrength = "";

            var analysisMaterialAllowablePD8010 = new AnalysisMaterialAllowablePD8010();
            analysisMaterialAllowablePD8010.Description = "";
            analysisMaterialAllowablePD8010.Id = "";
            analysisMaterialAllowablePD8010.Name = "";
            analysisMaterialAllowablePD8010.MaterialName = "";
            analysisMaterialAllowablePD8010.PoissonsRatio = 0.0;
            analysisMaterialAllowablePD8010.WeldJointFactor = 0.0;
            analysisMaterialAllowablePD8010.RestrainedFactor = 0.0;
            analysisMaterialAllowablePD8010.MinimumYieldStress = "";
            analysisMaterialAllowablePD8010.DesignFactor = 0.0;
            analysisMaterialAllowablePD8010.DesignFactorTable2 = 0.0;

            var analysisMaterialAllowableRCCMCD = new AnalysisMaterialAllowableRCCMCD();
            analysisMaterialAllowableRCCMCD.Description = "";
            analysisMaterialAllowableRCCMCD.Id = "";
            analysisMaterialAllowableRCCMCD.Name = "";
            analysisMaterialAllowableRCCMCD.MaterialName = "";
            analysisMaterialAllowableRCCMCD.PoissonsRatio = 0.0;
            analysisMaterialAllowableRCCMCD.DifferenceOperatingPeakPressure = "";
            analysisMaterialAllowableRCCMCD.HydroTestAllowablePressure = "";

            var analysisMaterialAllowableStoomwezen = new AnalysisMaterialAllowableStoomwezen();
            analysisMaterialAllowableStoomwezen.Description = "";
            analysisMaterialAllowableStoomwezen.Id = "";
            analysisMaterialAllowableStoomwezen.Name = "";
            analysisMaterialAllowableStoomwezen.MaterialName = "";
            analysisMaterialAllowableStoomwezen.PoissonsRatio = 0.0;
            analysisMaterialAllowableStoomwezen.ElementID = "";
            analysisMaterialAllowableStoomwezen.AverageCreepStress = "";
            analysisMaterialAllowableStoomwezen.AverageCreepTensileStress = "";
            analysisMaterialAllowableStoomwezen.MinimumCreepTensileStress = "";
            analysisMaterialAllowableStoomwezen.YieldStressDesignTemperature = "";
            analysisMaterialAllowableStoomwezen.CyclicReductionFactor = 0.0;
            analysisMaterialAllowableStoomwezen.StoomwezenConstant = 0.0;
            analysisMaterialAllowableStoomwezen.CoefficientCM = 0.0;
            analysisMaterialAllowableStoomwezen.TensileStrength = "";

            var analysisMaterialAllowableSwedishPowerCodeMethod1 = new AnalysisMaterialAllowableSwedishPowerCodeMethod1();
            analysisMaterialAllowableSwedishPowerCodeMethod1.Description = "";
            analysisMaterialAllowableSwedishPowerCodeMethod1.Id = "";
            analysisMaterialAllowableSwedishPowerCodeMethod1.Name = "";
            analysisMaterialAllowableSwedishPowerCodeMethod1.MaterialName = "";
            analysisMaterialAllowableSwedishPowerCodeMethod1.PoissonsRatio = 0.0;
            analysisMaterialAllowableSwedishPowerCodeMethod1.CircumferentialJointFactor = 0.0;
            analysisMaterialAllowableSwedishPowerCodeMethod1.StigmaMultiplier = 0.0;
            analysisMaterialAllowableSwedishPowerCodeMethod1.BetaSeffCalculation = 0.0;

            var analysisMaterialAllowableSwedishPowerCodeMethod2 = new AnalysisMaterialAllowableSwedishPowerCodeMethod2();
            analysisMaterialAllowableSwedishPowerCodeMethod2.Description = "";
            analysisMaterialAllowableSwedishPowerCodeMethod2.Id = "";
            analysisMaterialAllowableSwedishPowerCodeMethod2.Name = "";
            analysisMaterialAllowableSwedishPowerCodeMethod2.MaterialName = "";
            analysisMaterialAllowableSwedishPowerCodeMethod2.PoissonsRatio = 0.0;
            analysisMaterialAllowableSwedishPowerCodeMethod2.CircumferentialJointFactor = 0.0;
            analysisMaterialAllowableSwedishPowerCodeMethod2.UltimateTensileStrength = "";
            analysisMaterialAllowableSwedishPowerCodeMethod2.BetaSeffCalculation = 0.0;

            var analysisMaterialAllowableTD12 = new AnalysisMaterialAllowableTD12();
            analysisMaterialAllowableTD12.Description = "";
            analysisMaterialAllowableTD12.Id = "";
            analysisMaterialAllowableTD12.Name = "";
            analysisMaterialAllowableTD12.MaterialName = "";
            analysisMaterialAllowableTD12.PoissonsRatio = 0.0;
            analysisMaterialAllowableTD12.SystemDesignFactor = 0.0;
            analysisMaterialAllowableTD12.MaterialShakedownFactor = 0.0;

            var analysisMaterialAllowableUKOOA = new AnalysisMaterialAllowableUKOOA();
            analysisMaterialAllowableUKOOA.Description = "";
            analysisMaterialAllowableUKOOA.Id = "";
            analysisMaterialAllowableUKOOA.Name = "";
            analysisMaterialAllowableUKOOA.MaterialName = "";
            analysisMaterialAllowableUKOOA.PoissonsRatio = 0.0;
            analysisMaterialAllowableUKOOA.SystemDesignFactor_f2 = 0.0;
            analysisMaterialAllowableUKOOA.MeanTemperatureChangeMultiplier_K = 0.0;

            var analysisMaterialDataSet = new AnalysisMaterialAllowableDataSet();
            analysisMaterialDataSet.Description = "";
            analysisMaterialDataSet.Id = "";
            analysisMaterialDataSet.Name = "";
            analysisMaterialDataSet.ThermalExpansion = 0.0;
            analysisMaterialDataSet.ElasticModulus = "";
            analysisMaterialDataSet.AllowableStress = "";
            analysisMaterialDataSet.CyclicStressRangeReduction = 0.0;
            analysisMaterialDataSet.TemperatureDeratingFactor = 0.0;
            analysisMaterialDataSet.FatigueFactor = 0.0;

            var analysisMaterialFatigueDataSet = new AnalysisMaterialFatigueDataSet();
            analysisMaterialFatigueDataSet.Description = "";
            analysisMaterialFatigueDataSet.Id = "";
            analysisMaterialFatigueDataSet.Name = "";
            analysisMaterialFatigueDataSet.Cycles = 0;
            analysisMaterialFatigueDataSet.Stress = "";
            #endregion

            var analysisHangerReport = new AnalysisHangerOutput();
            analysisHangerReport.Description = "";
            analysisHangerReport.Id = "";
            analysisHangerReport.Name = "";
            analysisHangerReport.Manufacturer = "";
            analysisHangerReport.Figure = "";
            analysisHangerReport.Size = 0;
            analysisHangerReport.VerticalMovement = "";
            analysisHangerReport.HorizontalMovement = "";
            analysisHangerReport.UserSpringRate = "";
            analysisHangerReport.OperatingLoad = "";
            analysisHangerReport.TheoreticalInstalledLoad = "";
            analysisHangerReport.ActualInstalledLoad = "";
            analysisHangerReport.LoadVariation = 0.0;

            var analysisReportOutputMDMT = new AnalysisMDMTReport();
            analysisReportOutputMDMT.Description = "";
            analysisReportOutputMDMT.Id = "";
            analysisReportOutputMDMT.Name = "";
            analysisReportOutputMDMT.PipeThickness = "";
            analysisReportOutputMDMT.MaterialID = 0;
            analysisReportOutputMDMT.Curve = "";
            analysisReportOutputMDMT.PipingCode = PipingCode.UNDEFINED;
            analysisReportOutputMDMT.MinimumTemperature = "";
            analysisReportOutputMDMT.BaseMDMT = "";
            analysisReportOutputMDMT.StressRatio = 0.0;
            analysisReportOutputMDMT.Reduction = "";
            analysisReportOutputMDMT.FinalMDMT = "";
            analysisReportOutputMDMT.Status = 0;

            var analysisSubBend = new   AnalysisSubBend();
            analysisSubBend.Description = "";
            analysisSubBend.Id = "";
            analysisSubBend.Name = "";
            analysisSubBend.ElementType = AnalysisLineElementType.AnalysisSubBend;
            analysisSubBend.Tangent1XSiValue = 0.0;
            analysisSubBend.Tangent1YSiValue = 0.0;
            analysisSubBend.Tangent1ZSiValue = 0.0;
            analysisSubBend.Tangent2XSiValue = 0.0;
            analysisSubBend.Tangent2YSiValue = 0.0;
            analysisSubBend.Tangent2ZSiValue = 0.0;
        }
    }
}
