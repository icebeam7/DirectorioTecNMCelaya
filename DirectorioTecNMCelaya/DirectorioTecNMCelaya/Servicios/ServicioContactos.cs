using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DirectorioTecNMCelaya.Helpers;
using DirectorioTecNMCelaya.Modelos;

namespace DirectorioTecNMCelaya.Servicios
{
    public static class ServicioContactos
    {
        private static readonly HttpClient cliente = CrearHttpClient();

        private static HttpClient CrearHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Constantes.AzureFunctionEndpoint);
            return httpClient;
        }

        public async static Task<List<Contacto>> ObtenerContactos()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await cliente.GetAsync(Constantes.AzureFunctionEndpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<Contacto>>(json);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return new List<Contacto>();
        }

        public static List<Contacto> BuscarContactos(List<Contacto> lista, string busqueda)
        {
            return lista.Where(p =>
                CultureInfo.CurrentCulture.CompareInfo.IndexOf(
                    p.Nombre, busqueda, CompareOptions.IgnoreCase) >= 0)
                .ToList();
        }
    }
}
