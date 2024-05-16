using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Models.Authorization
{
    internal class V2Authentication
    {
        public string Phone { get; set; }
        public bool Sms { get; set; }
        public string Code { get; set; }
    }
}
