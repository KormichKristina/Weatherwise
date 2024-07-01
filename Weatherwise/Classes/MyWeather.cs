using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherwise.Classes
{
    public class MyWeather
    {
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

        public MyWeather(string main, string description,string icon)
        {
            Main = main;
            Description = description;
            Icon = icon;
        }
    }
}
