using ObsLib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Services.Implementations
{
    internal class ConnectService : IConnectServices
    {
        private readonly string _token;
        public ConnectService(string token) 
        {
            _token = token;
        }

        public Task<string> SendRequest()
        {
            return null;
        }
    }
}
