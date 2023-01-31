using FiltroGitHubASP.Interfaces;
using FiltroGitHubASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using System.Xml.Linq;

namespace FiltroGitHubASP.Controllers
{
    [ApiController]
    [Route("controller")]
    public class RepositorioController : Controller
    {

        private readonly string urlApi = "http://localhost:5080/";

        public RepositorioGitModel GetOne(string name)
        {
            var repositorioGet = new RepositorioGitModel();
            repositorioGet.Name = name;

            try
            {
                using (var cliente = new HttpClient())
                {
                    string jsonObjeto = JsonSerializer.Serialize(repositorioGet);
                    var content = new StringContent(jsonObjeto, Encoding.UTF8, "application/json");
                    var resposta = cliente.PostAsync(urlApi + "getApiGitHub", content);
                    resposta.Wait();

                    if (resposta.Result.IsSuccessStatusCode)
                    {
                        var retorno = resposta.Result.Content.ReadAsStringAsync();
                        repositorioGet = JsonSerializer.Deserialize<RepositorioGitModel>(retorno.Result);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return repositorioGet;
        }
    }
}
