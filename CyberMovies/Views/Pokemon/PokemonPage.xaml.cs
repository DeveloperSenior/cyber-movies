using CyberMovies.Resources.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CyberMovies.Views
{
    public partial class PokemonPage : ContentPage
    {
        public PokemonPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.PokemonManager.GetTasksAsync();
        }


        async void OnGetPokemonToolbarItemClicked(object sender, EventArgs e)
        {
            listView.ItemsSource = await App.PokemonManager.GetTasksAsync();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
        }

        async void OnPickerSelectionChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            AvailablePokemon pokemon = (AvailablePokemon)picker.SelectedItem;
            string name = pokemon.ToString().ToLower();
            listView.ItemsSource = await App.PokemonManager.GetTasksAsync(name);


        }

    }

}