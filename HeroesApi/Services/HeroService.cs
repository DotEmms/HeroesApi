using HeroesApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesApi.Services
{
    public class HeroService : IHeroService
    {
        private HeroesApiContext _context;
        public HeroService(HeroesApiContext context)
        {
            _context = context;
        }
        public async Task<List<Hero>> GetHeroesAsync()
        {
            return await _context.Heroes.ToListAsync();
        }
        public async Task<Hero> GetHeroAsync(int id)
        {
            return await _context.Heroes.FindAsync(id);
        }

        public async Task AddHeroAsync(Hero hero)
        {
            await _context.Heroes.AddAsync(hero);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateHeroAsync(Hero hero)
        {
            _context.Heroes.Update(hero);
            await _context.SaveChangesAsync();
        }

        public void DeleteHero(Hero hero)
        {
            _context.Heroes.Remove(hero);
        }
    }
}
