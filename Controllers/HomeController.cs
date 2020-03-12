using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using InlibrisVeritas.Models;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MailKit.Security;

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
        public IActionResult Index(IndexViewModel indexViewModel)
        {
            if (ModelState.IsValid)
            {
                // Skicka e-post

                ModelState.Clear();

            }
            ViewBag.UserMessage = "E-post skickat";
            return View();
        }
    }
}
