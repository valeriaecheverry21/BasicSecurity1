using BasicSecurity.Models;
using System.Text.Json;

namespace BasicSecurity.Services
{
    public class PersonaService : IPersonaService

    {
        string path = "";

        public async Task<List<Persona>> Get() 
        {
            string content = await File.ReadAllTextAsync(path);
            var personas = JsonSerializer.Deserialize<List<Persona>>(content);
            return personas;
        }
    }
}
