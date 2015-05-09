using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Net;
using System.Net.Mail;
using WoodlandsHOA_2.Models;
using System.Data.Entity;
using System.Data;
using System.Text;


namespace WoodlandsHOA_2.Controllers
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


        [HttpGet]
        public ActionResult Contact()
        {

            return View();
            
           // Models.ContactModels contactModels = new Models.ContactModels();
           // return View(new Models.ContactModels());
        }


        [HttpPost]
        public ActionResult Contact(Models.ContactModels contactModels)
        {
            if (ModelState.IsValid)
            {
                try
               {
                   MailMessage mail = new MailMessage();
                   mail.From = new MailAddress("lkboyd@gmail.com");
                   mail.To.Add("lkboyd@gmail.com");
                   mail.Subject = "Contact message from " + contactModels.FirstName + contactModels.LastName;
                   mail.Body = string.Format("{0} at {1} says: {2}", contactModels.FirstName, contactModels.Email, contactModels.Comment);

                  SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                    smtpServer.Port = 465;
                 smtpServer.EnableSsl = true;
                smtpServer.Credentials = new System.Net.NetworkCredential("lkboyd@gmail.com", "temple12");


                  smtpServer.Send(mail);
                  return View("Success");


          }
               catch (Exception)
              {
                    return View("Error");
              }
         }
            return View();
        }




    }
}