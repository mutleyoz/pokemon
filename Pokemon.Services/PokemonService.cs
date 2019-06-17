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

        public async Task<Pokemon.Models.Pokemon> GetPokemon(int id)
        {
            var result = await _client.Client.GetStringAsync($"/v2/pokemon/{id}");

            return JsonConvert.DeserializeObject<Pokemon.Models.Pokemon>(result);
        }

    }
}
