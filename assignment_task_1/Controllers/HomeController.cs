using assignment_task_1.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Net.Mail;
using System.Net;

namespace assignment_task_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataBaseConnect _context;
        public HomeController(DataBaseConnect context)
        {
            _context = context;
        }


        public IActionResult Index1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index1(Sing_in value)
        {
            _context.Singin.Add(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            ClaimsPrincipal claimsUser = HttpContext.User;
            if (claimsUser.Identity.IsAuthenticated)
                return RedirectToAction("ShowView", "Add");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string email, string password)
        {

            var user = await _context.Singin.FirstOrDefaultAsync(u => u.email == email && u.password == password);

            if (user != null)
            {
                List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.email),
            };

                ClaimsIdentity identity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(identity), properties);
                
                return RedirectToAction("ShowView", "Add");
            }

            else
            {
                TempData["ErrorMessage"] = "User not found !!";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Forgetpass()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Forgetpass(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                string resetToken = "random_reset_token";
                string resetLink = Url.Action("ResetPassword", "Home", new { email, token = resetToken }, Request.Scheme);

                string mailBody = $"Please click <a href='{resetLink}'>here</a> to reset your password.";

                MailMessage mailMessage = new MailMessage("kapilwagadre1111@gmail.com", email);
                mailMessage.Subject = "Reset Password";
                mailMessage.Body = mailBody;
                mailMessage.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.Credentials = new NetworkCredential("kapilwagadre1111@gmail.com", "epls lyay lyfc pted");
                smtpClient.EnableSsl = true;

                try
                {
                    smtpClient.Send(mailMessage);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                { 
                    return RedirectToAction("ForgetpassError");
                }
            }
         
            return RedirectToAction("Forgetpass");
        }


        [HttpGet]
        public ActionResult ResetPassword(string email, string token)
        {
            return View(Tuple.Create(email, token));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ResetPassword(string email, string token, string newPassword, string confirmPassword)
        {

            if (!ModelState.IsValid)
            {

                return View();
            }
            var user = _context.Singin.FirstOrDefault(u => u.email == email);
            if (user == null)
            {
                TempData["ErrorMessage"] = "Email not found.";
                return RedirectToAction("ResetPassword", "Home");
            }


            // Update the password
            user.password = newPassword;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
