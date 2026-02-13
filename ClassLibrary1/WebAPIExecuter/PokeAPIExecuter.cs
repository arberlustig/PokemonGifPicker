using System.Net.Http.Json;
using Core.APIModel;
using Microsoft.Extensions.Http;

namespace Core.WebAPIExecuter
{
    public class PokeApiExecuter    
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public PokeApiExecuter(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<Root?> GetPokemonResponse(string pokemonName)
        {
            var client = await _httpClientFactory.CreateClient("PokeAPI")
                .GetAsync($"pokemon/{pokemonName}");

            client.EnsureSuccessStatusCode();

            return await client.Content.ReadFromJsonAsync<Root>();


        }

    }
}
