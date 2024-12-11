using PokeApiNet;

namespace WebApp.Services
{
    public class PokeApiService
    {
        private readonly PokeApiClient _pokeApiClient;

        public PokeApiService()
        {
            _pokeApiClient = new PokeApiClient();
        }

        public async Task<List<Pokemon>> GetAllPokemonAsync(int limit = 100, int offset = 0)
        {
            var pokemonPage = await _pokeApiClient.GetNamedResourcePageAsync<Pokemon>(limit, offset);
            var pokemonList = new List<Pokemon>();

            foreach (var resource in pokemonPage.Results)
            {
                var pokemon = await _pokeApiClient.GetResourceAsync(resource);
                pokemonList.Add(pokemon);
            }

            return pokemonList;
        }
    }
}
