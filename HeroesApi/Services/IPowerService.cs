using HeroesApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeroesApi.Services
{
    public interface IPowerService
    {
        Task AddPowerAsync(Power power);
        void DeletePower(Power power);
        Task<Power> GetPowerAsync(int id);
        Task<List<Power>> GetPowersAsync();
        Task UpdatePowerAsync(Power power);
    }
}