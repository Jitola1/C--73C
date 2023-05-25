using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace AulaaspViewControl.Controllers
{
    public class CarroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string TextoSimples(string nome, int idade){
            return $"Olá {nome}!!! \n Sua idade: {idade}";
        }

        public IActionResult Dados(String veiculo, string marca, int ano)
        {
            ViewData["Veiculo"] = veiculo;
            ViewData["Marca"] = marca;
            ViewData["Ano"] = ano;
            return View();
        }
    }
}
