using Newtonsoft.Json;
using Sistema_Cobranza.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Cobranza.Servicio
{

    
    class UsuarioService { 
   
        protected string APIURL = ConfigurationManager.AppSettings.Get("ApiUrl");


        public void Login()
        {
            string epLogin = APIURL + "auth/login";

            Console.WriteLine(epLogin);
            
        }

        public async Task<List<User>> ListarUsuarios()
        {
            string endpoint = APIURL + "users";

            using (HttpClient httpClient = new HttpClient())
            {
              

                var response = await httpClient.PostAsync(endpoint, null); // Si no se envía ningún contenido

                // Verificar si la solicitud fue exitosa
                response.EnsureSuccessStatusCode();

                // Leer el contenido de la respuesta
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserializar el JSON al modelo Usuario
                List<User> users = JsonConvert.DeserializeObject<List<User>>(responseBody);

                // Devolver la lista de usuarios
                return users;
            }
        }

    }

 }
