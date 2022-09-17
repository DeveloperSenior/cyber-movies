using Xamarin.Essentials;
using Xamarin.Forms;

namespace CyberMovies
{
    public static class Constants
    {
        // URL of REST service
        //public static string RestUrl = "https://YOURPROJECT.azurewebsites.net:8081/api/todoitems/{0}";

        // URL of REST service (Android does not use localhost)
        // Use http cleartext for local deployment. Change to https for production
        public static string RestUrl = "https://pokeapi.co/api/v2/pokemon/{0}";
    }

    public enum AvailablePokemon
    {
        Pikachu,
        Ditto,
        Abra,
        Absol,
        Arbok,
        Arcanine,
        Caterpie,
        Charmander,
        Charmeleon,
        Charizard,
        Dugtrio,
        Pichu,
        Pidgeotto

    }
}
