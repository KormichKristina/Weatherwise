using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherwise.Classes
{
    public class DailyWeatherForecastInfo
    {
        public long Timezone { get; set; }
        public IList<HourlyForecastInfo> List { get; set; }


    }
}
