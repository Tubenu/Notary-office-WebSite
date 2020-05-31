using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace Nowa_Strona.Controllers
{
    public class MailController : Controller
    {
       
        [HttpPost]
        public ActionResult Index(Nowa_Strona.Models.Mail model)
        {
           if(model.Do == null){}

            else
            {
                MailMessage mm = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                mm.From = new MailAddress("kancelaria.notarialna.test@gmail.com", model.Do);
                mm.To.Add("kancelaria.notarialna.test@gmail.com");
                mm.Subject = model.Tytul;
                mm.Body = model.Temat;
                mm.IsBodyHtml = false;
                
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential("kancelaria.notarialna.test@gmail.com", "");//change for yours if u want
                smtp.EnableSsl = true;
                smtp.Send(mm);

                ModelState.Clear();
                ViewBag.result = "Poprawnie wysłano wiadomość email";

            }
            return View("~/Views/Home/Contact.cshtml");
        }
    }
}