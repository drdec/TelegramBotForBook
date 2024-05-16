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

        public string Token { get; set; }
        public string URL { get; set; }

        public ConnectService(string token, string url)
        {
            Token = token;
            URL = url;
        }

        public async Task<string> SendRequest(string data, HttpMethod httpMethod)
        {
            using var httpClient = new HttpClient();
            var request = new HttpRequestMessage(httpMethod, URL);
            var content = new StringContent(data, null, "application/json");
            
            request.Content = content;

            if (Token != "")
            {
                request.Headers.Add("authorization", $"Bearer {Token}");
            }

            var response = await httpClient.SendAsync(request);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> SendRequest(HttpMethod httpMethod)
        {
            using var httpClient = new HttpClient();
            var request = new HttpRequestMessage(httpMethod, URL);

            if (Token != "")
            {
                request.Headers.Add("authorization", $"Bearer {Token}");
            }

            var response = await httpClient.SendAsync(request);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
