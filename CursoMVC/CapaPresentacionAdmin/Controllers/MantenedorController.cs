﻿using Microsoft.AspNetCore.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class MantenedorController : Controller
    {
        public IActionResult Categoria()
        {
            return View();
        }
        public IActionResult Marca()
        {
            return View();
        }
        public IActionResult Producto()
        {
            return View();
        }
    }
}
