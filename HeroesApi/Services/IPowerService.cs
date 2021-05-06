﻿using HeroesApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeroesApi.Services
{
    public interface IPowerService
    {
        Task AddPowerAsync(Power power);
        Task DeletePowerAsync(int id);
        Task<Power> GetPowerAsync(int id);
        Task<List<Power>> GetPowersAsync();
        Task UpdatePowerAsync(Power power);
    }
}