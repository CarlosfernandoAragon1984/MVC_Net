using CapaPresentacionAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacionAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Usuarios()
        {
            return View();
        }
        public JsonResult ListaUsuario()
        {
            List<Usuario> lista=new List<Usuario>();
            ListarUsuario usuarioLista= new ListarUsuario();
            lista = usuarioLista.Listar();

            //UsuarioNegocio negocio=new UsuarioNegocio();
           // negocio.GetAllUsuario();
            return Json(lista);
          
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
