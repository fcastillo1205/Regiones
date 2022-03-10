using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Regiones.Models;
using Plugin.Geolocator;

namespace Regiones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageRegiones : ContentPage
    {
        public PageRegiones()
        {
            InitializeComponent();
        }

        private async void pickerRegiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Models.Countries.CountriesRest> regiones = new List<Models.Countries.CountriesRest>();
            regiones = await Controller.CountriesController.ObtenerRegiones(pickerRegiones.SelectedItem.ToString());
            listaRegioens.ItemsSource = regiones;
        }

        private async void listaRegioens_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var ubic = new Countries.CountriesRest();
            var obj = (Countries.CountriesRest)e.SelectedItem;
            if (!string.IsNullOrEmpty(obj.name.ToString()))
            {
                bool mosrar = await DisplayAlert("Mensaje", "Desea ver en el mapa", "Si", "No");
                if (mosrar)
                {
                    await Navigation.PushAsync(new NavigationPage(new Mapa(Convert.ToDouble(obj.latlng[0].ToString()),
                                                                       Convert.ToDouble(obj.latlng[1].ToString()),
                                                                       obj.translations.spa.common.ToString(),
                                                                       obj.region.ToString(),
                                                                       obj.subregion.ToString(),
                                                                       obj.capital[0].ToString(),
                                                                       obj.population.ToString())));
                }               

            }
        }
    }
}