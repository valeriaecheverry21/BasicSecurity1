using BasicSecurity.Models;

namespace BasicSecurity.Services
{
    public interface IPersonaService
    {
        public Task<List<Persona>> Get();
    }
}
