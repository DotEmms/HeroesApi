using HeroesApi.Entities;
using HeroesApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeroesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class PowerController : ControllerBase
    {
        private IPowerService _service;
        public PowerController(IPowerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Power>> Get()
        {
            return await _service.GetPowersAsync();
        }

        [HttpGet("{id}")]
        public async Task<Power> Get(int id)
        {
            return await _service.GetPowerAsync(id);
        }

        [HttpPost]
        public async Task Add(Power power)
        {
            await _service.AddPowerAsync(power);
        }

        [HttpPut]
        public async Task Put(Power power)
        {
            await _service.UpdatePowerAsync(power);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _service.DeletePowerAsync(id);
        }
    }
}
