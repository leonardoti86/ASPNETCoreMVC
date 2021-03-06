using Microsoft.AspNetCore.Mvc;
using Site01.Database;
using Site01.Models;
using System.Linq;

namespace Site01.Controllers
{
    public class PalavraController : Controller
    {
        public DatabaseContext _db { get; set; }
        
        public PalavraController(DatabaseContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Listar todas as palavras do banco de dados
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ViewBag.Palavras = _db.Palavras.ToList();
            return View();
        }

        //CRUD

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar([FromForm]Palavra palavra)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Atualizar()
        {
            return View("Cadastrar");
        }

        [HttpPost]
        public ActionResult Atualizar([FromForm]Palavra palavra)
        {
            return View("Cadastrar");
        }

        [HttpGet]
        public ActionResult Excluir(int Id)
        {
            return RedirectToAction("Index");
        }
    }
}