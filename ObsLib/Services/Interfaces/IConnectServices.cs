using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Services.Interfaces
{
    internal interface IConnectServices
    {
        Task<string> SendRequest();
    }
}
