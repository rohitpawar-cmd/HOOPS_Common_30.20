using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases.ASCE7;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase.WindLoadCase.WindCases.IBC;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs.NozzleFlex;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using System;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Reports;
namespace Hexagon.ALI.Analysis.Common.Classes
{
    // TODO: Consider eliminating separate enum for EntityType. Use typeOf(Entity) instead.

    public class SIOFactory
    {
        public enum DEFUID
        {
            AnalysisAppliedPointForce,
            AnalysisAppliedPointForcePrimitive,
            AnalysisBend,
            AnalysisComponentStressOutput,
            AnalysisDensities,
            AnalysisDisplacement,
            AnalysisDisplacementOutput,
            AnalysisDisplacementPrimitive,
            AnalysisDNVComponentsOutput,
            AnalysisDNVDetailsOutput,
            AnalysisDNVThicknessOutput,
            AnalysisElementOffset,
            AnalysisExpansionJoint,
            AnalysisFlangeCheckNC,
            AnalysisFlangeCheckNCOutput,
            AnalysisFlangeCheckPeq,
            AnalysisFlangeCheckPeqOutput,
            AnalysisFlangeCheckPressureRating,
            AnalysisFlangeCheckYieldStrength,
            AnalysisGlobalForceMoments,
            AnalysisGlobalRestraintReaction,
            AnalysisHanger,
            AnalysisHangerOutput,
            AnalysisLineElementComponentStressesOutput,
            AnalysisLineElementDNVOutput,
            AnalysisLineElementFlangeOutput,
            AnalysisLineElementForceMomentOutput,
            AnalysisLineElementStressesOutput,
            AnalysisLoadCase,
            AnalysisLoadCaseComponent,
            AnalysisLoadCaseDefinition,
            AnalysisLoadCasePrimitive,
            AnalysisLocalForceMoments,
            AnalysisLocalRestraintReaction,
            AnalysisMaterial,
            AnalysisMaterialAllowable,
            AnalysisMaterialAllowableASME,
            AnalysisMaterialAllowableB31,
            AnalysisMaterialAllowableBS7159,
            AnalysisMaterialAllowableBS806,
            AnalysisMaterialAllowableCANZ662,
            AnalysisMaterialAllowableCODETI,
            AnalysisMaterialAllowableDataSet,
            AnalysisMaterialAllowableDNV,
            AnalysisMaterialAllowableEN,
            AnalysisMaterialAllowableFDBR,
            AnalysisMaterialAllowableGPTCZ380,
            AnalysisMaterialAllowableHPSGL,
            AnalysisMaterialAllowableISO146922005,
            AnalysisMaterialAllowableISO146922017,
            AnalysisMaterialAllowableJPI,
            AnalysisMaterialAllowableNavy505,
            AnalysisMaterialAllowableNorwegianTBK6,
            AnalysisMaterialAllowablePD8010,
            AnalysisMaterialAllowableRCCMCD,
            AnalysisMaterialAllowableStoomwezen,
            AnalysisMaterialAllowableSwedishPowerCodeMethod1,
            AnalysisMaterialAllowableSwedishPowerCodeMethod2,
            AnalysisMaterialAllowableTD12,
            AnalysisMaterialAllowableUKOOA,
            AnalysisMaterialFatigueDataSet,
            AnalysisMaterialPrimitive,
            AnalysisModelOrganization,
            AnalysisNode,
            AnalysisGlobalCoordinate,
            AnalysisNozzleFlexAPI650,
            AnalysisNozzleFlexCustom,
            AnalysisNozzleFlexPD5500,
            AnalysisNozzleFlexWRC297,
            AnalysisNozzleLimitCheck,
            AnalysisNozzleLimitCheckOutput,
            AnalysisOperatingCondition,
            AnalysisOperatingPrimitive,
            AnalysisPipe,
            AnalysisPipeProperty,
            AnalysisProcessInfo,
            AnalysisReducer,
            AnalysisRestraint,
            AnalysisRigid,
            AnalysisSIFFitting,
            AnalysisSIFFittingOutput,
            AnalysisSIFNoTee,
            AnalysisSIFOutput,
            AnalysisSIFUserDefinedData,
            AnalysisSpecialJoint,
            AnalysisSubBend,
            AnalysisUniformLoadDataSet,
            AnalysisUniformLoadPrimitive,
            AnalysisWave,
            AnalysisWaveLoad,
            AnalysisWind,
            AnalysisWindCaseASCE7_2005,
            AnalysisWindCaseASCE7_2010,
            AnalysisWindCaseASCE7_2016,
            AnalysisWindCaseASCE7_2022,
            AnalysisWindCaseAustralia1170_2002,
            AnalysisWindCaseBrazilNBR6123_1988,
            AnalysisWindCaseBS6399_1997,
            AnalysisWindCaseChinaGB50009_2002,
            AnalysisWindCaseChinaGB50009_2012,
            AnalysisWindCaseEurope1991_2005,
            AnalysisWindCaseIBC_2006,
            AnalysisWindCaseIBC_2012,
            AnalysisWindCaseIBC_2018,
            AnalysisWindCaseIBC_2021,
            AnalysisWindCaseIBC_2024,
            AnalysisWindCaseIS875_1998,
            AnalysisWindCaseMexico_1993,
            AnalysisWindCaseNBC_2005,
            AnalysisWindCaseNBC_2015,
            AnalysisWindCasePressureVsElevation,
            AnalysisWindCaseUBC_1997,
            AnalysisWindCaseVelocityVsElevation,
            AnalysisMDMTReport,
            BranchEndPort,
            Pipe,
            Pipeline,
            PipeRun,
            PipeStraightOverride,
            PipeTurnOverride,
            PipeWeld,
            PipingComponent,
            PipingPort,
            PipingSystem,
            Plant,
            Support
        }

        public static SIOEntity Create(DEFUID defUid)
        {
            try
            {
                SIOEntity sioEntity;
                switch (defUid)
                {
                    case DEFUID.AnalysisNode:
                        {
                            return sioEntity = new AnalysisNode();
                        }
                    case DEFUID.AnalysisGlobalCoordinate:
                        {
                            return sioEntity = new AnalysisGlobalCoordinate();
                        }
                    case DEFUID.AnalysisPipe:
                        {
                            return sioEntity = new AnalysisPipe();
                        }
                    case DEFUID.AnalysisReducer:
                        {
                            return sioEntity = new AnalysisReducer();
                        }
                    case DEFUID.AnalysisBend:
                        {
                            return sioEntity = new AnalysisBend();
                        }
                    case DEFUID.AnalysisLoadCase:
                        {
                            return sioEntity = new AnalysisLoadCase();
                        }                   
                    case DEFUID.AnalysisAppliedPointForce:
                        {
                            return sioEntity = new AnalysisAppliedPointForce();
                        }
                    case DEFUID.AnalysisGlobalForceMoments:
                        {
                            return sioEntity = new AnalysisGlobalForceMoments();
                        }
                    case DEFUID.AnalysisLocalForceMoments:
                        {
                            return sioEntity = new AnalysisLocalForceMoments();
                        }
                    case DEFUID.AnalysisDisplacement:
                        {
                            return sioEntity = new AnalysisDisplacement();
                        }
                    case DEFUID.AnalysisDisplacementOutput:
                        {
                            return sioEntity = new AnalysisDisplacementOutput();
                        }
                    case DEFUID.AnalysisHanger:
                        {
                            return sioEntity = new AnalysisHanger();
                        }
                    case DEFUID.AnalysisRestraint:
                        {
                            return sioEntity = new AnalysisRestraint();
                        }
                    case DEFUID.AnalysisProcessInfo:
                        {
                            return sioEntity = new AnalysisProcessInfo();
                        }
                    case DEFUID.AnalysisSIFUserDefinedData:
                        {
                            return sioEntity = new AnalysisSIFUserDefinedData();
                        }
                    case DEFUID.AnalysisSIFFitting:
                        {
                            return sioEntity = new AnalysisSIFFitting();
                        }
                    case DEFUID.AnalysisSIFFittingOutput:
                        {
                            return sioEntity = new AnalysisSIFFittingOutput();
                        }
                    case DEFUID.AnalysisSIFNoTee:
                        {
                            return sioEntity = new AnalysisSIFNoTee();
                        }
                    case DEFUID.AnalysisSIFOutput:
                        {
                            return sioEntity = new AnalysisSIFOutput();
                        }                    
                    case DEFUID.AnalysisSpecialJoint:
                        {
                            return sioEntity = new AnalysisSpecialJoint();
                        }
                    case DEFUID.AnalysisExpansionJoint:
                        {
                            return sioEntity = new AnalysisExpansionJoint();
                        }
                    case DEFUID.AnalysisRigid:
                        {
                            return sioEntity = new AnalysisRigid();
                        }
                    case DEFUID.AnalysisNozzleFlexAPI650:
                        {
                            return sioEntity = new AnalysisNozzleFlexAPI650();
                        }
                    case DEFUID.AnalysisNozzleFlexCustom:
                        {
                            return sioEntity = new AnalysisNozzleFlexCustom();
                        }
                    case DEFUID.AnalysisNozzleFlexPD5500:
                        {
                            return sioEntity = new AnalysisNozzleFlexPD5500();
                        }
                    case DEFUID.AnalysisNozzleFlexWRC297:
                        {
                            return sioEntity = new AnalysisNozzleFlexWRC297();
                        }
                    case DEFUID.AnalysisUniformLoadDataSet:
                        {
                            return sioEntity = new AnalysisUniformLoadDataSet();
                        }
                    case DEFUID.AnalysisUniformLoadPrimitive:
                        {
                            return sioEntity = new AnalysisOperatingPrimitive() { PrimitiveType = PrimitiveType.U };
                        }
                    case DEFUID.AnalysisAppliedPointForcePrimitive:
                        {
                            return sioEntity = new AnalysisOperatingPrimitive() { PrimitiveType = PrimitiveType.F };
                        }
                    case DEFUID.AnalysisDisplacementPrimitive:
                        {
                            return sioEntity = new AnalysisOperatingPrimitive() { PrimitiveType = PrimitiveType.D };
                        }
                    case DEFUID.AnalysisLoadCasePrimitive:
                        {
                            return sioEntity = new AnalysisOperatingPrimitive() { PrimitiveType = PrimitiveType.LC };
                        }
                    case DEFUID.AnalysisMaterialPrimitive:
                        {
                            return sioEntity = new AnalysisOperatingPrimitive() { PrimitiveType = PrimitiveType.MAT };
                        }
                    case DEFUID.AnalysisOperatingPrimitive:
                        {
                            return sioEntity = new AnalysisOperatingPrimitive() { PrimitiveType = PrimitiveType.UNDEFINED };
                        }
                    case DEFUID.AnalysisGlobalRestraintReaction:
                        {
                            return sioEntity = new AnalysisGlobalRestraintReaction();
                        }
                    case DEFUID.AnalysisLocalRestraintReaction:
                        {
                            return sioEntity = new AnalysisLocalRestraintReaction();
                        }
                    case DEFUID.AnalysisFlangeCheckNC:
                        {
                            return sioEntity = new AnalysisFlangeCheckNC();
                        }
                    case DEFUID.AnalysisFlangeCheckPeq:
                        {
                            return sioEntity = new AnalysisFlangeCheckPeq();
                        }
                    case DEFUID.AnalysisFlangeCheckPressureRating:
                        {
                            return sioEntity = new AnalysisFlangeCheckPressureRating();
                        }
                    case DEFUID.AnalysisFlangeCheckYieldStrength:
                        {
                            return sioEntity = new AnalysisFlangeCheckYieldStrength();
                        }
                    case DEFUID.AnalysisNozzleLimitCheck:
                        {
                            return sioEntity = new AnalysisNozzleLimitCheck();
                        }
                    case DEFUID.AnalysisPipeProperty:
                        {
                            return sioEntity = new AnalysisPipeProperty();
                        }
                    case DEFUID.AnalysisModelOrganization:
                        {
                            return sioEntity = new AnalysisModelOrganization();
                        }
                    case DEFUID.AnalysisWind:
                        {
                            return sioEntity = new AnalysisWind();
                        }
                    case DEFUID.AnalysisWave:
                        {
                            return sioEntity = new AnalysisWave();
                        }
                    case DEFUID.AnalysisComponentStressOutput:
                        {
                            return sioEntity = new AnalysisComponentStressOutput();
                        }
                    case DEFUID.AnalysisMaterialAllowableASME:
                        {
                            return sioEntity = new AnalysisMaterialAllowableASME();
                        }
                    case DEFUID.AnalysisMaterialAllowableB31:
                        {
                            return sioEntity = new AnalysisMaterialAllowableB31();
                        }
                    case DEFUID.AnalysisMaterialAllowableBS7159:
                        {
                            return sioEntity = new AnalysisMaterialAllowableBS7159();
                        }
                    case DEFUID.AnalysisMaterialAllowableBS806:
                        {
                            return sioEntity = new AnalysisMaterialAllowableBS806();
                        }
                    case DEFUID.AnalysisMaterialAllowableCANZ662:
                        {
                            return sioEntity = new AnalysisMaterialAllowableCANZ662();
                        }
                    case DEFUID.AnalysisMaterialAllowableCODETI:
                        {
                            return sioEntity = new AnalysisMaterialAllowableCODETI();
                        }                    
                    case DEFUID.AnalysisMaterialAllowableDNV:
                        {
                            return sioEntity = new AnalysisMaterialAllowableDNV();
                        }                    
                    case DEFUID.AnalysisMaterialAllowableFDBR:
                        {
                            return sioEntity = new AnalysisMaterialAllowableFDBR();
                        }
                    case DEFUID.AnalysisMaterialAllowableGPTCZ380:
                        {
                            return sioEntity = new AnalysisMaterialAllowableGPTCZ380();
                        }
                    case DEFUID.AnalysisMaterialAllowableHPSGL:
                        {
                            return sioEntity = new AnalysisMaterialAllowableHPSGL();
                        }            
                    case DEFUID.AnalysisMaterialAllowableISO146922005:
                        {
                            return sioEntity = new AnalysisMaterialAllowableISO146922005();
                        }
                    case DEFUID.AnalysisMaterialAllowableISO146922017:
                        {
                            return sioEntity = new AnalysisMaterialAllowableISO146922017();
                        }
                    case DEFUID.AnalysisMaterialAllowableJPI:
                        {
                            return sioEntity = new AnalysisMaterialAllowableJPI();
                        }            
                    case DEFUID.AnalysisMaterialAllowableNavy505:
                        {
                            return sioEntity = new AnalysisMaterialAllowableNavy505();
                        }                    
                    case DEFUID.AnalysisMaterialAllowableNorwegianTBK6:
                        {
                            return sioEntity = new AnalysisMaterialAllowableNorwegianTBK6();
                        }
                    case DEFUID.AnalysisMaterialAllowablePD8010:
                        {
                            return sioEntity = new AnalysisMaterialAllowablePD8010();
                        }
                    case DEFUID.AnalysisMaterialAllowableRCCMCD:
                        {
                            return sioEntity = new AnalysisMaterialAllowableRCCMCD();
                        }
                    case DEFUID.AnalysisMaterialAllowableStoomwezen:
                        {
                            return sioEntity = new AnalysisMaterialAllowableStoomwezen();
                        }
                    case DEFUID.AnalysisMaterialAllowableSwedishPowerCodeMethod1:
                        {
                            return sioEntity = new AnalysisMaterialAllowableSwedishPowerCodeMethod1();
                        }
                    case DEFUID.AnalysisMaterialAllowableSwedishPowerCodeMethod2:
                        {
                            return sioEntity = new AnalysisMaterialAllowableSwedishPowerCodeMethod2();
                        }
                    case DEFUID.AnalysisMaterialAllowableTD12:
                        {
                            return sioEntity = new AnalysisMaterialAllowableTD12();
                        }
                    case DEFUID.AnalysisMaterial:
                        {
                            return sioEntity = new AnalysisMaterial();
                        }
                    case DEFUID.AnalysisMaterialAllowableEN:
                        {
                            return sioEntity = new AnalysisMaterialAllowableEN();
                        }
                    case DEFUID.AnalysisMaterialAllowableUKOOA:
                        {
                            return sioEntity = new AnalysisMaterialAllowableUKOOA();
                        }
                    case DEFUID.AnalysisMaterialAllowableDataSet:
                        {
                            return sioEntity = new AnalysisMaterialAllowableDataSet();
                        }
                    case DEFUID.AnalysisMaterialFatigueDataSet:
                        {
                            return sioEntity = new AnalysisMaterialFatigueDataSet();
                        }
                    case DEFUID.AnalysisNozzleLimitCheckOutput:
                        {
                            return sioEntity = new AnalysisNozzleLimitCheckOutput() { InputNozzleLimitCheck = new AnalysisNozzleLimitCheck() };
                        }
                    case DEFUID.AnalysisFlangeCheckPeqOutput:
                        {
                            return sioEntity = new AnalysisFlangeCheckPeqOutput();
                        }
                    case DEFUID.AnalysisFlangeCheckNCOutput:
                        {
                            return sioEntity = new AnalysisFlangeCheckNCOutput();
                        }
                    case DEFUID.AnalysisHangerOutput:
                        {
                            return sioEntity = new AnalysisHangerOutput();
                        }
                    case DEFUID.AnalysisDNVComponentsOutput:
                        {
                            return sioEntity = new AnalysisDNVComponentsOutput();
                        }
                    case DEFUID.AnalysisDNVDetailsOutput:
                        {
                            return sioEntity = new AnalysisDNVDetailsOutput();
                        }
                    case DEFUID.AnalysisDNVThicknessOutput:
                        {
                            return sioEntity = new AnalysisDNVThicknessOutput();
                        }
                    case DEFUID.AnalysisDensities:
                        {
                            return sioEntity = new AnalysisDensities();
                        }                    
                    case DEFUID.AnalysisElementOffset:
                        {
                            return sioEntity = new AnalysisElementOffset();
                        }                    
                    case DEFUID.AnalysisLoadCaseComponent:
                        {
                            return sioEntity = new AnalysisLoadCaseComponent();
                        }
                    case DEFUID.AnalysisLoadCaseDefinition:
                        {
                            return sioEntity = new AnalysisLoadCaseDefinition();
                        }
                    case DEFUID.AnalysisWindCaseIBC_2006:
                        {
                            return sioEntity = new AnalysisWindCaseIBC_2006();
                        }
                    case DEFUID.AnalysisWindCaseIBC_2012:
                        {
                            return sioEntity = new AnalysisWindCaseIBC_2012();
                        }
                    case DEFUID.AnalysisWindCaseIBC_2018:
                        {
                            return sioEntity = new AnalysisWindCaseIBC_2018();
                        }
                    case DEFUID.AnalysisWindCaseIBC_2021:
                        {
                            return sioEntity = new AnalysisWindCaseIBC_2021();
                        }
                    case DEFUID.AnalysisWindCaseIBC_2024:
                        {
                            return sioEntity = new AnalysisWindCaseIBC_2024();
                        }
                    case DEFUID.AnalysisWindCaseASCE7_2005:
                        {
                            return sioEntity = new AnalysisWindCaseASCE7_2005();
                        }
                    case DEFUID.AnalysisWindCaseASCE7_2010:
                        {
                            return sioEntity = new AnalysisWindCaseASCE7_2010();
                        }
                    case DEFUID.AnalysisWindCaseASCE7_2016:
                        {
                            return sioEntity = new AnalysisWindCaseASCE7_2016();
                        }
                    case DEFUID.AnalysisWindCaseASCE7_2022:
                        {
                            return sioEntity = new AnalysisWindCaseASCE7_2022();
                        }
                    case DEFUID.AnalysisWindCaseAustralia1170_2002:
                        {
                            return sioEntity = new AnalysisWindCaseAustralia1170_2002();
                        }
                    case DEFUID.AnalysisWindCaseBrazilNBR6123_1988:
                        {
                            return sioEntity = new AnalysisWindCaseBrazilNBR6123_1988();
                        }
                    case DEFUID.AnalysisWindCaseChinaGB50009_2002:
                        {
                            return sioEntity = new AnalysisWindCaseChinaGB50009_2002();
                        }
                    case DEFUID.AnalysisWindCaseChinaGB50009_2012:
                        {
                            return sioEntity = new AnalysisWindCaseChinaGB50009_2012 ();
                        }
                    case DEFUID.AnalysisWindCaseEurope1991_2005:
                        {
                            return sioEntity = new AnalysisWindCaseChinaGB50009_2012();
                        }
                    case DEFUID.AnalysisWindCaseIS875_1998:
                        {
                            return sioEntity = new AnalysisWindCaseIS875_1998();
                        }
                    case DEFUID.AnalysisWindCaseMexico_1993:
                        {
                            return sioEntity = new AnalysisWindCaseMexico_1993();
                        }
                    case DEFUID.AnalysisWindCaseNBC_2005:
                        {
                            return sioEntity = new AnalysisWindCaseNBC_2005();
                        }
                    case DEFUID.AnalysisWindCaseNBC_2015:
                        {
                            return sioEntity = new AnalysisWindCaseNBC_2015();
                        }
                    case DEFUID.AnalysisWindCaseUBC_1997:
                        {
                            return sioEntity = new AnalysisWindCaseNBC_2015();
                        }
                    case DEFUID.AnalysisWindCasePressureVsElevation:
                        {
                            return sioEntity = new AnalysisWindCasePressureVsElevation();
                        }
                    case DEFUID.AnalysisWindCaseVelocityVsElevation:
                        {
                            return sioEntity = new AnalysisWindCaseVelocityVsElevation();
                        }
                    case DEFUID.AnalysisWindCaseBS6399_1997:
                        {
                            return sioEntity = new AnalysisWindCaseBS6399_1997();
                        }
                    case DEFUID.AnalysisWaveLoad:
                        {
                            return sioEntity = new AnalysisWaveLoad();
                        }
                    case DEFUID.AnalysisMDMTReport:
                        {
                            return sioEntity = new AnalysisMDMTReport();
                        }
                    case DEFUID.AnalysisSubBend:
                        {
                            return sioEntity = new AnalysisSubBend();
                        }
                    default:
                        return CreateBase(defUid);
                } 
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static SIOEntity CreateBase(DEFUID defUid)
        {
            switch (defUid)
            {
                case DEFUID.Plant:
                    {
                        return new Plant();
                    }
                case DEFUID.PipingSystem:
                    {
                        return new PipingSystem();
                    }
                case DEFUID.Pipeline:
                    {
                        return new Pipeline();
                    }
                case DEFUID.PipeRun:
                    {
                        return new PipeRun();
                    }
                case DEFUID.Pipe:
                    {
                        return new Pipe();
                    }
                case DEFUID.PipingComponent:
                    {
                        return new PipingComponent();
                    }
                case DEFUID.PipeStraightOverride:
                    {
                        return new PipeStraightOverride();
                    }
                case DEFUID.PipeTurnOverride:
                    {
                        return new PipeTurnOverride();
                    }
                case DEFUID.PipingPort:
                    {
                        return new PipingPort();
                    }
                case DEFUID.BranchEndPort:
                    {
                        return new BranchEndPort();
                    }
                case DEFUID.Support:
                    {
                        return new Support();
                    }
                case DEFUID.PipeWeld:
                    {
                        return new PipeWeld();
                    }
                default:
                    return null;
            }
        }

        /// <summary>
        /// Method Create a SIOEntity object.
        /// </summary>
        /// <param name="DefUID">string representing DefUID</param>
        /// <returns>ISIOEntity</returns>
        public static SIOEntity Create(string DefUID)
        {
            try
            {
                SIOEntity sioEntity;
                if (Enum.TryParse(DefUID, true, out DEFUID defUid))
                {
                    return sioEntity = Create(defUid);
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Method Create a SIOEntity object.
        /// </summary>
        /// <param name="type">Type representing SIOEntity</param>
        /// <returns>ISIOEntity</returns>
        public static SIOEntity Create(Type type)
        {
            try
            {
                SIOEntity sioEntity;
                if (Enum.TryParse(type.Name, true, out DEFUID defUid))
                {
                    return sioEntity = Create(defUid);
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}