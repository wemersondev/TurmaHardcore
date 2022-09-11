using AulaUmTurmaH.Presentation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace AulaUmTurmaH.Presentation.Controllers
{

    public class MateriaController : Controller
    {

        private string _token { get; set; }

        private List<Materia> ListaMateria { get; set; }


        public IActionResult Index()
        {
            Task Tarefa1 = GetToken();
            Tarefa1.Wait();

            Task Tarefa2 = GetMateria(_token);
            Tarefa2.Wait();
            return View(ListaMateria);
        }


        #region METODOS PARA CONSUMO JWT
        private async Task GetToken()
        {
            string url = "http://turmamharda-001-site1.atempurl.com/api/Autenticacao/entrar";

            using (var cliente = new HttpClient())
            {

                string JsonObjeto = JsonConvert.SerializeObject(new Usuario { Email = "iann@email.com", Senha = "@Teste123" });

                var content = new StringContent(JsonObjeto, Encoding.UTF8, "application/json");

                var resuldado = cliente.PostAsync(url, content).Result;

                if (resuldado.IsSuccessStatusCode)
                {
                    var tokenJson = await resuldado.Content.ReadAsStringAsync();

                    _token = tokenJson.ToString();
                }

            }

        }

        private async Task GetMateria(string tokenAcess)
        {


            using (var client = new HttpClient())
            {
                var url = "http://turmamharda-001-site1.atempurl.com/api/Materia";
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + tokenAcess);
                var response = await client.GetStringAsync(url);

                var listaRetorno = JsonConvert.DeserializeObject<Materia[]>(response).ToList();               

                ListaMateria = listaRetorno;
            }


        }
        #endregion

    }
}
