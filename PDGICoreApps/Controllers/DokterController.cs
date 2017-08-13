using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using PDGICoreApps.Models;

namespace PDGICoreApps.Controllers
{
    public class DokterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Dokter dokter)
        {
            return View("Tampil",dokter);
        }
    }
}