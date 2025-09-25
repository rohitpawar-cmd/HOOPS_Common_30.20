using Hexagon.ALI.Analysis.Common.Helpers;

namespace Hexagon.ALI.Analysis.Common.Interfaces
{
    public interface IProcessDataInfo
    {
        [UoM("TemperatureUoM")]
        [PPMProperty("DesignMaxTemp", "IProcessDataInfo")]
        string DesignMaxTemp
        {
            get; set;
        }

        [UoM("TemperatureUoM")]
        [PPMProperty("DesignMinTemp", "IProcessDataInfo")]
        string DesignMinTemp
        {
            get; set;
        }

        [UoM("PressureUoM")]
        [PPMProperty("DesignMaxPressure", "IProcessDataInfo")]
        string DesignMaxPressure
        {
            get; set;
        }

        [UoM("PressureUoM")]
        [PPMProperty("DesignMinPressure", "IProcessDataInfo")]
        string DesignMinPressure
        {
            get; set;
        }

        [UoM("TemperatureUoM")]
        [PPMProperty("OperatingMaxTemp", "IProcessDataInfo")]
        string OperatingMaxTemp
        {
            get; set;
        }

        [UoM("TemperatureUoM")]
        [PPMProperty("OperatingMinTemp", "IProcessDataInfo")]
        string OperatingMinTemp
        {
            get; set;
        }

        [UoM("PressureUoM")]
        [PPMProperty("OperatingMaxPressure", "IProcessDataInfo")]
        string OperatingMaxPressure
        {
            get; set;
        }

        [UoM("PressureUoM")]
        [PPMProperty("OperatingMinPressure", "IProcessDataInfo")]
        string OperatingMinPressure
        {
            get; set;
        }

        [UoM("TemperatureUoM")]
        [PPMProperty("TestingMaxTemp", "IProcessDataInfo")]
        string TestingMaxTemp
        {
            get; set;
        }

        [UoM("TemperatureUoM")]
        [PPMProperty("TestingMinTemp", "IProcessDataInfo")]
        string TestingMinTemp
        {
            get;
            set;
        }

        [UoM("PressureUoM")]
        [PPMProperty("TestingMaxPressure", "IProcessDataInfo")]
        string TestingMaxPressure
        {
            get;
            set;
        }

        [UoM("PressureUoM")]
        [PPMProperty("TestingMinPressure", "IProcessDataInfo")]
        string TestingMinPressure
        {
            get;
            set;
        }
        double? DesignMaxTempSiValue
        {
            get;

        }

        double? DesignMinTempSiValue
        {
            get;
        }

        double? DesignMaxPressureSiValue
        {
            get;
        }

        double? DesignMinPressureSiValue
        {
            get;
        }

        double? OperatingMaxTempSiValue
        {
            get;
        }

        double? OperatingMinTempSiValue
        {
            get;
        }

        double? OperatingMaxPressureSiValue
        {
            get;
        }

        double? OperatingMinPressureSiValue
        {
            get;
        }

        double? TestingMaxTempSiValue
        {
            get;
        }

        double? TestingMinTempSiValue
        {
            get;
        }

        double? TestingMaxPressureSiValue
        {
            get;
        }

        double? TestingMinPressureSiValue
        {
            get;
        }
    }
}
