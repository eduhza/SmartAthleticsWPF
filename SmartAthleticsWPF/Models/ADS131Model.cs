using System;
using System.Collections.Generic;
using System.Text;

namespace SmartAthleticsWPF.Models
{
    public class ADS131Model
    {
        public static string MCU;
        public static string ADSModel;
        public static string NumberOfChannels;
        public static string CalibDate;
        public static string CalibTime;
        public static string CalibTemp;
        public static int Process;

        public static bool IsConnected;
        public static bool _25_SamplesArrived;
        public static int SamplesCounter;
        public static int SamplesColected;
        public static int[,] Samples = new int[6, 25];
        public static int[,] SampleList = new int[7, 30000];

        public static int[] uVoltageValue = new int[6];
        public static string[] uVoltageLabel = new string[6];
        public static float TempValue;
        public static string TempLabel;
        public static float VDDValue;
        public static string VDDLabel;

        public static List<double> CH_Const = new List<double>(8);

        public static List<double> R_Const = new List<double>(8);

        public static byte[] Flash_Array = new byte[138];
    }
}
