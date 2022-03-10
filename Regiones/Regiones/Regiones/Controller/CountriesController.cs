using System;
using System.Collections.Generic;
using System.Text;
using Regiones.Models;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Regiones.Controller
{
    public class CountriesController
    {
        public async static Task<List<Countries.CountriesRest>> ObtenerRegiones(String pRegion)
        {
            List<Countries.CountriesRest> lstRegiones = new List<Countries.CountriesRest>();
            String url = "https://restcountries.com/v3.1/region/" + pRegion;
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    lstRegiones = JsonConvert.DeserializeObject<List<Countries.CountriesRest>>(contenido);
                }

            }

            return lstRegiones;
        }
    }
}
