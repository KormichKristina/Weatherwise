using System;
using System.IO;

namespace Weatherwise.Classes
{
    public enum Degrees
    {
        K,
        F,
        C
    }
    public enum WindSpeed
    {
        M_C,
        KM_H
    }
    public enum Pressure
    {
        HPA,
        MMHG
    }
    public static class SettingsClass
    {
        public static Degrees TempDegrees {get;set;}
        public static WindSpeed Wind { get; set; }
        public static Pressure MyPressure { get; set; }
        public static bool UseUtc { get; set; }
        public static string MyPathToSettingsData { get; }
        static SettingsClass()
        {
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path= Path.GetDirectoryName(location); 
            MyPathToSettingsData = path.Substring(0, path.Length - 9)+ "Data\\SettingsData.txt";

            if (File.Exists(MyPathToSettingsData))
            {
                string[] lines = File.ReadAllLines(MyPathToSettingsData);
                if (lines.Length < 4)
                {
                    File.WriteAllLines(MyPathToSettingsData, new string[] { "°K", "m/c", "hPa", "false" });

                    TempDegrees = Degrees.K;
                    Wind = WindSpeed.M_C;
                    MyPressure = Pressure.HPA;
                    UseUtc = false;
                }
                else
                {
                    TempDegrees = lines[0].GetDegrees();
                    Wind = lines[1].GetWindSpeed();
                    MyPressure = lines[2].GetMyPressure();
                    UseUtc = Convert.ToBoolean(lines[3]);
                }
            }
            

            
        }
        public static void ChangeSettings()
        {
            File.WriteAllLines(MyPathToSettingsData, new string[] { TempDegrees.GetStrDeg(), Wind.GetStrWindSpeed(), MyPressure.GetStrPressure(), UseUtc.ToString() });
        }
    }
}
