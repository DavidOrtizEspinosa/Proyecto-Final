using Newtonsoft.Json;
using ProyectoFinal.Clases;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DAO
{
    class Proveedor
    {
        public static List<Camara> GetCamaras()
        {
            var client = new RestClient(Properties.Settings.Default.url);
            var request = new RestRequest("camaras", Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<List<Camara>>(response.Content);
        }

        public static List<Usuario> GetUsuarios()
        {
            var client = new RestClient(Properties.Settings.Default.url);
            var request = new RestRequest("usuarios", Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<List<Usuario>>(response.Content);
        }
    }
}
