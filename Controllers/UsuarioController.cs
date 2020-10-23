using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RpgMvc.Models;

namespace RpgMvc.Controllers
{
    public class UsuarioController : Controller
    {
        public string uriBase ="http://andernine.somee.com/RpgApi/Usuarios/";
        


        //Método responsável em carregar a View de Cadastro de usuário
        [HttpGet]
        public ActionResult Index()
        {
            return View("CadastrarUsuario");
        }

        //Método responsável em postar os dados na API
        [HttpPost]
        public async Task<ActionResult> RegistrarAsync(UsuarioViewModel u)
        {
            HttpClient httpClient = new HttpClient();
            string uriComplementar = "Registrar";

            var content = new StringContent(JsonConvert.SerializeObject(u));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar, content);

            string serialized = await response.Content.ReadAsStringAsync();
            int id = 0;

            if(!int.TryParse(serialized, out id))
            {
                //TryParse: Tenta converter o retorno da requisição para inteiro. Entrará aqui se não conseguir
                TempData["MensagemErro"] = serialized;
                return RedirectToAction("Index");
            }
            else
            {
                //Caso o retorno seja um número inteiro, estará armazenado em Id
                TempData["Mensagem"] = 
                string.Format("Usuário Id {0} registrado com sucesso. Faça login para acessar.", id);

                return View("AutenticarUsuario");
            }
        }

    }
}