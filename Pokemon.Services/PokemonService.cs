using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Pokemon.Services
{
    public class PokemonService
    {
        IConfiguration _configuration;
        private PokemonHttpClient _client;

        public PokemonService(IConfiguration configuration, PokemonHttpClient client)
        {
            _configuration = configuration;
            _client = client;
        }

        public async Task<Pokemon.Models.PokemonAttributes> GetPokemonAsync(string name)
        {
            var result = await _client.FetchPokemonByNameAsync(name);

            return JsonConvert.DeserializeObject<Pokemon.Models.PokemonAttributes>(result);
        }
    }
}
