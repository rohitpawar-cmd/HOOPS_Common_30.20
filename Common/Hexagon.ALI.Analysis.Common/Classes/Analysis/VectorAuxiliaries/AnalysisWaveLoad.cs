using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.Primitives;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Enums.WaveLoadEnums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.VectorAuxiliaries
{
    public class AnalysisWaveLoad : AnalysisVectorAuxiliary, IAnalysisWaveLoad
    {
        public CurrentProfile CurrentProfile { get; set; }
        [NotMapped]
        public string SurfaceVelocity { get; set; }
        public double? SurfaceVelocitySiValue { get; private set; }
        public double? CurrentX { get; set; }
        public double? CurrentY { get; set; }
        public double? CurrentZ { get; set; }
        public WaveTheory WaveTheory { get; set; }
        public int? StreamFunctionOrder { get; set; }
        [NotMapped]
        public string WaterDepth { get; set; }
        public double? WaterDepthSiValue { get; private set; }
        [NotMapped]
        public string WaveHeight { get; set; }
        public string WaveHeightSiValue { get; private set; }
        public double? WavePeriod { get; set; }
        public double? WaveKinematicsFactor { get; set; }
        public double? WaveX { get; set; }
        public double? WaveY { get; set; }
        public double? WaveZ { get; set; }
        public PhaseOption PhaseOption { get; set; }
        public double? PhaseAngle { get; set; }
        [NotMapped]
        public string FreeSurfaceElevation { get; set; }
        public string FreeSurfaceElevationSiValue { get; private set; }
        [NotMapped]
        public string KinematicViscosity { get; set; }
        public string KinematicViscositySiValue { get; private set; }
        [NotMapped]
        public string WaterDensity { get; set; }
        public string WaterDensitySiValue { get; private set; }
        List<DepthVsVelocity> DepthVsVelocity = new List<DepthVsVelocity>();
    }    
}
