using ObsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Managers.Interfaces
{
    internal interface IUserManager
    {
        Task<List<User>> GerUsers();
        Task<User> GetUser(string phone);
        Task<List<User>> AddUser(User user);
    }
}
