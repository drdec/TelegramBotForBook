using ObsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Managers.Interfaces
{
    internal interface IBooksManager
    {
        Task<bool> Reservate(BetweenCities betweenCities);
        Task<Directions> GetAllDirections();
    }
}
