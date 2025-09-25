using Hexagon.ALI.Analysis.Common.Enums;
using Hexagon.ALI.Analysis.Common.Helpers;
using Hexagon.ALI.Analysis.Common.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexagon.ALI.Analysis.Common.Classes.SIO
{
    [DefUID("PipingComponent")]
    public class PipingComponent : PipeRunItem, IPipeCommon, IPipingComponent, IPipePartItem, IRteBendData, IItem, ISupportedObject, IWeightCG
    {
        public enum ePipingComponentType { Undefined = -1, StandardBend, ConcentricReducer, EccentricReducer, NonSpecificRigid, FlangeRigid, ValveRigid, ExpansionJoint }

        public PipingComponent()
        {

        }


        #region PROPERTIES

        public bool PipePartIsSpecialty
        {
            get;
            set;
        }

        public string PipeComponentGeometryType
        {
            get;
            set;
        }

        public string PipePartShortMatlDesc
        {
            get;
            set;
        }

        public string PipePartMaterialGrade
        {
            get;
            set;
        }

        public string PipePartMaterialCategory
        {
            get;
            set;
        }

        public string PipePartMaterialGradePractice
        {
            get;
            set;
        }
        [NotMapped]
        public string RteBendDataBendAngle
        {
            get;
            set;
        }

        public double? RteBendDataBendAngleSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string RteBendDataBendRadius
        {
            get;
            set;
        }

        public double? RteBendDataBendRadiusSiValue
        {
            get;
            private set;
        }

        public string RteBendDataBRadMulti
        {
            get;
            set;
        }

        public string RteBendDataNoOfMiters
        {
            get;
            set;
        }
        [NotMapped]
        public string RteBendDataThroatRadius
        {
            get;
            set;
        }

        public double? RteBendDataThroatRadiusSiValue
        {
            get;
            private set;
        }
        [NotMapped]
        public string DryWeight
        {
            get;
            set;
        }

        public double? DryWeightSiValue
        {
            get;
            private set;
        }

        public int PipingComponentType { get; set; } = (int)ePipingComponentType.Undefined;

        #endregion PROPERTIES

        #region METHODS

        public void SetAsStandardBend()
        {
            PipePartIsSpecialty = false;
            PipingComponentType = (int)ePipingComponentType.StandardBend;
            PipeComponentGeometryType = GeometryType.ElbowFixedAngle.SIO_Type;
        }
        public void SetAsConcentricReducer()
        {
            PipingComponentType = (int)ePipingComponentType.ConcentricReducer;
        }

        public void SetAsEccentricReducer()
        {
            PipingComponentType = (int)ePipingComponentType.EccentricReducer;
        }

        public void SetAsNonSpecificRigid()
        {
            PipingComponentType = (int)ePipingComponentType.NonSpecificRigid;
        }

        public void SetAsFlangeRigid()
        {
            PipingComponentType = (int)ePipingComponentType.FlangeRigid;
        }

        public void SetAsValveRigid()
        {
            PipingComponentType = (int)ePipingComponentType.ValveRigid;
        }

        public void SetAsExpansionJoint()
        {
            PipingComponentType = (int)ePipingComponentType.ExpansionJoint;
        }

        #endregion
    }
}