using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Regiones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mapa : ContentPage
    {
        
        public Mapa(double pLatitud, double pLongitud, string pNombrePais, string pRegion, string pSubRegion, string pCapital, string pPoblacion)
        {
            InitializeComponent();

            nombrePais.Text = pNombrePais;
            region.Text = pRegion;
            subregion.Text = pSubRegion;
            capital.Text = pCapital;
            Poblacion.Text = pPoblacion;
            
            Pin pin = new Pin
            {
                Label = pNombrePais,
                Address = "ubicacion",
                Type = PinType.Place,
                Position = new Position(pLatitud, pLongitud)
            };
            MapaPais.Pins.Add(pin);
            MapaPais.MoveToRegion(mapSpan: MapSpan.FromCenterAndRadius(new Position(pLatitud, pLongitud), Distance.FromKilometers(1)));

        }
    }
}