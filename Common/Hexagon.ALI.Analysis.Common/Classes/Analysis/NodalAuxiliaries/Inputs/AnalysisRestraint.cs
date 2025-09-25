using Hexagon.ALI.Analysis.Common.Classes.Analysis.Abstract;
using Hexagon.ALI.Analysis.Common.Classes.SIO;
using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces.Analysis.NodalAuxiliaries;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.Analysis.NodalAuxiliaries
{
    [DefUID("AnalysisRestraint")]
    public class AnalysisRestraint : AnalysisSupport, IAnalysisRestraint
    {
        public AnalysisRestraint(Support sioSupport = null, AnalysisNode node = null) : base(sioSupport, node)
        {
        }
        public AnalysisRestraint()
        {

        }

        public RestraintType? RestraintType { get; set; }
        [NotMapped]
        public string AngularGap { get; set; }
        [NotMapped]
        public string Stiffness { get; set; }
        [NotMapped]
        public string Gap { get; set; }
        public double? FrictionCoefficient { get; set; }
        public double? XDirectionCosine { get; set; }
        public double? YDirectionCosine { get; set; }
        public double? ZDirectionCosine { get; set; }
        [NotMapped]
        public string RodLength { get; set; }
        [NotMapped]
        public string RodInitialLoadFi { get; set; }
        [NotMapped]
        public string BiLinear2ndStiffnessK2 { get; set; }
        [NotMapped]
        public string BiRotational2ndStiffnessK2 { get; set; }
        [NotMapped]
        public string RotationalStiffness { get; set; }
        [NotMapped]
        public string BiRotationalYieldMoment { get; set; }
        [NotMapped]
        public string BottomOutSpringx { get; set; }
        [NotMapped]
        public string BiLinearYieldLoadFy { get; set; }
        [NotMapped]
        public string BottomOutSpringF { get; set; }
        [NotMapped]
        public string BiLinearInitialStiffnessK1 { get; set; }
        [NotMapped]
        public string BiRotationalInitialStiffnessK1 { get; set; }


        #region SI VALUES
        public double? AngularGapSiValue { get; private set; }
        public double? StiffnessSiValue { get; private set; }
        public double? GapSiValue { get; private set; }
        public double? RodLengthSiValue { get; private set; }
        public double? RodInitialLoadFiSiValue { get; private set; }
        public double? BiLinear2ndStiffnessK2SiValue { get; private set; }
        public double? BiRotational2ndStiffnessK2SiValue { get; private set; }
        public double? RotationalStiffnessSiValue { get; private set; }
        public double? BiRotationalYieldMomentSiValue { get; private set; }
        public double? BottomOutSpringxSiValue { get; private set; }
        public double? BiLinearYieldLoadFySiValue { get; private set; }
        public double? BottomOutSpringFSiValue { get; private set; }
        public double? BiLinearInitialStiffnessK1SiValue { get; private set; }
        public double? BiRotationalInitialStiffnessK1SiValue { get; private set; }
        #endregion

        [NotMapped]
        public bool HasStiffness =>
            StiffnessSiValue != null ||
            RotationalStiffnessSiValue != null ||
            BiLinear2ndStiffnessK2SiValue != null ||
            BiRotational2ndStiffnessK2SiValue != null ||
            BiLinearInitialStiffnessK1SiValue != null ||
            BiRotationalInitialStiffnessK1SiValue != null;
    }
}