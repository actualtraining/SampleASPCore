using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PDGICoreApps.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.FirstName = "Erick";
            ViewBag.LastName = "Kurniawan";
            ViewData["Email"] = "erick@actual-training.com";
            return View();
        }

        public IActionResult Contact(string firstname,string lastname,string gender,
            string[] language,string country,string summary,DateTime birthdate,int quality)
        {
            ViewData["firstname"] = firstname;
            ViewData["lastname"] = lastname;
            ViewData["gender"] = gender;
            ViewData["language"] = language;
            ViewData["country"] = country;
            ViewData["summary"] = summary;
            ViewData["birthdate"] = birthdate;
            ViewData["quality"] = quality;
            //return Content(birthdate.ToString());

            return View();
        }

        public IActionResult LuasSegitiga()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LuasSegitiga(double alas,double tinggi)
        {
            double hasil = 0.5 * alas * tinggi;
            ViewData["hasil"] = hasil;

            return View();
        }
    }
}