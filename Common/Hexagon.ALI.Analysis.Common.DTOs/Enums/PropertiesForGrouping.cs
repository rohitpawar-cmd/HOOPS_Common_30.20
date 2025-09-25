using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Hexagon.ALI.Analysis.Common.DTOs.Enums
{
    public enum PropertiesForGrouping
    {
        None = 0,

        [Description("Material")]
        Material,
        [Description("Piping Code")]
        PipingCode,
        [Description("Insulation Thickness")]
        InsulationThickness,
        [Description("Cladding Thickness")]
        CladdingThickness,
        [Description("Refractory Thickness")]
        RefractoryThickness,
        [Description("Diameter")]
        Diameter,
        [Description("Wall Thickness")]
        WallThickness,
        [Description("Mill Tolerance")]
        MillTolerance,
        [Description("Temperature 1")]
        Temperature1,
        [Description("Temperature 2")]
        Temperature2,
        [Description("Temperature 3")]
        Temperature3,
        [Description("Temperature 4")]
        Temperature4,
        [Description("Temperature 5")]
        Temperature5,
        [Description("Temperature 6")]
        Temperature6,
        [Description("Temperature 7")]
        Temperature7,
        [Description("Temperature 8")]
        Temperature8,
        [Description("Temperature 9")]
        Temperature9,
        [Description("Pressure 1")]
        Pressure1,
        [Description("Pressure 2")]
        Pressure2,
        [Description("Pressure 3")]
        Pressure3,
        [Description("Pressure 4")]
        Pressure4,
        [Description("Pressure 5")]
        Pressure5,
        [Description("Pressure 6")]
        Pressure6,
        [Description("Pressure 7")]
        Pressure7,
        [Description("Pressure 8")]
        Pressure8,
        [Description("Pressure 9")]
        Pressure9,
        [Description("Hydro Pressure")]
        HydroPressure,
        [Description("Corrosion")]
        Corrosion,
        [Description("Fluid Density")]
        FluidDensity,
        [Description("Pipe Density")]
        PipeDensity,
        [Description("Insulation Density")]
        InsulationDensity,
        [Description("Cladding Density")]
        CladdingDensity,
        [Description("Refractory Density")]
        RefractoryDensity,
        [Description("Insulation Cladding Unit Weight")]
        InsulCladdingUnitWt,
        [Description("Restratint Gap")]
        RestratintGap,
        [Description("Wind")]
        Wind,
        [Description("Wave Cd")]
        WaveCd,
        [Description("Wave Ca")]
        WaveCa,
        [Description("Wave CI")]
        WaveCI,
        [Description("Wave Tm")]
        WaveTm,
        [Description("Wave MGD")]
        WaveMGD,
        [Description("Uniform Loads 1")]
        UniformLoads1,
        [Description("Uniform Loads 2")]
        UniformLoads2,
        [Description("Uniform Loads 3")]
        UniformLoads3,
        [Description("Uniform Loads 4")]
        UniformLoads4,
        [Description("Uniform Loads 5")]
        UniformLoads5,
        [Description("Uniform Loads 6")]
        UniformLoads6,
        [Description("Uniform Loads 7")]
        UniformLoads7,
        [Description("Uniform Loads 8")]
        UniformLoads8,
        [Description("Uniform Loads 9")]
        UniformLoads9,
    }

    public class PropertyGroupingHelper
    {
        public static bool IsUniformLoad(PropertiesForGrouping property)
        {
            switch (property)
            {
                case PropertiesForGrouping.UniformLoads1:
                case PropertiesForGrouping.UniformLoads2:
                case PropertiesForGrouping.UniformLoads3:
                case PropertiesForGrouping.UniformLoads4:
                case PropertiesForGrouping.UniformLoads5:
                case PropertiesForGrouping.UniformLoads6:
                case PropertiesForGrouping.UniformLoads7:
                case PropertiesForGrouping.UniformLoads8:
                case PropertiesForGrouping.UniformLoads9:
                    return true;
            }

            return false;
        }

        public static int GetUniformLoadNumber(PropertiesForGrouping property)
        {
            switch (property)
            {
                case PropertiesForGrouping.UniformLoads1:
                    return 1;
                case PropertiesForGrouping.UniformLoads2:
                    return 2;
                case PropertiesForGrouping.UniformLoads3:
                    return 3;
                case PropertiesForGrouping.UniformLoads4:
                    return 4;
                case PropertiesForGrouping.UniformLoads5:
                    return 5;
                case PropertiesForGrouping.UniformLoads6:
                    return 6;
                case PropertiesForGrouping.UniformLoads7:
                    return 7;
                case PropertiesForGrouping.UniformLoads8:
                    return 8;
                case PropertiesForGrouping.UniformLoads9:
                    return 9;
            }

            return -1;
        }

        public static PropertiesForGrouping GetUniformLoadEnum(int uniLoadNum)
        {
            switch(uniLoadNum)
            {
                case 1:
                    return PropertiesForGrouping.UniformLoads1;
                case 2:
                    return PropertiesForGrouping.UniformLoads2;
                case 3:
                    return PropertiesForGrouping.UniformLoads3;
                case 4:
                    return PropertiesForGrouping.UniformLoads4;
                case 5:
                    return PropertiesForGrouping.UniformLoads5;
                case 6:
                    return PropertiesForGrouping.UniformLoads6;
                case 7:
                    return PropertiesForGrouping.UniformLoads7;
                case 8:
                    return PropertiesForGrouping.UniformLoads8;
                case 9:
                    return PropertiesForGrouping.UniformLoads9;
            }

            return PropertiesForGrouping.None;
        }

        public static bool IsWave(PropertiesForGrouping property)
        {
            switch (property)
            {
                case PropertiesForGrouping.WaveCd:
                case PropertiesForGrouping.WaveCa:
                case PropertiesForGrouping.WaveCI:
                case PropertiesForGrouping.WaveTm:
                case PropertiesForGrouping.WaveMGD:
                    return true;
            }

            return false;
        }

        public static  List<PropertiesForGrouping> GetWaveProperties()
        {
            List<PropertiesForGrouping> waveList = new List<PropertiesForGrouping>();

            waveList.Add(PropertiesForGrouping.WaveCd);
            waveList.Add(PropertiesForGrouping.WaveCa);
            waveList.Add(PropertiesForGrouping.WaveCI);
            waveList.Add(PropertiesForGrouping.WaveTm);
            waveList.Add(PropertiesForGrouping.WaveMGD);

            return waveList;
        }

        public static bool IsTemperature(PropertiesForGrouping property)
        {
            switch (property)
            {
                case PropertiesForGrouping.Temperature1:
                case PropertiesForGrouping.Temperature2:
                case PropertiesForGrouping.Temperature3:
                case PropertiesForGrouping.Temperature4:
                case PropertiesForGrouping.Temperature5:
                case PropertiesForGrouping.Temperature6:
                case PropertiesForGrouping.Temperature7:
                case PropertiesForGrouping.Temperature8:
                case PropertiesForGrouping.Temperature9:
                    return true;

            }

            return false;
        }

        public static List<PropertiesForGrouping> GetTemperatureProperties()
        {
            List<PropertiesForGrouping> temperatureList = new List<PropertiesForGrouping>();

            temperatureList.Add(PropertiesForGrouping.Temperature1);
            temperatureList.Add(PropertiesForGrouping.Temperature2);
            temperatureList.Add(PropertiesForGrouping.Temperature3);
            temperatureList.Add(PropertiesForGrouping.Temperature4);
            temperatureList.Add(PropertiesForGrouping.Temperature5);
            temperatureList.Add(PropertiesForGrouping.Temperature6);
            temperatureList.Add(PropertiesForGrouping.Temperature7);
            temperatureList.Add(PropertiesForGrouping.Temperature8);
            temperatureList.Add(PropertiesForGrouping.Temperature9);

            return temperatureList;
        }

        public static bool IsPressure(PropertiesForGrouping property)
        {
            switch(property)
            {
                case PropertiesForGrouping.Pressure1:
                case PropertiesForGrouping.Pressure2:
                case PropertiesForGrouping.Pressure3:
                case PropertiesForGrouping.Pressure4:
                case PropertiesForGrouping.Pressure5:
                case PropertiesForGrouping.Pressure6:
                case PropertiesForGrouping.Pressure7:
                case PropertiesForGrouping.Pressure8:
                case PropertiesForGrouping.Pressure9:
                case PropertiesForGrouping.HydroPressure:
                    return true;
            }

            return false;
        }

        public static List<PropertiesForGrouping> GetPressureProperties()
        {
            List<PropertiesForGrouping> pressureList = new List<PropertiesForGrouping>();

            pressureList.Add(PropertiesForGrouping.Pressure1);
            pressureList.Add(PropertiesForGrouping.Pressure2);
            pressureList.Add(PropertiesForGrouping.Pressure3);
            pressureList.Add(PropertiesForGrouping.Pressure4);
            pressureList.Add(PropertiesForGrouping.Pressure5);
            pressureList.Add(PropertiesForGrouping.Pressure6);
            pressureList.Add(PropertiesForGrouping.Pressure7);
            pressureList.Add(PropertiesForGrouping.Pressure8);
            pressureList.Add(PropertiesForGrouping.Pressure9);
            pressureList.Add(PropertiesForGrouping.HydroPressure);

            return pressureList;
        }

        public static bool IsDensity(PropertiesForGrouping property)
        {
            switch(property)
            {
                case PropertiesForGrouping.InsulationDensity:
                case PropertiesForGrouping.CladdingDensity:
                case PropertiesForGrouping.InsulCladdingUnitWt:
                case PropertiesForGrouping.RefractoryDensity:
                    return true;
            }

            return false;
        }

        public static List<PropertiesForGrouping> GetDensityProperties()
        {
            List<PropertiesForGrouping> densityList = new List<PropertiesForGrouping>();

            densityList.Add(PropertiesForGrouping.InsulationDensity);
            densityList.Add(PropertiesForGrouping.CladdingDensity);
            densityList.Add(PropertiesForGrouping.InsulCladdingUnitWt);
            densityList.Add(PropertiesForGrouping.RefractoryDensity);

            return densityList;
        }

        public static bool IsThickness(PropertiesForGrouping property)
        {
            switch (property)
            {
                case PropertiesForGrouping.InsulationThickness:
                case PropertiesForGrouping.CladdingThickness:
                case PropertiesForGrouping.RefractoryThickness:
                    return true;
            }

            return false;
        }

        public static List<PropertiesForGrouping> GetThicknessProperties()
        {
            List<PropertiesForGrouping> thicknessList = new List<PropertiesForGrouping>();

            thicknessList.Add(PropertiesForGrouping.InsulationThickness);
            thicknessList.Add(PropertiesForGrouping.CladdingThickness);
            thicknessList.Add(PropertiesForGrouping.RefractoryThickness);

            return thicknessList;
        }
    }
}
