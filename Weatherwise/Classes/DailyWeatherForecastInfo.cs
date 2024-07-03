using System;
using System.Collections.Generic;

namespace Weatherwise.Classes
{
    public class DailyWeatherForecastInfo
    {
        public long Timezone { get; set; }
        public IList<HourlyForecastInfo> List { get; set; }


    }
}
