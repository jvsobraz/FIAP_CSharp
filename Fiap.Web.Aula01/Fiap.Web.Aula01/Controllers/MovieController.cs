using Fiap.Web.Aula01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Aula01.Controllers
{
    public class MovieController : Controller
    {
        [HttpGet] //Abrir a p�gina HTML com o formul�rio
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] //Receber os parametros do formulario ap�s o submit
        public IActionResult Index(Movie movie)
        {
            //Enviar o nome do filme para a p�gina
            ViewData["churros"] = movie.Nome;
            ViewBag.mochila = movie;
            return View();
            //Envia um texto para o browser
            //return Content($"Nome: {movie.Nome}, Ano: {movie.Ano}," +
            //    $" Faturamento: {movie.Faturamento}");
        }
    }
}