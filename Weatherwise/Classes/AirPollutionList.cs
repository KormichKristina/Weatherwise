using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherwise.Classes
{
    public class AirPollutionList
    {
        public IList<AirPollutionData> List { get; set; }
        public AirPollutionData this[int index]
        {
            get => List[index];
            set =>  List[index] = value;
        }
    }
}
