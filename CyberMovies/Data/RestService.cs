using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Linq;

namespace CyberMovies
{
    public class RestService : IRestService
    {
        HttpClient client;
        JsonSerializerOptions serializerOptions;

        public List<PokemonItem> Items { get; private set; }
        public List<AvailablePokemon> Pokemones;

        public RestService()
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<List<PokemonItem>> RefreshDataAsync(string pokemon)
        {
            Items = new List<PokemonItem>();

            if ("all".Equals(pokemon))
            {
                Pokemones = Enum.GetValues(typeof(AvailablePokemon)).Cast<AvailablePokemon>().ToList();

            }
            else
            {
                var poke = Enum.Parse(typeof(AvailablePokemon), pokemon,true);
                Pokemones = new List<AvailablePokemon> { (AvailablePokemon)poke };

            }
            foreach (var item in Pokemones) { 
                Uri uri = new Uri(string.Format(Constants.RestUrl, item.ToString().ToLower()));
                try
                {
                    HttpResponseMessage response = await client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        Items.Add(JsonSerializer.Deserialize<PokemonItem>(content, serializerOptions));
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(@"\tERROR {0}", ex.Message);
                }
            }


            return Items;
        }

    }
}
