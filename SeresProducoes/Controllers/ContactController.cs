using Microsoft.AspNetCore.Mvc;
using SeresProducoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace SeresProducoes.Controllers
{
    [Route("[controller]")]
    public class ContactController : Controller
    {
        MailMessage mail = new MailMessage();
        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com", 587);

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
                    mail.From = new MailAddress(from);
                    mail.To.Add(to);
                    mail.Subject = "Mesasge from site-" + contactModel.Name.ToUpper();
                    mail.Body = contactModel.Message;

                    smtpServer.UseDefaultCredentials = false;
                    smtpServer.Credentials = new NetworkCredential("2016213635@ufs4life.ac.za", "T^9a**21kyTem");
                    smtpServer.EnableSsl = true;
                    smtpServer.Send(mail);
                    
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
