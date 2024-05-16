using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Services.Interfaces
{
    internal interface IConnectServices
    {
        public string Token { get; set; }
        public string URL { get; set; }
        Task<string> SendRequest(string data, HttpMethod httpMethod);
        Task<string> SendRequest(HttpMethod httpMethod);
    }
}
