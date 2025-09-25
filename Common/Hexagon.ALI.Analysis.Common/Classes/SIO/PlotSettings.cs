using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagon.ALI.Analysis.Common.Classes.SIO
{
    public class PlotSettings
    {
        public PlotSettings(string settingName, string settingValue, string settingType)
        {
            SettingName = settingName;
            SettingValue = settingValue;
            SettingType = settingType;
        }
        public string Id { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public string SettingType { get; set; }
    }
}
