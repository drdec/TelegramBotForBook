﻿using ObsLib.Models.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsLib.Managers.Interfaces
{
    internal interface IProfileManager
    {
        Task<Reservations> GetData();
    }
}
