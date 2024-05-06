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
            if (TempData["UserDetails"] is string userDetailsJson)
            {
                var userDetails = JsonConvert.DeserializeObject<Sing_in>(userDetailsJson);
                return View(userDetails);
            }

            return View();
        }
        public IActionResult AddCard()
        {
            return View();
        }

        //public IActionResult ReplacementPage()
        //{
        //    return View();
        //}


        [HttpPost]
        public ActionResult ReplacementPage(string orderId)
        {
            var customer = _context.CustomerProducts.FirstOrDefault(c => c.OrderId == orderId);

            if (customer != null)
            {
                return View(customer);
            }
            else
            {
                var customerUPIDetails = _context.CustomerUPIPayments.FirstOrDefault(c => c.OrderId == orderId);

                if (customerUPIDetails != null)
                {
                    // Found in CustomerUPIPayments, return something accordingly
                    return View(customerUPIDetails); // Adjust view name accordingly
                }
                else
                {
                    return NotFound("Booking details not found.");
                }
            }
        }


        public IActionResult HomeChangePass(string email)
        {
            var user = _context.Singin.FirstOrDefault(u => u.email == email);

            if (user != null)
            {
                var model = new ChangePassword
                {
                    Email = user.email
                };

                return View(model);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult AllOrder(string username, string email)
        {
            ViewData["Username"] = username;
            ViewData["Email"] = email;
            return View();
        }

        public IActionResult UserOrder(string username, string email)
        {
           
            var filteredData = _context.CustomerProducts.Where(d => d.Customer_Name == username && d.Email == email).ToList();

            return Json(filteredData);
        }
        public IActionResult UserUPIOrder(string username, string email)
        {

            var filteredUPIData = _context.CustomerUPIPayments.Where(d => d.Customer_Name == username && d.Email == email).ToList();

            return Json(filteredUPIData);
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
         
        //UPI booking
        public IActionResult UPIPaymentCard(CustomerUPIPayment customer)
        {
            var random = new Random();
            customer.OrderId = random.Next(100000, 999999).ToString();

            _context.CustomerUPIPayments.Add(customer);
            _context.SaveChanges();
             SendBookingConfirmationEmail(customer);
            var responseData = new
            {
                success = true,
                message = "Please Provide Confirmation For Booking",
                orderId = customer.OrderId
            };

            return Json(responseData);
        }
    

        public IActionResult UPIPayment()
        {
            return View();
        }

        //cardEmail
        private void SendBookingConfirmationEmail(CustomerUPIPayment customer)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("kapilwagadre1111@gmail.com", "epls lyay lyfc pted");
            smtpClient.EnableSsl = true;

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("kapilwagadre1111@gmail.com");
            mailMessage.To.Add(customer.Email);
            mailMessage.Subject = "Booking Confirmation";
            mailMessage.Body = ConstructEmailBody(customer);
            mailMessage.IsBodyHtml = true;

            // Send the email
            smtpClient.Send(mailMessage);
        }

        private string ConstructEmailBody(CustomerUPIPayment customer)
        {
            StringBuilder emailBody = new StringBuilder();
            emailBody.AppendLine($"<p>Dear {customer.Customer_Name},</p>");
            emailBody.AppendLine($"<p>OrderId -{customer.OrderId},</p>");
            emailBody.AppendLine("<p>Thank you for Online payment your Booking order with us. Below are the details of your order:</p>");
            emailBody.AppendLine("<p><strong>Order Information:</strong></p>");
            emailBody.AppendLine($"<p>Booking card - {customer.nameOnCard},</p>");
            emailBody.AppendLine($"<p>Product Name - {customer.Product_Name},</p>");
            emailBody.AppendLine($"<p>Details -{customer.Product_Detail},</p>");
            emailBody.AppendLine($"<p>Warranty {customer.Product_warranty},</p>");
            emailBody.AppendLine($"<p>Price -{customer.Product_Price} /-,</p>");

            emailBody.AppendLine("<p>Your order will be delivered by 20 April 2024, Thursday.</p>");
            emailBody.AppendLine("<p>Thank you for  shopping with us!</p>");
            emailBody.AppendLine("<p>Best regards , </p>");
            emailBody.AppendLine("<p>The SmartCart Team</p>");
            return emailBody.ToString();
        }

        //cash on booking
        [HttpPost]
        public IActionResult CustomerBuynow(CustomerProduct bill)
        {
            var random = new Random();
            bill.OrderId = random.Next(100000, 999999).ToString();

            _context.CustomerProducts.Add(bill);
            _context.SaveChanges();
            SendBookingEmail(bill);
            var responseData = new { success = true, message = "Please Provide Confirmation For Booking " };
            return Json(responseData);
        }

        private void SendBookingEmail(CustomerProduct customer)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("kapilwagadre1111@gmail.com", "epls lyay lyfc pted");
            smtpClient.EnableSsl = true;

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("kapilwagadre1111@gmail.com");
            mailMessage.To.Add(customer.Email);
            mailMessage.Subject = "Booking Confirmation";
            mailMessage.Body = EmailBody(customer);
            mailMessage.IsBodyHtml = true;

            // Send the email
            smtpClient.Send(mailMessage);
        }

        private string EmailBody(CustomerProduct customer)
        {
            StringBuilder emailBody = new StringBuilder();

            emailBody.AppendLine($"<p>Dear {customer.Customer_Name},</p>");
            emailBody.AppendLine($"<p>OrderId {customer.OrderId},</p>");
            emailBody.AppendLine("<p>Thank you for placing your order with us. Below are the details of your order:</p>");
            emailBody.AppendLine("<p><strong>Product Information:</strong></p>");
            emailBody.AppendLine($"<p>Product Name - {customer.Product_Name},</p>");
            emailBody.AppendLine($"<p>Details -{customer.Product_Detail},</p>");
            emailBody.AppendLine($"<p>Warranty {customer.Product_warranty},</p>");
            emailBody.AppendLine($"<p>Price -{customer.Product_Price} /-,</p>");
            emailBody.AppendLine("<p>Your order will be delivered by 20 April 2024, Sunday.</p>");
            emailBody.AppendLine("<p>Thank you for shopping with us!</p>");
            emailBody.AppendLine("<p>Best regards , </p>");
            emailBody.AppendLine("<p>The SmartCart Team</p>");
            return emailBody.ToString();
        }

      
    }
}

