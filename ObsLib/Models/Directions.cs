using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Models
{
    internal class Directions
    {
        public City From { get; set; }
        public List<City> To { get; set; }
    }
}
