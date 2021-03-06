using Microsoft.AspNetCore.Mvc;
using Site01.Models;

namespace Site01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return new ContentResult() { Content = "Ola mundo!", ContentType = "text/json" };
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([FromForm]Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Email.Equals("leopanzer@gmail.com") && usuario.Senha.Equals("123456"))
                {
                    return RedirectToAction("Index","Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "Os dados informados são inválidos!";
                }
            }

            return View();
        }
    }
}