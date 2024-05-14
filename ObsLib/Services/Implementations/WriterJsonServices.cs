using Newtonsoft.Json;
using ObsLib.Models;
using ObsLib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Services.Implementations
{
    internal class WriterJsonServices : IWriterServices
    {
        private const string _path = "data.json";
        public async Task WriteUserDataAsync(List<User> user)
        {

            var json = JsonConvert.SerializeObject(user, Formatting.Indented);
            await File.WriteAllTextAsync(_path, json);
        }
    }
}
