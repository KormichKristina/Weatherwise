using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherwise.Classes
{
    public class MainInfo
    {
        public float Temp { get; set; }
        public float Feels_like { get; set; }
        public float Temp_min { get; set; }
        public float Temp_max { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public float Sea_level { get; set; }
        public MainInfo(float temp,float feelsLike,float tempMin,float tempMax,float humidity,float pressure,float seaLevel)
        {

            Temp = temp;
            Feels_like = feelsLike;
            Temp_min = tempMin;
            Temp_max = tempMax;
            Pressure = pressure;
            Humidity = humidity;
            Sea_level = seaLevel;

            


        }
        

    }
}
