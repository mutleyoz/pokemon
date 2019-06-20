using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Services
{
    public class PokemonHttpClient
    {
        private HttpClient _client;

        public PokemonHttpClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> FetchPokemonByNameAsync(string name)
        {
            var result = await _client.GetStringAsync($"v2/pokemon/{name}");

            return result;
        }
    }
}
