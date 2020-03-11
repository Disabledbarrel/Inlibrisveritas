using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;


namespace InlibrisVeritas.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IndexModel model)
        {
            if (ModelState.IsValid)
            {
                // Skicka epost

                ViewBag.UserMessage = "E-post skickat";
                ModelState.Clear(); // rensar formulär
            }

            return View();
        }
    }
}
