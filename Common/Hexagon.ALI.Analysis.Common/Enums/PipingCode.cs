using System;
using System.ComponentModel;

namespace Hexagon.ALI.Analysis.Common.Enums
{
    public enum PipingCode
    {
        UNDEFINED = -1,
        [Description("Default")] All_Codes = 0,
        [Description("B31.1-2018")] B31_1_2018 = 1,
        [Description("B31.3-2018")] B31_3_2018 = 3,
        [Description("B31.4-2019")] B31_4_2019 = 4,
        [Description("B31.5-2016")] B31_5_2016 = 5,
        [Description("B31.8-2018")] B31_8_2018 = 8,
        [Description("B31.8 Ch VIII-2018")] B31_8_ChVIII_2018 = 9,
        [Description("B31.9-2017")] B31_9_2017 = 10,
        [Description("B31.4 Ch XI-2019")] B31_4_ChXI_2019 = 11,
        [Description("ASME NC-2009")] ASME_NC_2009 = 12,
        [Description("ASME ND-2009")] ASME_ND_2009 = 13,
        [Description("NAVY 505-1984")] NAVY_505_1984 = 14,
        [Description("CAN Z662-2019")] CANADIAN_Z662_2019 = 15,
        [Description("CAN Z662 Ch 11-2019")] CANADIAN_Z662_Ch11_2019 = 16,
        [Description("BS 806-1993")] BS_806_1993 = 17,
        [Description("Swedish 1-1979")] SWEDISH_1_1979 = 18,
        [Description("Swedish 2-1979")] SWEDISH_2_1979 = 19,
        [Description("B31.1-1967")] B31_1_1967 = 20,
        [Description("STOOMWEZEN-1989")] STOOMWEZEN_1989 = 21,
        [Description("RCC-M C-2007")] RCC_M_C_2007 = 22,
        [Description("RCC-M D-2007")] RCC_M_D_2007 = 23,
        [Description("CODETI-2016")] CODETI_2016 = 24,
        [Description("Norwegian TBK-6-1999")] NORWEGIAN_1999 = 25,
        [Description("FDBR-1995")] FDBR_1995 = 26,
        [Description("BS 7159-1989")] BS_7159_1989 = 27,
        [Description("UKOOA-1994")] UKOOA_1994 = 28,
        [Description("IGE/TD12-2003")] IGE_TD12_2003 = 29,
        [Description("DNV-1996")] DNV_1996 = 30,
        [Description("B31.3 Ch IX-2019")] B31_4_ChIX_2019 = 31,
        [Description("EN 13480-2017")] EN_13480_2017 = 32,
        [Description("GPTC/Z380-2009")] GPTC_Z380_2009 = 33,
        [Description("PD 8010-1-2004")] PD_8010_1_2004 = 34,
        [Description("PD 8010-2-2004")] PD_8010_2_2004 = 35,
        [Description("ISO 14692-2005")] ISO_14692_2005 = 36,
        [Description("HPGSL-2012")] HPGSL_2012 = 37,
        [Description("JPI-2010")] JPI_2010 = 38,
        [Description("B31.3 Ch IX-2018")] B31_3_ChIX_2018 = 39,
        [Description("DNV 2017")] DNV_2017 = 40,
        [Description("ISO 14692-2017")] ISO_14692_2017 = 41,
        [Description("B31.1-2020")] B31_1_2020 = 42,
        [Description("B31.3-2020")] B31_3_2020 = 43,
        [Description("B31.3 Ch IX-2020")] B31_3_ChIX_2020 = 44,
        [Description("B31.5-2019")] B31_5_2019 = 45,
        [Description("B31.8-2020")] B31_8_2020 = 46,
        [Description("B31.8 Ch VIII-2020")] B31_8_ChVIII_2020 = 47,
        [Description("B31.9-2020")] B31_9_2020 = 48,
        [Description("EN 13480-2020")] EN_13480_2020 = 49,
        [Description("B31.12 IP-2019")] B31_12_IP_2019 = 50,
        [Description("B31.12 PL-2019")] B31_12_PL_2019 = 51,
        [Description("B31.1-2022")] B31_1_2022 = 52,
        [Description("B31.3-2022")] B31_3_2022 = 53,
        [Description("B31.3 Ch IX-2022")] B31_3_Ch_IX_2022 = 54,
        [Description("B31.4-2022")] B31_4_2022 = 55,
        [Description("B31.4 Ch IX-2022")] B31_4_Ch_IX_2022 = 56,
        [Description("B31.4 Ch XI-2022")] B31_4_Ch_XI_2022 = 57,
        [Description("B31.5-2022")] B31_5_2022 = 58,
        [Description("B31.8-2022")] B31_8_2022 = 59,
        [Description("B31.8 Ch VIII-2022")] B31_8_Ch_VIII_2022 = 60,
        [Description("B31.12 IP-2023")] B31_12_IP_2023 = 61,
        [Description("B31.12 PL-2023")] B31_12_PL_2023 = 62,
        [Description("B31.3-2024")] B31_3_2024 = 63,
        [Description("B31.3 Ch IX-2024")] B31_13_Ch_IX_2024 = 64,
        [Description("B31.1-2024")] B31_1_2024 = 65,
    }
    public static class PipingCodeHelper
    {
        public static PipingCode MapStringToEnum(string str)
        {

            //Create dictionary and check if the value is in the dictionary
            if (isSubstring(str, "B31.3 -2018"))
            {
                return PipingCode.B31_3_2018;
            }
            else if (isSubstring(str, "B31.3 -2022"))
            {
                return PipingCode.B31_3_2022;
            }
            else if (isSubstring(str, "B31.3 -2020"))
            {
                return PipingCode.B31_3_2020;
            }
            else if (isSubstring(str, "EN-13480-3:2017/A5"))
            {
                return PipingCode.EN_13480_2017;
            }
            else if (isSubstring(str, "EN-13480 -2017"))
            {
                return PipingCode.EN_13480_2017;
            }
            else if (isSubstring(str, "B31.1 -2018"))
            {
                return PipingCode.B31_1_2018;
            }
            else if (isSubstring(str, "B31.1 -2022"))
            {
                return PipingCode.B31_3_2022;
            }
            else if (isSubstring(str, "B31.1 -2020"))
            {
                return PipingCode.B31_3_2020;
            }
            throw new Exception($"PipingCode: {str} is not handled");
        }

        static bool isSubstring(string mainString, string searchString)
        {

            for (int i = 0; i <= mainString.Length - searchString.Length; i++)
            {
                if (mainString.Substring(i, searchString.Length) == searchString)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
