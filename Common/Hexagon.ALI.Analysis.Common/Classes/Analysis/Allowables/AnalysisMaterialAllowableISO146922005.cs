using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Allowables;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.Allowables
{
    public class AnalysisMaterialAllowableISO146922005 : AnalysisMaterial, IAnalysisMaterialAllowableISO146922005
    {
        public AnalysisMaterial Material { get; set; }

        public string AnalysisMaterialId { get; set; }

        #region Failure Envelope for Plain Pipe
        [NotMapped]
        public string LongTermAxialStressRatio01 { get; set; }
        public double? LongTermAxialStressRatio01SiValue { get; private set; }

        [NotMapped]
        public string LongTermAxialStressRatio11 { get; set; }
        public double? LongTermAxialStressRatio21SiValue { get; private set; }        

        [NotMapped]
        public string LongTermAxialStressRatio21 { get; set; }
        public double? LongTermAxialStressRatio11SiValue { get; private set; }
        
        [NotMapped]
        public string LongTermHoopStressRatio11 { get; set; }
        public double? LongTermHoopStressRatio11SiValue { get; private set; }        

        [NotMapped]
        public string LongTermHoopStressRatio21 { get; set; }
        public double? LongTermHoopStressRatio21SiValue { get; private set; }
        #endregion

        #region Failure Envelope for Joints/Fittings
        [NotMapped]
        public string QualifiedStressJoint { get; set; }
        public double? QualifiedStressJointSiValue { get; private set; }

        [NotMapped]
        public string QualifiedStressBend { get; set; }
        public double? QualifiedStressBendSiValue { get; private set; }

        [NotMapped]
        public string QualifiedStressTee { get; set; }
        public double? QualifiedStressTeeSiValue { get; private set; }
        public double? BiAxialStressRatioJoint { get; set; }
        public double? BiAxialStressRatioBend { get; set; }
        public double? HoopModulusAxialModulusOfElasticity { get; set; }
        public bool HandLay { get; set; }
        #endregion

        #region Other Partial Factors
        public double? ChemicalResistancePartialFactor { get; set; }
        public double? CyclicServicePartialFactor { get; set; }
        public double? SystemDesignFactor { get; set; }
        public double? ThermalFactor { get; set; }
        #endregion
    }
}
