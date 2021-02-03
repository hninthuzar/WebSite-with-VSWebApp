using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Emails obj = new Emails();
            return View(obj);
        }

        public ActionResult EmailInfo(Emails obj)
        {
            var FromMailAddress = "hninaungthuzar@gmail.com";
            var password = ""; // use your correct gmailpassword

            var ToMailAddress = "hninthuzar.itworld@gmail.com";

            try
            {
                MailMessage message = new System.Net.Mail.MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(FromMailAddress);
                message.To.Add(new MailAddress(ToMailAddress));                
                message.Subject = obj.subject;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = obj.name + ',' + obj.email + ',' + obj.phoneno + ',' + obj.message;                
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(FromMailAddress, password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                // MessageBox.Show("sent");

                //if you got exception   >>  Allow less secure apps: ON   in your gmail account // 

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return View();
        }

        public ActionResult Sales()
        {
            ViewBag.Message = "Your Sales page.";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your Portfolio page.";

            return View();
        }

        public ActionResult Empartner()
        {
            ViewBag.Message = "Your Empartner page.";

            return View();
        }
        public ActionResult Restaurant()
        {
            ViewBag.Message = "Your Restaurant page.";

            return View();
        }
        public ActionResult StockInventory()
        {
            ViewBag.Message = "Your Restaurant page.";

            return View();
        }
        public ActionResult MiniPOS()
        {
            ViewBag.Message = "Your MiniPOS page.";

            return View();
        }
        public ActionResult Product()
        {
            ViewBag.Message = "Your Product page.";

            return View();
        }
        
    }
}