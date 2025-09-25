using Hexagon.ALI.Analysis.Common.Classes;
using Hexagon.ALI.Analysis.Common.Classes.Analysis;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LineElements;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Inputs;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.SIF;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using System.Reflection;
[assembly: InternalsVisibleTo("Hexagon.ALI.Analysis.DataAccess.L1.Tests")]
namespace Hexagon.ALI.Analysis.Common.Helpers
{
    [ExcludeFromCodeCoverage]
    internal class AllUoMs : IEnumerable<object[]>
    {
        internal List<object[]> data = new List<object[]>();
        public AllUoMs()
        {
            var list = typeof(SIOEnum)
            .Assembly.GetTypes()
            .Where(t => t.IsSubclassOf(typeof(SIOEnum)) && t.Name.Contains("UoM")).ToList();
            foreach (var item in list)
            {
                data.Add(new object[] { item });
            }
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }
    [ExcludeFromCodeCoverage]
    internal class AllSIOEntity : IEnumerable<object[]>
    {
        internal List<object[]> data = new List<object[]>();
        public AllSIOEntity()
        {
            var list = typeof(SIOEntity)
                .Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(SIOEntity)) && !t.IsAbstract).ToList();
            foreach (var item in list)
            {
                data.Add(new object[] { item });
            }
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }
    [ExcludeFromCodeCoverage]
    internal static class TestHelper
    {
        public static PipeRun GetPipeRun()
        {
            PipeRun PipeRun = new PipeRun()
            {
                Name = $"PipeRun-CASCoreModel",
                
                Description = "PipeRun used for L1 CASCoreModel Testing purposes.",
                DesignMaxPressure = $"1500",
                DesignMaxTemp = $"212",
                OperatingMaxPressure = $"100",
                OperatingMaxTemp = $"175",
                PipeRunMaterialsClass = "Test Material Class",
                PipeRunNPD = $"22"
            };
            // Create Pipe
            Pipe Pipe = new Pipe()
            {
                Name = $"Pipe-CASCoreModel",
                
                Description = "Pipe used for L1 CASCoreModel Testing purposes.",
                LocationX = $"40",
                LocationY = $"40",
                LocationZ = $"55",
                OrientationX = 45.435,
                OrientationY = 37.987,
                OrientationZ = 100.786,
                RadialOrientX = 25,
                RadialOrientY = 15,
                RadialOrientZ = 5,
                UVectorX = 5,
                UVectorY = 6,
                UVectorZ = 7,
                RteBendDataBendAngle = $"40",
                RteBendDataBendRadius = $"15",
                RteBendDataBRadMulti = "67",
                RteBendDataNoOfMiters = "5",
                RteBendDataThroatRadius = $"33"
            };
            PipeRun.PipeRunItems.Add(Pipe);
            // Create AnalysisBend
            AnalysisBend AnalysisBend = new AnalysisBend()
            {
                Name = $"AnalysisBend-CASCoreModel",
                
                Description = "AnalysisBend used for L1 CASCoreModel Testing purposes.",
                GraphicsCoordinates = "{" +
                            "startx: 40," +
                            "starty: 37," +
                            "startz: 100," +

                            "endx: 15," +
                            "endy: 13," +
                            "endz: 18" +
                            "}",
                BaseDX = "15.8441",
                BaseDY = "14.4352",
                BaseDZ = "5.7201",
                //Diameter = "10"
            };
            Pipe.AnalysisAbstractPipe.Add(AnalysisBend);
            AnalysisPipe analysisPipe = new AnalysisPipe()
            {
                Name = $"AnalysisPipe-CASCoreModel",
                
                Description = "AnalysisPipe used for L1 CASCoreModel Testing purposes.",
                GraphicsCoordinates = "{" +
                            "startx: 40," +
                            "starty: 37," +
                            "startz: 100," +

                            "endx: 15," +
                            "endy: 13," +
                            "endz: 18" +
                            "}",
                BaseDX = "15.8441",
                BaseDY = "14.4352",
                BaseDZ = "5.7201",
                //Diameter = "10"
            };
            Pipe.AnalysisAbstractPipe.Add(analysisPipe);
            return PipeRun;
        }
        public static PipingSystem GetPipingSystem()
        {
            PipingSystem ps_pl1 = new PipingSystem()
            {
                Name = $"BendLoop_PipingSystem-{Guid.NewGuid()}",
            };
            var pl10_40 = new Pipeline
            {
                Name = $"10-40*-{Guid.NewGuid()}"
            };
            var endport20 = new BranchEndPort { Name = $"20-{Guid.NewGuid()}" };
            var endport40 = new BranchEndPort { Name = $"4-{Guid.NewGuid()}" };
            var pipeport20b = new PipingPort { Name = $"20(b)-{Guid.NewGuid()}a" };
            var pipeport20a = new PipingPort
            {
                Name = "20(a)",
            };
            pipeport20a.PhysicalPortToPort.Add(pipeport20b);
            pipeport20b.PhysicalPortToPort.Add(pipeport20a);

            var pr10_20 = new PipeRun
            {
                Name = $"10-20*-{Guid.NewGuid()}"
            };
            var pr20_40 = new PipeRun
            {
                Name = $"20-40-{Guid.NewGuid()}"
            };
            var p10_20 = new Pipe
            {
                Name = $"10-20-{Guid.NewGuid()}"
            };
            var p20_40 = new Pipe
            {
                Name = $"20-40-{Guid.NewGuid()}"
            };
            var pso10_20 = new PipeStraightOverride
            {
                Name = $"10-20-{Guid.NewGuid()}",
            };
            var pso20_28 = new PipeStraightOverride
            {
                Name = $"20-28-{Guid.NewGuid()}",
            };
            var pso30_38 = new PipeStraightOverride
            {
                Name = $"30-38-{Guid.NewGuid()}",
            };
            var pto28_30 = new PipeTurnOverride
            {
                Name = $"28-3-{Guid.NewGuid()}",
            };
            var pto38_40 = new PipeTurnOverride
            {
                Name = $"38-4-{Guid.NewGuid()}",
            };
            var node10 = new AnalysisNode { Name = $"1-{Guid.NewGuid()}" };
            var node20 = new AnalysisNode { Name = $"2-{Guid.NewGuid()}" };
            var node28 = new AnalysisNode { Name = $"3-{Guid.NewGuid()}" };
            var node29 = new AnalysisNode { Name = $"4-{Guid.NewGuid()}" };
            var node30 = new AnalysisNode { Name = $"5-{Guid.NewGuid()}" };
            var node38 = new AnalysisNode { Name = $"6-{Guid.NewGuid()}" };
            var node39 = new AnalysisNode { Name = $"7-{Guid.NewGuid()}" };
            var node40 = new AnalysisNode { Name = $"8-{Guid.NewGuid()}" };

            var ap10_20 = new AnalysisPipe() { Name = $"10-2-{Guid.NewGuid()}" };
            var ap20_28 = new AnalysisPipe() { Name = $"20-2-{Guid.NewGuid()}" };
            var ab28_30 = new AnalysisBend() { Name = $"28-3-{Guid.NewGuid()}" };

            var ap30_38 = new AnalysisPipe() { Name = $"30-3-{Guid.NewGuid()}" };
            var ab38_40 = new AnalysisBend() { Name = $"38-4-{Guid.NewGuid()}" };

            ap10_20.OwnsAnalysisNodes.Add(node10);
            ap10_20.OwnsAnalysisNodes.Add(node20);
            pso10_20.AnalysisBeams.Add(ap10_20);
            p10_20.AnalysisAbstractPipe.Add(ap10_20);
            p10_20.OwnsRoutePorts.Add(pipeport20a);
            p10_20.PartOverrides.Add(pso10_20);
            pr10_20.RunEnd1BranchPort = endport20;
            pr10_20.PipeRunItems.Add(p10_20);
            pl10_40.OwnsPipeRuns.Add(pr10_20);

            ap20_28.OwnsAnalysisNodes.Add(node20);
            ap20_28.OwnsAnalysisNodes.Add(node28);
            pso20_28.AnalysisBeams.Add(ap20_28);

            ab28_30.OwnsAnalysisNodes.Add(node28);
            ab28_30.OwnsAnalysisNodes.Add(node29);
            ab28_30.OwnsAnalysisNodes.Add(node30);
            pto28_30.AnalysisBeams.Add(ab28_30);
            ap30_38.OwnsAnalysisNodes.Add(node30);
            ap30_38.OwnsAnalysisNodes.Add(node38);
            pso30_38.AnalysisBeams.Add(ap30_38);
            ab38_40.OwnsAnalysisNodes.Add(node38);
            ab38_40.OwnsAnalysisNodes.Add(node39);
            ab38_40.OwnsAnalysisNodes.Add(node40);
            pto38_40.AnalysisBeams.Add(ab38_40);

            p20_40.OwnsRoutePorts.Add(pipeport20b);
            p20_40.PartOverrides.Add(pso20_28);
            p20_40.PartOverrides.Add(pto28_30);
            p20_40.PartOverrides.Add(pso30_38);
            p20_40.PartOverrides.Add(pto38_40);
            pr20_40.PipeRunItems.Add(p20_40);
            pr20_40.RunEnd1BranchPort = endport20;
            pr20_40.RunEnd2BranchPort = endport40;
            pl10_40.OwnsPipeRuns.Add(pr20_40);

            ps_pl1.OwnsPipelines.Add(pl10_40);
            return ps_pl1;
        }
        public static readonly string graphicsUrl = "https://localhost:7001";
        private static Random random = new Random(42);
        static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static SIOEntity SetDefaultProperties(SIOEntity entity)
        {
            var stringValues = RandomString(random.Next(30));
            var props = entity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(o => o.Name);
            foreach (var info in props)
            {

                var getValue = info.GetGetMethod(true).Invoke(entity, null);
                if (info.Name.EndsWith("ID", StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }
        
                if (info.Name == "Name")
                {
                    info.SetValue(entity, $"{entity.GetType().Name}-{Guid.NewGuid()}", null);
                    continue;
                }
                //if (!info.CanWrite)
                //{
                //    Console.WriteLine($"Property {info.Name} could not write");
                //    continue;
                //}
                PPMPropertyAttribute propAtrib = System.Attribute.GetCustomAttributes(info, typeof(PPMPropertyAttribute), true).FirstOrDefault() as PPMPropertyAttribute;
                
                

                    dynamic val = "";

                    UoMAttribute uom = System.Attribute.GetCustomAttributes(info, typeof(UoMAttribute), true).FirstOrDefault() as UoMAttribute;
                    if (uom != null)
                    {
                        //string uomtype;
                        //string key = $"{entity.GetType().Name}.{info.Name}";
                        //lock (entity.UomTypes)
                        //{
                        //    if (!entity.UomTypes.ContainsKey(key))
                        //    {
                        //        entity.UomTypes.TryAdd(key, uom.uomtype);
                        //        uomtype = uom.uomtype;
                        //    }
                        //    else
                        //    {
                        //        entity.UomTypes.TryGetValue(key, out uomtype);
                        //    }
                        //}
                        //var sioEnum = SIOEnum.FindByType(uomtype).FirstOrDefault().Text;
                        val = $"{random.NextDouble() * random.Next()}";
                        info.SetValue(entity, val, null);

                        continue;
                    }
                    if (info.PropertyType == typeof(string))
                    {
                        val = RandomString(random.Next(30));
                    }
                    else if (info.PropertyType == typeof(int))
                    {
                        val = random.Next() + 1;
                    }
                    else if (info.PropertyType == typeof(double))
                    {
                        val = random.NextDouble() * random.Next();
                    }
                    else if (info.PropertyType == typeof(double?))
                    {
                        if (random.Next(1) == 1)
                        {
                            val = null;
                        }
                        else
                        {
                            val = random.NextDouble() * random.Next();
                        }

                    }
                    else if (info.PropertyType == typeof(bool))
                    {
                        if (random.Next(1) == 1)
                        {
                            val = false;
                        }
                        else
                        {
                            val = true;
                        }
                    }
                    else if (info.Name.Contains("SiValue"))
                    {
                        val = random.NextDouble() * random.Next();
                    }
                    else
                    {
                        val = null;
                        continue;
                    }
                     if (!info.CanWrite)
                         continue;
                info.GetSetMethod(true).Invoke(entity, new object[] { val });              

            }
            return entity;
        }
        public static bool CompareSiProperties(SIOEntity entity1, SIOEntity entity2, out string error)
        {
            var props = entity1.GetType().GetProperties().Where(w => w.Name.Contains("SiValue")).ToList();
            bool result = true;
            dynamic val1;
            dynamic val2;
            var ent = new List<string>();

            foreach (var info in props)
            {

                val1 = info.GetValue(entity1);
                val2 = info.GetValue(entity2);
                if (val1 != val2)
                {
                    if (string.IsNullOrEmpty(val1) && string.IsNullOrEmpty(val2))
                    {
                        continue;
                    }
                    ent.Add($"Property {info.Name} did not match | {entity1.GetType()} | Entity1:{val1} - Entity2:{val2} |");
                    result = false;
                }

            }
            error = String.Join("\n", ent);
            return result;
        }

        public static bool CompareProperties(SIOEntity entity1, SIOEntity entity2, out string error)
        {
            var props = PropertyHelper.GetPPMPropertyInfos(entity1.GetType()).Select(s => s.PropertyInfo).OrderBy(o => o.Name);
            bool result = true;
            dynamic val1;
            dynamic val2;
            var ent = new List<string>();

            foreach (var info in props)
            {
                PPMPropertyAttribute propAtrib = System.Attribute.GetCustomAttributes(info, typeof(PPMPropertyAttribute), true).FirstOrDefault() as PPMPropertyAttribute;
                if (propAtrib != null)
                {
                    val1 = info.GetValue(entity1);
                    val2 = info.GetValue(entity2);
                    if (val1 != val2)
                    {
                        if (string.IsNullOrEmpty(val1) && string.IsNullOrEmpty(val2))
                        {
                            continue;
                        }
                        ent.Add($"Property {info.Name} did not match | {entity1.GetType()} | Entity1:{val1} - Entity2:{val2} |");
                        result = false;
                    }

                }
                if (propAtrib == null)
                {
                    Console.WriteLine($"PPM ObJect Property {info.Name} did not match any PPMPropertyAtribute");
                    ent.Add($"PPM ObJect Property {info.Name} did not match any PPMPropertyAtribute");

                }
            }
            error = String.Join("\n", ent);
            return result;
        }

        public class SIOEntityTestsData : IEnumerable<object[]>
        {
            internal List<object[]> data = new List<object[]>();
            internal object[] _plant = new object[] { new Plant() };
            internal object[] _pipingSystem = new object[] { new PipingSystem() };
            internal object[] _pipingPort = new object[] { new PipingPort() };
            internal object[] _pipingComponent = new object[] { new PipingComponent() };
            internal object[] _pipeTurnOverride = new object[] { new PipeTurnOverride() };
            internal object[] _pipeStraightOverride = new object[] { new PipeStraightOverride() };
            internal object[] _pipeRun = new object[] { new PipeRun() };
            internal object[] _pipeline = new object[] { new Pipeline() };
            internal object[] _pipe = new object[] { new Pipe() };
            internal object[] _branchEndPort = new object[] { new BranchEndPort() };
            internal object[] _support = new object[] { new Support() };

            internal object[] _analysisBend = new object[] { new AnalysisBend() };
            internal object[] _analysisPipe = new object[] { new AnalysisPipe() };
            internal object[] _analysisExpansionJoint = new object[] { new AnalysisExpansionJoint() };
            internal object[] _analysisRigid = new object[] { new AnalysisRigid() };
            internal object[] _analysisDisplacement = new object[] { new AnalysisDisplacement() };
            internal object[] _analysisDisplacementOutput = new object[] { new AnalysisDisplacementOutput() };
            internal object[] _analysisAppliedPointForce = new object[] { new AnalysisAppliedPointForce() };
            internal object[] _analysisHanger = new object[] { new AnalysisHanger() };
            internal object[] _analysisLoadCase = new object[] { new AnalysisLoadCase() };
            internal object[] _analysisLoadCasePrimitive = new object[] { new AnalysisOperatingPrimitive() };
            internal object[] _analysisNode = new object[] { new AnalysisNode() };
            internal object[] _analysisProcessInfoDataSet = new object[] { new AnalysisProcessInfo() };
            internal object[] _analysisReducer = new object[] { new AnalysisReducer() };
            internal object[] _analysisRestraint = new object[] { new AnalysisRestraint() };

            #region A20-179-43
            internal object[] _analysisSIFFitting = new object[] { new AnalysisSIFFitting() };
            internal object[] _analysisSIFFittingOutput = new object[] { new AnalysisSIFFittingOutput() };
            internal object[] _analysisSIFOutput = new object[] { new AnalysisSIFOutput() };
            internal object[] _analysisSIFNoTee = new object[] { new AnalysisSIFNoTee() };
            internal object[] _analysisSIFUserDefinedData = new object[] { new AnalysisSIFUserDefinedData() };
            #endregion

            public SIOEntityTestsData()
            {
                data.Add(_plant);
                data.Add(_pipingSystem);
                data.Add(_pipingPort);
                data.Add(_pipingComponent);
                data.Add(_pipeTurnOverride);
                data.Add(_pipeStraightOverride);
                data.Add(_pipeRun);
                data.Add(_pipeline);
                data.Add(_pipe);
                data.Add(_branchEndPort);
                data.Add(_support);
                data.Add(_analysisBend);
                data.Add(_analysisPipe);
                data.Add(_analysisDisplacement);
                data.Add(_analysisAppliedPointForce);
                data.Add(_analysisHanger);
                data.Add(_analysisLoadCase);
                data.Add(_analysisLoadCasePrimitive);
                data.Add(_analysisNode);
                data.Add(_analysisProcessInfoDataSet);
                data.Add(_analysisReducer);
                data.Add(_analysisExpansionJoint);
                data.Add(_analysisRigid);
                data.Add(_analysisRestraint);
                data.Add(_analysisSIFFitting);
                data.Add(_analysisSIFFittingOutput);
                data.Add(_analysisSIFOutput);
                data.Add(_analysisSIFNoTee);
                data.Add(_analysisSIFUserDefinedData);
            }
            public IEnumerator<object[]> GetEnumerator()
            {
                return data.GetEnumerator();

            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
        public class SIOEntityWithRequiredRelationsTestsData : SIOEntityWithOutEnd1Data, IEnumerable<object[]>
        {
            public SIOEntityWithRequiredRelationsTestsData()
            {
                data.Add(pipeTurnOverride.Invoke());
                data.Add(pipeStraightOverride.Invoke());
                data.Add(analysisLoadCase.Invoke());
            }

            Func<object[]> pipeTurnOverride = () =>
            {
                var parent = new Pipe();
                var entity = new PipeTurnOverride();
                parent.PartOverrides.Add(entity);
                return new object[] { entity, parent };
            };

            Func<object[]> pipeStraightOverride = () =>
            {
                var parent = new Pipe();
                var entity = new PipeStraightOverride();
                parent.PartOverrides.Add(entity);
                return new object[] { entity, parent };
            };

            Func<object[]> analysisLoadCase = () =>
            {
                var parent = new PipingSystem();
                var entity = new AnalysisLoadCase();
                parent.OwnsAnalysisLoadCase.Add(entity);
                return new object[] { entity, parent };
            };

            public new IEnumerator<object[]> GetEnumerator()
            {

                return data.GetEnumerator();
            }

        }
        public class SIOEntityGraphicsTestsData : SIOEntityTestsData
        {
            public SIOEntityGraphicsTestsData() : base()
            {
                data.Remove(_analysisBend);
                data.Remove(_analysisPipe);
                _analysisBend = new object[] { new AnalysisBend(), false };
                _analysisPipe = new object[] { new AnalysisPipe(), false };
                data.Add(_analysisBend);
                data.Add(_analysisPipe);
            }
            public new IEnumerator<object[]> GetEnumerator()
            {

                return data.GetEnumerator();
            }
        }
        public class SIOEntityWithOutEnd1Data : SIOEntityTestsData
        {
            public SIOEntityWithOutEnd1Data() : base()
            {
                data.Remove(_pipeStraightOverride);
                data.Remove(_pipeTurnOverride);
                data.Remove(_analysisLoadCase);
            }
            public new IEnumerator<object[]> GetEnumerator()
            {

                return data.GetEnumerator();
            }
        }

        public class AllSIOEntity : IEnumerable<object[]>
        {
            internal List<object[]> data = new List<object[]>();
            public AllSIOEntity()
            {
                var list = typeof(SIOEntity)
                    .Assembly.GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(SIOEntity)) && !t.IsAbstract).ToList();
                foreach (var item in list)
                {
                    data.Add(new object[] { item });
                }
            }

            public IEnumerator<object[]> GetEnumerator()
            {
                return data.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return data.GetEnumerator();
            }
        }



    }
}

