using ObsLib.Managers.Interfaces;
using ObsLib.Models;
using ObsLib.Models.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Managers.Implementations
{
    internal class Autentifications : IAutentification
    {
        public async Task<V2Authentication> Autentification(User user)
        {
            return null;
        }

        public Task<string> Autorisation(string phone, string code)
        {
            throw new NotImplementedException();
        }
    }
}
