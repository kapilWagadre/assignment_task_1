using assignment_task_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;

namespace assignment_task_1.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataBaseConnect _context;
        public AdminController(DataBaseConnect context)
        {
            _context = context;
        }
        public IActionResult Adminlogin()
        {
            return View();
        }
        public IActionResult AdminAccess()
        {
            return View();
        }
        public new IActionResult SingupUser()
        {
            return View();
        }
        public new IActionResult Singupdetail()
        {
            var emp = _context.Singin.ToList();
            return new JsonResult(emp);
        }
        public new IActionResult ViewData()
        {
            return View();
        }
        [HttpPost]
        public new IActionResult ViewData(Product model, IFormFile Product_Image)
        {
            var pro = new Product();

            pro.Id = model.Id;
            pro.Product_Name = model.Product_Name;
            pro.cid = model.cid;
            pro.Product_Price = model.Product_Price;
            pro.Product_Price = model.Product_Price;
            pro.Product_Detail = model.Product_Detail;
            pro.Product_warranty = model.Product_warranty;

            if (Product_Image != null && Product_Image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Product_Image.CopyTo(ms);
                    pro.Product_Image = ms.ToArray();
                }
            }

            _context.Products.Add(pro);
            _context.SaveChanges();
            return View();
        }

        public IActionResult ShoopingCustomer()
        {
            return View();
        }
        public IActionResult Show()
        {
            var cus = _context.CustomerProducts.ToList();
            return new JsonResult(cus);
        }

        public IActionResult UPIData()
        {
            var upi = _context.CustomerUPIPayments.ToList();
            return new JsonResult(upi);
        }


        [HttpPost]
        public IActionResult CancelTkt(int id, decimal Product_Price)
        {
            var bookingDetails = _context.CustomerProducts.FirstOrDefault(b => b.Id == id);

            if (bookingDetails != null)
            {
                var penalty = 200;
                var refundedAmount = Product_Price - penalty;

                SendRefundEmail(bookingDetails, refundedAmount);
                _context.CustomerProducts.Remove(bookingDetails);
                _context.SaveChanges();

                return Ok("Booking cancelled successfully.");
            }
            else
            {
                var customerUPIDetails = _context.CustomerUPIPayments.FirstOrDefault(c => c.Id == id);
                if (customerUPIDetails != null)
                {
                    var penalty = 200;
                    var refundedAmount = Product_Price - penalty;

                    UPISendRefundEmail(customerUPIDetails, refundedAmount);
                    _context.CustomerUPIPayments.Remove(customerUPIDetails);
                    _context.SaveChanges();

                    return Ok("Booking cancelled successfully.");
                }
                else
                {
                    return NotFound("Booking details not found.");
                }

            }
        }

        //COD Cancel
        private void SendRefundEmail(CustomerProduct bookingDetails, decimal refundedAmount)
         {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential("kapilwagadre1111@gmail.com", "epls lyay lyfc pted");
                    smtpClient.EnableSsl = true;
                    smtpClient.Port = 587;

                    // Create and configure email message
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("kapilwagadre1111@gmail.com");
                    mailMessage.To.Add(bookingDetails.Email);
                    mailMessage.Subject = "Booking Cancellation Confirmation";
                    mailMessage.Body = $"Dear {bookingDetails.Customer_Name},\n\nYour SmartCard product booking with OrderID {bookingDetails.OrderId} has been successfully cancelled. " +
                                        $" The refunded amount is {refundedAmount} debited on your account.\n\nThank you.";

                    // Send email
                    smtpClient.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                Console.WriteLine($"Error in SendRefundEmail method: {ex.Message}");
                throw;
            }
        }

        //UPI Payment Cancel

        private void UPISendRefundEmail(CustomerUPIPayment customerUPIDetails, decimal refundedAmount)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential("kapilwagadre1111@gmail.com", "epls lyay lyfc pted");
                    smtpClient.EnableSsl = true;
                    smtpClient.Port = 587;

                    // Create and configure email message
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("kapilwagadre1111@gmail.com");
                    mailMessage.To.Add(customerUPIDetails.Email);
                    mailMessage.Subject = "Booking Cancellation Confirmation";
                    mailMessage.Body = $"Dear {customerUPIDetails.Customer_Name},\n\nYour SmartCard product booking with OrderID {customerUPIDetails.OrderId} has been successfully cancelled. " +
                                        $" The refunded amount is {refundedAmount} debited on your account.\n\nThank you.";

                    // Send email
                    smtpClient.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                Console.WriteLine($"Error in SendRefundEmail method: {ex.Message}");
                throw;
            }
        }
        //public IActionResult ViewData(Laptopview laptopModel, Phoneview mobileModel, Watchview watchmodel, IFormFile Product_Image)
        //{
        //    if (laptopModel.product_key == 1)
        //    {
        //        var laptop = new Laptopview
        //        {
        //            Product_Name = laptopModel.Product_Name,
        //            product_key = laptopModel.product_key,
        //            Product_Price = laptopModel.Product_Price,
        //            Product_Detail = laptopModel.Product_Detail,
        //            Product_warranty = laptopModel.Product_warranty,
        //            // other properties...
        //        };

        //        if (Product_Image != null && Product_Image.Length > 0)
        //        {
        //            using (MemoryStream ms = new MemoryStream())
        //            {
        //                Product_Image.CopyTo(ms);
        //                laptop.Product_Image = ms.ToArray();
        //            }
        //        }

        //        _context.Laptops.Add(laptop);
        //        _context.SaveChanges();

        //        return View();
        //    }
        //    else if (laptopModel.product_key == 2)
        //    {
        //        var mobile = new Phoneview
        //        {
        //            Product_Name = laptopModel.Product_Name,
        //            product_key = laptopModel.product_key,
        //            Product_Price = laptopModel.Product_Price,
        //            Product_Detail = laptopModel.Product_Detail,
        //            Product_warranty = laptopModel.Product_warranty

        //        };

        //        if (Product_Image != null && Product_Image.Length > 0)
        //        {
        //            using (MemoryStream ms = new MemoryStream())
        //            {
        //                Product_Image.CopyTo(ms);
        //                mobile.Product_Image = ms.ToArray();
        //            }
        //        }

        //        _context.Phones.Add(mobile);
        //        _context.SaveChanges();

        //        return View();
        //    }

        //    else if (laptopModel.product_key == 3)
        //    {
        //        var watch = new Watchview
        //        {
        //            Product_Name = laptopModel.Product_Name,
        //            product_key = laptopModel.product_key,
        //            Product_Price = laptopModel.Product_Price,
        //            Product_Detail = laptopModel.Product_Detail,
        //            Product_warranty = laptopModel.Product_warranty

        //        };

        //        if (Product_Image != null && Product_Image.Length > 0)
        //        {
        //            using (MemoryStream ms = new MemoryStream())
        //            {
        //                Product_Image.CopyTo(ms);
        //                watch.Product_Image = ms.ToArray();
        //            }
        //        }

        //        _context.Watchs.Add(watch);
        //        _context.SaveChanges();

        //        return View();
        //    }


        //    else
        //    {

        //        return BadRequest("Invalid product key");
        //    }
        //}
        //public IActionResult ViewData(Product model)
        //{ 
        //     _context.Products.Add(model);
        //     _context.SaveChanges();
        //        return View();
        //}
    }
}
