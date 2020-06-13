using Microsoft.AspNetCore.Mvc;
using SeresProducoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace SeresProducoes.Controllers
{
    [Route("[controller]")]
    public class ContactController : Controller
    {
        public IActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(ContactModel contactModel)
        {
            if (ModelState.IsValid)
            {
                string from = contactModel.Email;
                string to = "2016213635@ufs4life.ac.za";

                //send email
                try
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress($"{contactModel.Name}", $"{from}"));
                    message.To.Add(new MailboxAddress("Seres Producoes", $"{to}"));
                    message.Subject = "Mail From the Web App";
                    message.Body = new TextPart("plain")
                    {
                        Text = $"{contactModel.Message}"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 587, false);

                        // Note: only needed if the SMTP server requires authentication
                        client.Authenticate($"{from}", "T^9a*updown");

                        client.Send(message);
                        client.Disconnect(true);
                    }

                    //email confirmation
                    return RedirectToAction("Complete");
                }
                catch (Exception ex)
                {
                    return RedirectToAction("Error");
                }
            }
            else
                return View(contactModel);
        }
        [Route("/Complete")]
        public IActionResult Complete() => View();
        [Route("/error")]
        public IActionResult Error() => View();
    }
}
