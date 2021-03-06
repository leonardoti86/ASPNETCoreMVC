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
            var palavras = _db.Palavras.ToList();
            return View(palavras);
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
            if (ModelState.IsValid)
            {
                _db.Palavras.Add(palavra);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Atualizar(int Id)
        {
            Palavra palavra = _db.Palavras.Find(Id);

            return View("Cadastrar", palavra);
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