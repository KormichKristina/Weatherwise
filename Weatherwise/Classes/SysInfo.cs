using System;

namespace Weatherwise.Classes
{
    public class SysInfo
    {
        public long Sunrise { get; set; }
        public long Sunset { get; set;}
        public string Country { get; set; }
        public SysInfo(long sunrise,long sunset,string country)
        {
            Sunrise = sunrise;
            Sunset = sunset;
            Country = country;
        }
        
        
    }
}
