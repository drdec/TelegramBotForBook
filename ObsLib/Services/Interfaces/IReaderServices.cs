using ObsLib.Models;

namespace ObsLib.Services.Interfaces
{
    internal interface IReaderServices
    {
        Task<List<User>> ReadDataAsync();
    }
}
