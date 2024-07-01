using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Weatherwise.Classes
{
    public struct SysInfo
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
