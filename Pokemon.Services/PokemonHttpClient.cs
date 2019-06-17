using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Pokemon.Services
{
    public class PokemonHttpClient
    {
        public HttpClient Client { get; }
        public PokemonHttpClient(HttpClient client)
        {
            Client = client;
        }
    }
}
