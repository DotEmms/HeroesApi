using HeroesApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeroesApi.Services
{
    public interface IHeroService
    {
        Task AddHeroAsync(Hero hero);
        void DeleteHero(Hero hero);
        Task<Hero> GetHeroAsync(int id);
        Task<List<Hero>> GetHeroesAsync();
        Task UpdateHeroAsync(Hero hero);
    }
}