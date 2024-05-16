using ObsLib.Models;
using ObsLib.Models.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Managers.Interfaces
{
    internal interface IAutentification
    {
        Task<User> Autentification(string phone);
        Task<string> Autorisation(string phone, string code);
    }
}
