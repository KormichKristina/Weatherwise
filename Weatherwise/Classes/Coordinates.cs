﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherwise.Classes
{
    public class Coordinates
    {
        public float Lon { get; set; }
        public float Lat { get; set; }
        public Coordinates(float lot,float lat)
        {
            Lon = lot;
            Lat = lat;
        }
        
    }
}
