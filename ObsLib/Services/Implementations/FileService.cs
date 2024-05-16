using ObsLib.Models;
using ObsLib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Services.Implementations
{
    internal class FileService : IFileService
    {
        private readonly IReaderServices _readServices;
        private readonly IWriterServices _writeServices;

        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1); // Используем SemaphoreSlim для синхронизации

        public FileService() 
        {
            _readServices = new ReaderJsonServices();
            _writeServices = new WriterJsonServices();
        }

        public async Task<List<User>> AddUser(User user)
        {
            await _semaphore.WaitAsync();
            
            try
            {
                var allData = await _readServices.ReadDataAsync();
                allData.Add(user);

                await _writeServices.WriteUserDataAsync(allData);

                return allData;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public async Task<List<User>> Delete(User user)
        {
            await _semaphore.WaitAsync();
            try
            {
                var allData = await _readServices.ReadDataAsync();
                allData.RemoveAll(item => item.Equals(user));

                await _writeServices.WriteUserDataAsync(allData);

                return allData;
            }
            finally  
            {
                _semaphore.Release();
            }
        }

        public async Task<List<User>> DeleteByPhone(string phone)
        {
            await _semaphore.WaitAsync();
            try
            {
                var allData = await _readServices.ReadDataAsync();
                allData.RemoveAll(item => item.Phone == phone);

                await _writeServices.WriteUserDataAsync(allData);

                return allData;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public async Task<List<User>> GetAllUsers()
        {
            await _semaphore.WaitAsync();

            try
            {
                return await _readServices.ReadDataAsync();
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public async Task<User> GetUserByPhone(string phone)
        {
            await _semaphore.WaitAsync();

            try
            {
                var allData = await _readServices.ReadDataAsync();

                return allData.Where(i => i.Phone == phone).FirstOrDefault();
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public async Task<List<User>> UpdateUser(User user)
        {
            await _semaphore.WaitAsync();

            try
            {
                var allData = await _readServices.ReadDataAsync();

                allData.RemoveAll(item => item.Phone == user.Phone);
                allData.Add(user);

                await _writeServices.WriteUserDataAsync(allData);

                return allData;
            }
            finally
            {
                _semaphore.Release();
            }
        }
    }
}
