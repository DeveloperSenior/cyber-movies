using System.Text.Json.Serialization;

namespace CyberMovies
{
	public class PokemonSprite
	{
		public string front_default { get; set; }
        public PokemonSpriteOther other { get; set; }

    }

    public class PokemonSpriteOther { 


    [JsonPropertyName("official-artwork")]
    public PokemonSpriteOtherOfficialArtWork official_artwork { get; set; }

    }
    public class PokemonSpriteOtherOfficialArtWork
    {
        public string front_default { get; set; }

    }
}
