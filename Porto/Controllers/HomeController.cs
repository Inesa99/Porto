using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Porto.Models;
using Microsoft.IdentityModel.Tokens;

namespace Porto.Controllers
{
    public class HomeController : Controller
    {
        private const string CultureCookieName = "UserCulture";

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Live()
        {
            return View();
        }

        public IActionResult Work()
        {
            return View();
        }

        public IActionResult Integrate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(string userType, string email, string message)
        {
            if (!(message.IsNullOrEmpty() && email.IsNullOrEmpty() && userType.IsNullOrEmpty()))
            {
                var currentCulture = Request.Cookies["UserCulture"] ?? "en";
                var cultureInfo = new System.Globalization.CultureInfo(currentCulture);
                Thread.CurrentThread.CurrentCulture = cultureInfo;
                Thread.CurrentThread.CurrentUICulture = cultureInfo;

                var subject = AppRes.ContactUsSubject;
                string body;

                body = $"<h1>{AppRes.Email} - {email}</h1>" +
                $"<h2>{AppRes.UserType} {userType}</h2>" +
                $"<h2>{AppRes.MessageContent}<h2><br/><p>{message}</p>";

                SendEmail(subject, body);

                return RedirectToAction("Index");
            }


            return RedirectToAction("Index");
        }
        private readonly string fromEmail = "kurdyangaya@gmail.com";
        private readonly string password = "iwpo ljnf zqbu ylty";

        public void SendEmail(string subject, string body, string toEmail = "kurdyangaya@gmail.com")
        {
            var fromAddress = new MailAddress(fromEmail, "Your Name");
            var toAddress = new MailAddress(toEmail);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail, password)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
            {
                smtp.Send(message);
            }
        }
        public IActionResult ChangeLanguage(string lang)
        {
            Response.Cookies.Append(CultureCookieName, lang, new Microsoft.AspNetCore.Http.CookieOptions
            {
                Expires = DateTime.UtcNow.AddYears(1),
                IsEssential = true,
                SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax
            });

            return RedirectToAction("Index");
        }
    }
}
