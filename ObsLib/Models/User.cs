using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Models
{
    internal class User
    {
        internal string Phone { get; set; }
        internal string ChatId { get; set; }
        internal string Token { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = obj as User;

            return Phone == other.Phone || ChatId == other.ChatId || Token == other.Token; 
        }
    }
}
