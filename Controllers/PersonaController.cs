using BasicSecurity.Models;
using BasicSecurity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicSecurity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;

        public PersonaController(IPersonaService personaService) { _personaService = personaService; }

        [HttpGet]
        public async Task<IEnumerable<Persona>> Get() => await _personaService.Get();
    }
}
