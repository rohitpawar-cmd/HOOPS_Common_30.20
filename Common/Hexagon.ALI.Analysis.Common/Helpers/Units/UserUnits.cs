using Hexagon.ALI.Analysis.Common.Enums;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

namespace Hexagon.ALI.Analysis.Common.Helpers.Units
{
    public class UserUnits
    {
        public UserUnits(string uomType, string uomSymbol, double conversionFactorToSI, double constant = 0)
        {
            UomType = uomType;
            UomSymbol = uomSymbol;
            ConversionFactorToSI = conversionFactorToSI;
            Constant = constant;
        }
        public string Id { get; set; }
        public string UomType { get; set; }
        public string UomSymbol { get; set; }
        public double ConversionFactorToSI { get; set; }
        public double Constant { get; set; }
    }

    public class UnitStore
    {
        private Dictionary<string, UserUnits> userUnits;

        public UnitStore(bool setDefaultUnits = true)
        {
            userUnits = new Dictionary<string, UserUnits>();
        }
        public UnitStore(Dictionary<string, UserUnits> unitsDictionary)
        {
            userUnits = unitsDictionary;
        }

        public void AddUserUnit(string measureType, string userUnit, double conversionToSi, double constant = 0)
        {
            userUnits[measureType] = new UserUnits(measureType, userUnit, conversionToSi, constant);
        }
        public void SetDefaultUnits_Si()
        {
            //CAESAR II UoMs
            AddUserUnit(nameof(LengthUoM), LengthUoM.Meter.Text, LengthUoM.Meter.Number, LengthUoM.Meter.Constant);
            AddUserUnit(nameof(ForceUoM), ForceUoM.N.Text, ForceUoM.N.Number, ForceUoM.N.Constant);
            AddUserUnit(nameof(MassDynamicsUoM), MassDynamicsUoM.Kilogram.Text, MassDynamicsUoM.Kilogram.Number, MassDynamicsUoM.Kilogram.Constant);
            AddUserUnit(nameof(MomentInputUoM), MomentInputUoM.Nm.Text, MomentInputUoM.Nm.Number, MomentInputUoM.Nm.Constant);
            AddUserUnit(nameof(MomentOutputUoM), MomentOutputUoM.Nm.Text, MomentOutputUoM.Nm.Number, MomentOutputUoM.Nm.Constant);
            AddUserUnit(nameof(StressUoM), StressUoM.Pa.Text, StressUoM.Pa.Number, StressUoM.Pa.Constant);
            AddUserUnit(nameof(TemperatureUoM), TemperatureUoM.Celsius.Text, TemperatureUoM.Celsius.Number, TemperatureUoM.Celsius.Constant);
            AddUserUnit(nameof(PressureUoM), PressureUoM.Pascal.Text, PressureUoM.Pascal.Number, PressureUoM.Pascal.Constant);
            AddUserUnit(nameof(ElasticModulusUoM), ElasticModulusUoM.Pa.Text, ElasticModulusUoM.Pa.Number, ElasticModulusUoM.Pa.Constant);
            AddUserUnit(nameof(PipeDensityUoM), PipeDensityUoM.kg_m_3.Text, PipeDensityUoM.kg_m_3.Number, PipeDensityUoM.kg_m_3.Constant);
            AddUserUnit(nameof(InsulationDensityUoM), InsulationDensityUoM.kg_m_3.Text, InsulationDensityUoM.kg_m_3.Number, InsulationDensityUoM.kg_m_3.Constant);
            AddUserUnit(nameof(FluidDensityUoM), FluidDensityUoM.kg_m_3.Text, FluidDensityUoM.kg_m_3.Number, FluidDensityUoM.kg_m_3.Constant);
            AddUserUnit(nameof(TranslationalUoM), TranslationalUoM.NPerM.Text, TranslationalUoM.NPerM.Number, TranslationalUoM.NPerM.Constant);
            AddUserUnit(nameof(RotationalStiffnessUoM), RotationalStiffnessUoM.N_m_rad.Text, RotationalStiffnessUoM.N_m_rad.Number, RotationalStiffnessUoM.N_m_rad.Constant);
            AddUserUnit(nameof(UniformLoadUoM), UniformLoadUoM.NPerM.Text, UniformLoadUoM.NPerM.Number, UniformLoadUoM.NPerM.Constant);
            AddUserUnit(nameof(GLoadUoM), GLoadUoM.Gs_Earth_Gravity.Text, GLoadUoM.Gs_Earth_Gravity.Number, GLoadUoM.Gs_Earth_Gravity.Constant);
            AddUserUnit(nameof(WindLoadUoM), WindLoadUoM.Pa.Text, WindLoadUoM.Pa.Number, WindLoadUoM.Pa.Constant);
            AddUserUnit(nameof(ElevationUoM), ElevationUoM.Meter.Text, ElevationUoM.Meter.Number, ElevationUoM.Meter.Constant);
            AddUserUnit(nameof(CompoundLengthUoM), CompoundLengthUoM.Meter.Text, CompoundLengthUoM.Meter.Number, CompoundLengthUoM.Meter.Constant);
            AddUserUnit(nameof(DiameterUoM), DiameterUoM.Meter.Text, DiameterUoM.Meter.Number, DiameterUoM.Meter.Constant);
            AddUserUnit(nameof(ThicknessUoM), ThicknessUoM.Meter.Text, ThicknessUoM.Meter.Number, ThicknessUoM.Meter.Constant);
            AddUserUnit(nameof(AngleUoM), AngleUoM.Radian.Text, AngleUoM.Radian.Number, AngleUoM.Radian.Constant);

            AddUserUnit(nameof(SlopeUoM), SlopeUoM.MeterPerMeter.Text, SlopeUoM.MeterPerMeter.Number, SlopeUoM.MeterPerMeter.Constant);
            AddUserUnit(nameof(AccelerationUoM), AccelerationUoM.Mts_Squared.Text, AccelerationUoM.Mts_Squared.Constant);
            AddUserUnit(nameof(MassUoM), MassUoM.Kilogram.Text, MassUoM.Kilogram.Number, MassUoM.Kilogram.Constant);
            AddUserUnit(nameof(DensityUoM), DensityUoM.kg_m_3.Text, DensityUoM.kg_m_3.Number, DensityUoM.kg_m_3.Constant);
            AddUserUnit(nameof(ForcePerDistanceUoM), ForcePerDistanceUoM.NPerM.Text, ForcePerDistanceUoM.NPerM.Number, ForcePerDistanceUoM.NPerM.Constant);
            AddUserUnit(nameof(MomentsUoM), MomentsUoM.NewtonMeter.Text, MomentsUoM.NewtonMeter.Number, MomentsUoM.NewtonMeter.Constant);
            AddUserUnit(nameof(WeightPerUnitLengthUoM), WeightPerUnitLengthUoM.KilogramPerMeter.Text, WeightPerUnitLengthUoM.KilogramPerMeter.Number, WeightPerUnitLengthUoM.KilogramPerMeter.Constant);
            AddUserUnit(nameof(NominalDiameterUoM), NominalDiameterUoM.Milimeter.Text, NominalDiameterUoM.Milimeter.Number, NominalDiameterUoM.Milimeter.Constant);
            AddUserUnit(nameof(MomentTorqueUoM), MomentTorqueUoM.Nm.Text, MomentTorqueUoM.Nm.Number, MomentTorqueUoM.Nm.Constant);
            AddUserUnit(nameof(CoefficientOfThermalExpansionUoM), CoefficientOfThermalExpansionUoM.perDegreeK.Text, CoefficientOfThermalExpansionUoM.perDegreeK.Number, CoefficientOfThermalExpansionUoM.perDegreeK.Constant);
            AddUserUnit(nameof(AreaUoM), AreaUoM.SquareMeter.Text, AreaUoM.SquareMeter.Number, AreaUoM.SquareMeter.Constant);
        }
        public UserUnits GetUserUnit(string measureType)
        {
            if (userUnits.ContainsKey(measureType))
            {
                return userUnits[measureType];
            }
            else
            {
                return null;
            }
        }
        public void Clear()
        {
            userUnits = new Dictionary<string, UserUnits>();
        }
        public ReadOnlyDictionary<string, UserUnits> GetUnitsDictionary()
        {
            return new ReadOnlyDictionary<string, UserUnits>(userUnits);
        }
        public UserUnits[] GetUnitsArray()
        {
            return userUnits.Values.ToArray();
        }
    }
}
