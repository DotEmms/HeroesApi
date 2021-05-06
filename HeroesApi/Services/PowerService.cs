using HeroesApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesApi.Services
{
    public class PowerService : IPowerService
    {
        private HeroesApiContext _context;
        public PowerService(HeroesApiContext context)
        {
            _context = context;
        }
        public async Task<List<Power>> GetPowersAsync()
        {
            return await _context.Powers.ToListAsync();
        }
        public async Task<Power> GetPowerAsync(int id)
        {
            return await _context.Powers.FindAsync(id);
        }

        public async Task AddPowerAsync(Power power)
        {
            await _context.Powers.AddAsync(power);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePowerAsync(Power power)
        {
            _context.Powers.Update(power);
            await _context.SaveChangesAsync();
        }

        public void DeletePowerAsync(Power power)
        {
            
            _context.Powers.Remove(power);

            _context.SaveChangesAsync();
        }
    }
}
