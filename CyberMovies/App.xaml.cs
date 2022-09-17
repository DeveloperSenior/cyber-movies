using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CyberMovies
{
    public partial class App : Application
    {
        public static PokemonItemManager PokemonManager { get; private set; }

        public App()
        {
            InitializeComponent();
            PokemonManager = new PokemonItemManager(new RestService());
            MainPage = new NavigationPage(new Views.MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
