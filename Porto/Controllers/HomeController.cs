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
        private readonly string fromEmail = "jul18simonyan@gmail.com";
        private readonly string password = "okfnrtxzkzrprbes"; // Gmail App Password
        private readonly string displayName = "Discover Campanha Website";

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
            if (!userType.IsNullOrEmpty() && !email.IsNullOrEmpty() && !message.IsNullOrEmpty())
            {
                var currentCulture = Request.Cookies["UserCulture"] ?? "en";
                var cultureInfo = new System.Globalization.CultureInfo(currentCulture);
                Thread.CurrentThread.CurrentCulture = cultureInfo;
                Thread.CurrentThread.CurrentUICulture = cultureInfo;

                var subject = AppRes.ContactUsSubject;
                string body = $@"
                    <div style='font-family:Segoe UI,Arial,sans-serif;color:#333;padding:20px;'>
                        <h2 style='color:#007bff;'>Contact Request from Discover Campanha Website</h2>
                        <p><strong>{AppRes.Email}:</strong> {email}</p>
                        <p><strong>{AppRes.UserType}:</strong> {userType}</p>
                        <hr />
                        <h3>{AppRes.MessageContent}</h3>
                        <p>{message}</p>
                        <br/>
                        <p style='font-size:12px;color:#777;'>This message was sent automatically from the Porto contact form.</p>
                    </div>";

                try
                {
                    SendEmail(subject, body);
                    TempData["Success"] = "Your message was sent successfully!";
                }
                catch (Exception ex)
                {
                    // Log it — in production, use a proper logging service (Serilog, NLog, etc.)
                    System.IO.File.AppendAllText("email_error.log", $"{DateTime.Now}: {ex}\n");
                    TempData["Error"] = "We couldn’t send your message. Please try again later.";
                }
            }

            return RedirectToAction("Index");
        }

        private void SendEmail(string subject, string body, string toEmail = "jul18simonyan@gmail.com")
        {
            var fromAddress = new MailAddress(fromEmail, displayName);
            var toAddress = new MailAddress(toEmail);

            using (var smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(fromEmail, password);

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
        }
        [HttpPost]
        public IActionResult SubmitCV(IFormFile cvFile, string email)
        {
            if (cvFile == null || string.IsNullOrEmpty(email))
            {
                TempData["CVError"] = "Please provide both email and CV file.";
                return RedirectToAction("Work");
            }

            try
            {
                // Convert file to memory stream
                using (var memoryStream = new MemoryStream())
                {
                    cvFile.CopyTo(memoryStream);
                    memoryStream.Position = 0;

                    // Compose email
                    var fromAddress = new MailAddress("jul18simonyan@gmail.com", "Discover Campanha Website");
                    var toAddress = new MailAddress("jul18simonyan@gmail.com"); // website owner's email

                    using (var message = new MailMessage(fromAddress, toAddress))
                    {
                        message.Subject = "New CV Submitted via Website";
                        message.Body = $"A new CV has been submitted by {email}. See the attached file.";
                        message.IsBodyHtml = true;

                        // Attach the CV
                        message.Attachments.Add(new Attachment(memoryStream, cvFile.FileName));

                        using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.EnableSsl = true;
                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("jul18simonyan@gmail.com", "okfnrtxzkzrprbes");
                            smtp.Send(message);
                        }
                    }
                }

                TempData["CVSuccess"] = "Your CV has been submitted successfully!";
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("email_error.log", $"{DateTime.Now}: {ex}\n");
                TempData["CVError"] = "Failed to send your CV. Please try again later.";
            }

            return RedirectToAction("Work");
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
