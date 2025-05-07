using Microsoft.AspNetCore.Mvc;
using Projeto1.Repositorio;

namespace Projeto1.Controllers
{
    public class UsuarioController : Controller
    {
        // declarando uma variável privada somente para leitura do tipo usuarioRepositório chamada _usuarioRepositorio
        private readonly UsuarioRepositorio _usuarioRepositorio;

        /*ddfinido o construtor da classe UsuarioController que vai receber uma instancia 
         de UsuarioRepositorio*/
        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
    }
}
