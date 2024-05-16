using Newtonsoft.Json;
using ObsLib.Infrastructure;
using ObsLib.Managers.Interfaces;
using ObsLib.Models;
using ObsLib.Models.Authorization;
using ObsLib.Services.Implementations;
using ObsLib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Managers.Implementations
{
    internal class Autentifications : IAutentification
    {
        private readonly IFileService _fileService;
        private readonly IConnectServices _connectServices;
        public Autentifications()
        {
            _fileService = new FileService();
            _connectServices = new ConnectService("", "");
        }

        public async Task<User> Autentification(string phone)
        {
            var user = await _fileService.GetUserByPhone(phone);

            if (user == null)
            {
                var data = new
                {
                    code = "",
                    phone = phone,
                    sms = true
                };

                var jsonData = JsonConvert.SerializeObject(data);
                _connectServices.URL = ConnStrs.BaseURL + ConnStrs.Autentifications;

                var response = await _connectServices.SendRequest(jsonData, HttpMethod.Post);

                Console.WriteLine(response);
                Console.ReadLine();

                return null;
            }
            else
            {
                return user;
            }
        }

        public async Task<string> Autorisation(string phone, string code)
        {
            var user = await _fileService.GetUserByPhone(phone);

            if (user == null)
            {
                var data = new
                {
                    code = code,
                    phone = phone
                };

                var jsonData = JsonConvert.SerializeObject(data);
                _connectServices.URL = ConnStrs.BaseURL + ConnStrs.Authorization;

                var response = await _connectServices.SendRequest(jsonData, HttpMethod.Post);

                return response;
            }
            else
            {
                return user.Token;
            }
        }
    }
}
