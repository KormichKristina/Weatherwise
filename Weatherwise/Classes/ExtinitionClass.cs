using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weatherwise.Properties;

namespace Weatherwise.Classes
{
    public static class ExtinitionClass
    {
        public static Image GetWeatherImage(this string str)
        {

            string temp = str;
            temp=temp.Trim('d', 'n');

            switch (temp)
            {
                case "01":
                    return Resources.sun;
                case "02":
                    return Resources.few_clouds;
                case "03":
                    return Resources.scattered_clouds;
                case "04":
                    return Resources.broken_clouds;
                case "09":
                    return Resources.shower_rain;
                case "10":
                    return Resources.rain;
                case "11":
                    return Resources.thunderstorm;
                case "13":
                    return Resources.snow;
                case "50":
                    return Resources.mist;
                default:
                    return null;
            }
        }
        public static string GetAqiStr(this int aqi)
        {
            switch (aqi)
            {
                case 1:
                    return "Good";
                case 2:
                    return "Fair";
                case 3:
                    return "Moderate";
                case 4:
                    return "Poor";
                default:
                    return "Very Poor";

            }
        }
        public static string GetStrDeg(this Degrees deg)
        {
            switch (deg)
            {
                case Degrees.K:
                    return "°K";
                case Degrees.F:
                    return "°F";
                default:
                    return "°C";
            }
        }
        public static string GetStrWindSpeed(this WindSpeed speed)
        {
            switch (speed)
            {
                case WindSpeed.KM_H:
                    return "km/h";
                default:
                    return "m/c";
            }
        }
        public static string GetStrPressure(this Pressure pressure)
        {
            switch (pressure)
            {
                case Pressure.MMHG:
                    return "mmHg";
                default:
                    return "hPa";
            }
        }
        public static Degrees GetDegrees(this string str)
        {
            switch (str)
            {
                case "°C":
                    return Degrees.C;
                case "°F":
                    return Degrees.F;
                default:
                    return Degrees.K;
            }
        }
        public static WindSpeed GetWindSpeed(this string str)
        {
            switch (str)
            {

                case "km/h":
                    return WindSpeed.KM_H;
                default:
                    return WindSpeed.M_C;
                
            }
        }
        public static Pressure GetMyPressure(this string str)
        {
            switch (str)
            {
                case "mmHg":
                    return Pressure.MMHG;
                default:
                    return Pressure.HPA;
            }
        }
    }
}
