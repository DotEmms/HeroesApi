using HeroesApi.Entities;
using HeroesApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class HeroController : ControllerBase
    {
        private IHeroService _service;
        public HeroController(HeroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Hero>> GetAsync()
        {
            return await _service.GetHeroesAsync();
        }

        [HttpGet("{id}")]
        public async Task<Hero> GetHeroAsync(int id)
        {
            return await _service.GetHeroAsync(id);
        }

        [HttpPost]
        public async Task AddAsync(Hero hero)
        {
            await _service.AddHeroAsync(hero);
        }

        [HttpPut]
        public async Task PutAsync(Hero hero)
        {
            await _service.UpdateHeroAsync(hero);
        }

        [HttpDelete]
        public void DeleteHero(Hero hero)
        {
            _service.DeleteHero(hero);
        }
    }
}
