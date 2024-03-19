using assignment_task_1.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace assignment_task_1.Controllers
{
    [Authorize]
    public class AddController : Controller
    {

        private readonly DataBaseConnect _context;
        public AddController(DataBaseConnect context)
        {
            _context = context;
        }

        //[HttpPost]

        //public IActionResult SignIn(string email, string password)
        //{

        //    var user = _context.Singin.FirstOrDefault(u => u.email == email);

        //    if (user != null && (password == user.password))
        //    {

        //        return RedirectToAction("ShowView");
        //    }
        //    else
        //    {
        //        TempData["ErrorMessage"] = "Invalid Email or Password";
        //        return RedirectToAction("Index");
        //    }
        //}
        
       
        public IActionResult ShowView()
        {
            return View();
        }
        public IActionResult AddCard()
        {
            return View();
        }

        public IActionResult ViewLaptop()
        {
            return View();
        }
        public IActionResult ViewPhone()
        {
            return View();
        }
        public IActionResult ViewWatch()
        {
            return View();
        }
        public IActionResult ViewEarbuds()
        {
            return View();
        }
        public IActionResult ShowLaptop()
        { 
           var pro = _context.Products.Where(p => p.cid == 1).ToList();
           return new JsonResult(pro);
        }
        public IActionResult ShowPhone()
        {
            var pro = _context.Products.Where(p => p.cid == 2).ToList();
            return new JsonResult(pro);
        }
        public IActionResult ShowWatch()
        {
            var pro = _context.Products.Where(p => p.cid == 3).ToList();
            return new JsonResult(pro);
        }
        public IActionResult ShowEarbuds()
        {
            var pro = _context.Products.Where(p => p.cid == 4).ToList();
            return new JsonResult(pro);
        }
        public IActionResult CustomerDetails(int id)
        {

            var send = _context.Products.Where(x => x.Id == id).ToList();
            return View(send);
        }
        public IActionResult OrderCard(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            var responseData = new { success = true, message = "Products Ordered Successfully" };

            return Json(responseData);
        }

        public IActionResult UPIPayment()
        {
            return View();
        }
         


        public IActionResult CustomerBuynow(Customer bill) 
        {
            _context.Customers.Add(bill);
            _context.SaveChanges();
            SendBookingConfirmationEmail(bill);

            var responseData = new { success = true, message = "Please Provide Confirmation For Booking " };
            return Json(responseData);
        }


        private void SendBookingConfirmationEmail(Customer customer)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("kapilwagadre1111@gmail.com", "epls lyay lyfc pted");
            smtpClient.EnableSsl = true; 

            // Construct email message
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("kapilwagadre1111@gmail.com"); 
            mailMessage.To.Add(customer.Email);
            mailMessage.Subject = "Booking Confirmation"; 
            mailMessage.Body = ConstructEmailBody(customer); 
            mailMessage.IsBodyHtml = true; 

            // Send the email
            smtpClient.Send(mailMessage);
        }

        private string ConstructEmailBody(Customer customer)
        {
            StringBuilder emailBody = new StringBuilder();
            emailBody.AppendLine($"<p>Dear {customer.Customer_Name},</p>");
            emailBody.AppendLine("<p>Thank you for placing your order with us. Below are the details of your order:</p>");
            emailBody.AppendLine("<p><strong>Product Information:</strong></p>");

            

            emailBody.AppendLine("<p>Your order will be delivered by 20 March 2024, Thursday.</p>");
            emailBody.AppendLine("<p>Thank you for shopping with us!</p>");
            emailBody.AppendLine("<p>Best regards , </p>");
            emailBody.AppendLine("<p>The SmartCart Team</p>");
            return emailBody.ToString();
        }


    }

}

