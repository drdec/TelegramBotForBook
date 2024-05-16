using ObsLib.Models.ForBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Models.Profile
{
    internal class Reservations
    {
        public string Id { get; set; }
        public bool Payed { get; set; }
        public CitiesForBook From { get; set; }
        public CitiesForBook To { get; set; }
        public Route Route { get; set; }
        public Carrier Carrier { get; set; }
        public Car Car { get; set; }
        public bool Declined { get; set; }
        public float Price { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public Driver Driver { get; set; }
    }
}
