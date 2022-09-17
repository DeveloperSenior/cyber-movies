using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms;
using CyberMovies.Resources.Themes;

namespace CyberMovies.Views
{
    public partial class ThemeSelectionPage : ContentPage, IModalPage
    {
        public ThemeSelectionPage()
        {
            InitializeComponent();
        }

        void OnPickerSelectionChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            Theme theme = (Theme)picker.SelectedItem;

            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();

                switch (theme)
                {
                    case Theme.Dark:
                        mergedDictionaries.Add(new DarkTheme());
                        break;
                    case Theme.Light:
                    default:
                        mergedDictionaries.Add(new LightTheme());
                        break;
                }
            }
        }

        public async Task Dismiss()
        {
            await Navigation.PopModalAsync();
        }
    }
}
