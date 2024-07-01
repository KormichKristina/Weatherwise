using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherwise.Classes
{
    public class WeatherInfo
    {
        public string Name { get; set; }
        public Coordinates Coord { get; set; }
        public IList<MyWeather> Weather { get; set; }
        public long Timezone { get; set; }
        public SysInfo Sys { get; set; }
        public MainInfo Main { get; set; }
        public MyWind Wind { get; set; }
        public TimeSpan GetHoursAndMin()
        {
            TimeSpan sp = new TimeSpan();

            int hours = (int)Timezone / 3600;
            int minutes = (int)Timezone - hours * 3600;
            minutes /= 60;
            sp = new TimeSpan(hours, minutes, 0);

            return sp;
        }

        

    }
}
