using Newtonsoft.Json;
using ObsLib.Models;
using ObsLib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Services.Implementations
{
    internal class ReaderJsonServices : IReaderServices
    {
        public async Task<List<User>> ReadDataAsync()
        {
            using var reader = new StreamReader("data.json");

            var json = await reader.ReadToEndAsync();
            return JsonConvert.DeserializeObject<List<User>>(json);
        }
    }
}
