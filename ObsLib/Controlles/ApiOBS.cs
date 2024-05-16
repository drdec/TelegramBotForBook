using ObsLib.Managers.Implementations;
using ObsLib.Managers.Interfaces;
using ObsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Controlles
{
    public class ApiOBS
    {
        private readonly IAutentification _autentification;
        private string _phone;
        private User _user;

        public ApiOBS()
        {
            _autentification = new Autentifications();
        }

        public async Task<string> Autorizations(string phone)
        {
            _phone = phone;

            var response = await _autentification.Autentification(phone);

            if (response is null)
            {
                return "Нужно ввести код!";
            }
            else
            {
                _user = response;
                return "Пользователь найден";
            }
        }

        public async Task<bool> EnterCode(string code)
        {
            var response = await _autentification.Autorisation(_phone, code);

            if (response is null) 
            {
                return false;
            }

            return true;
        }

        public string Autorizations(string phone, string chatId)
        {
            return "";
        }
    }
}
