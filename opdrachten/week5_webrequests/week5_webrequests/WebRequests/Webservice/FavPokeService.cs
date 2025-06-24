using System.Net.Http;
using System.Text.Json;

namespace WebRequests.Webservice
{
    public class FavPokeService
    {
        public string GetFavPokemonJson()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/ditto";
            using (HttpClient httpClient = new HttpClient())
            {
                string result = httpClient.GetStringAsync(url).Result;
                return result;
            }
        }

        public Pokemon GetFavoritePokemon()
        {
            string json = GetFavPokemonJson();
            Pokemon poke = JsonSerializer.Deserialize<Pokemon>(json);
            return poke;
        }
    }

    public class Pokemon
    {
        public string name { get; set; }
        public int height { get; set; }
        public Sprite sprites { get; set; }
    }

    public class Sprite
    {
        public string front_default { get; set; }
    }