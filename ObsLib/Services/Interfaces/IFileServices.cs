using ObsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Services.Interfaces
{
    internal interface IFileServices
    {
        /// <summary>
        /// Добавить нового пользователя
        /// </summary>
        /// <param name="user">Данные о пользователе</param>
        /// <returns>Спислк пользователей</returns>
        Task<List<User>> AddUser(User user);
        /// <summary>
        /// Обновить данные пользователя
        /// </summary>
        /// <param name="user">Обновленный объект. Проверяет по номеру телефона</param>
        /// <returns>Список пользователей</returns>
        Task<List<User>> UpdateUser(User user);
        /// <summary>
        /// Возвращает пользователя по номеру телефона
        /// </summary>
        /// <param name="phone">номер телеофна</param>
        /// <returns>Найденого пользователя или пустой объект</returns>
        Task<User> GetUserByPhone(string phone);
        /// <summary>
        /// Возвращает весь список пользователей
        /// </summary>
        /// <returns>Список пользователей</returns>
        Task<List<User>> GetAllUsers();
        /// <summary>
        /// Удаляет заданного пользователя
        /// </summary>
        /// <param name="user">Объект пользователя</param>
        /// <returns>Обновленный списко пользователей</returns>
        Task<List<User>> Delete(User user);
        /// <summary>
        /// Удаляет пользователя по номеру телефона
        /// </summary>
        /// <param name="phone">Номер телефона</param>
        /// <returns>Обновленный список пользователей</returns>
        Task<List<User>> DeleteByPhone(string phone);
    }
}
