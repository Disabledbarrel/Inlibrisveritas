using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using InlibrisVeritas.Models;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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

                // Från
                String From = "kontakt@inlibrisveritas.se";
                String FromName = "In libris veritas";

                // E-post att skicka till
                String To = "kontakt@inlibrisveritas.se";

                // Amazon SES SMTP användare
                String SmtpUser = "användare";

                // smtp_password
                String SmtpPassword = "password";


                // Adress för smtp-server
                String Host = "email-smtp.eu-west-1.amazonaws.com";

                // Port på server
                int Port = 587;

                // Rubrik i e-post
                String Subject = indexViewModel.Subject;

                // Innehåll i e-post
                String Body = "Från: " + indexViewModel.Email + "<br />Namn: " + indexViewModel.Name + "<br />Meddelande: " + indexViewModel.Message;

                // Skapar e-postobjekt
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(From, FromName);
                message.To.Add(new MailAddress(To));
                message.Subject = Subject;
                message.Body = Body;
               
                // Skapar anslutning
                using (var client = new System.Net.Mail.SmtpClient(Host, Port))
                {
                    client.Credentials =
                        new NetworkCredential(SmtpUser, SmtpPassword);

                    client.EnableSsl = true;

                    // Försöka skicka meddelande. Visa felmeddelande i console.
                    try
                    {
                        client.Send(message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("The email was not sent.");
                        ViewBag.UserMessage = "Felmeddelande: " + ex.Message;
                    }
                }

                ModelState.Clear();

            }
            ViewBag.UserMessage = "E-post skickat";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
