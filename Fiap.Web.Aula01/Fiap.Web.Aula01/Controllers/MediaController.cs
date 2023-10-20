using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Aula01.Controllers
{
    public class MediaController : Controller
    {
        [HttpGet]
        public IActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(float media1, float media2)
        {
            //calcular a m�dia
            float media = media1 * 0.4f + media2 * 0.6f;
            //Enviar a m�dia para a p�gina
            if (media > 6)
                ViewBag.churros = $"Aprovado! M�dia {media}";
            else
                ViewBag.churros = $"Tente novamente! M�dia {media}";
            return View();
        }
    }
}