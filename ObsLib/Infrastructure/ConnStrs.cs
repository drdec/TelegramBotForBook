using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Infrastructure
{
    internal class ConnStrs
    {
        internal const string Autentifications = "v2/clients/v2Authentication";
        internal const string Authorization = "v2/clients/authorization";

        internal const string BaseURL = "https://api.obs.by/";
        internal const string Transfers = "transfers/betweenCities";
        internal const string AllRouts = "cities/forBooking";
        internal const string Books = "reservations/book";
        /// <summary>
        /// Обязательно подставить номер телефона!!!!
        /// Просто прибавить к основной строке
        /// </summary>
        internal const string Profile = "clients/withReservations/";
    }
}
