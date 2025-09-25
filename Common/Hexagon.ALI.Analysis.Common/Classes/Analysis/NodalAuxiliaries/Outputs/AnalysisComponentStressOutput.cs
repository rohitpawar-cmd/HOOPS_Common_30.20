using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.Analysis.LoadCase;
using Hexagon.ALI.Analysis.Common.DTOs.Enums;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.Outputs;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries.Outputs
{
    public class AnalysisComponentStressOutput : AnalysisNodeAuxiliaryOutput, IAnalysisStress, IAnalysisComponentStress
    {
        public AnalysisComponentStressOutput(AnalysisNode node = null, AnalysisLoadCase loadCase = null) : base(node, loadCase)
        {
        }
        public AnalysisComponentStressOutput()
        {

        }
        public PipingCode? CodeStandard { get; set; } = PipingCode.UNDEFINED;
        [NotMapped]
        public string Axial { get; set; }
        [NotMapped]
        public string Bending { get; set; }
        [NotMapped]
        public string Torsion { get; set; }
        [NotMapped]
        public string Hoop { get; set; }
        public double? SIFIndexInplane { get; set; }
        public double? SIFIndexOutplane { get; set; }
        [NotMapped]
        public string Code { get; set; }
        [NotMapped]
        public string Allowable { get; set; }

        public double? AxialSiValue { get; private set; }

        public double? BendingSiValue { get; private set; }

        public double? TorsionSiValue { get; private set; }

        public double? HoopSiValue { get; private set; }

        public double? ShearSiValue { get; private set; }
        public double? Shear3DSiValue { get; private set; }
        public double? VonMisesSiValue { get; private set; }

        public double? CodeSiValue { get; private set; }
        public double? SLSiValue { get; private set; }
        public double? SLPSiValue { get; private set; }
        public double? CombAllowableCodeSiValue { get; private set; }
        public double? CombCodeSiValue { get; private set; }
        public double? HoopAllowableCodeSiValue { get; private set; }
        public double? HoopCodeSiValue { get; private set; }
        public double? LongitundinalAllowableCodeSiValue { get; private set; }
        public double? LongitundinalCodeSiValue { get; private set; }
        public double? RopingSiValue { get; private set; }
        public double? RingBendSiValue { get; private set; }


        public double? AllowableSiValue { get; private set; }
        [NotMapped]
        public string FA { get; set; }
        public double? FASiValue { get; set; }
        [NotMapped]
        public string SLP { get; set; }
        [NotMapped]
        public string SL { get; set; }
        [NotMapped]
        public string Shear { get; set; }
        [NotMapped]
        public string Shear3D { get; set; }
        [NotMapped]
        public string VonMises { get; set; }
        public double? SIFIndexTorsion { get; set; }
        public double? SIFIndexAxial { get; set; }
        public double? SIFIndexPressure { get; set; }
        public double? SIFIndexShear { get; set; }
        public double? HoopIn { get; set; }
        public double? HoopOut { get; set; }
        public double? Ratio { get; set; }
        [NotMapped]
        public string HoopCode { get; set; }
        [NotMapped]
        public string HoopAllowableCode { get; set; }
        public double? HoopRatio { get; set; }
        [NotMapped]
        public string LongitundinalCode { get; set; }
        [NotMapped]
        public string LongitundinalAllowableCode { get; set; }
        public double? LongitundinalRatio { get; set; }
        [NotMapped]
        public string CombCode { get; set; }
        [NotMapped]
        public string CombAllowableCode { get; set; }
        public double? CombRatio { get; set; }
        [NotMapped]
        public string RingBend { get; set; }
        [NotMapped]
        public string Roping { get; set; }

        [NotMapped]
        public ReportPassFailStatus? PassFailStatus
        {
            get
            {
                if (Ratio == null)
                {
                    return null;
                }
                if (Ratio < 100)
                {
                    return ReportPassFailStatus.Pass;
                }
                return ReportPassFailStatus.Fail;
            }
        }
    }
}
