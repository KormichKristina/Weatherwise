using System;
using System.Collections.Generic;

namespace Weatherwise.Classes
{
    public class HourlyForecastInfo
    {
        public MainInfo Main { get; set; }
        public IList<MyWeather> Weather { get; set; }
        public MyWind Wind { get; set; }
        public string Dt_txt { get; set; }

    }
}
