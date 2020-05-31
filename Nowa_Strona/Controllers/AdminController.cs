using Nowa_Strona.Models;
using Nowa_Strona.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nowa_Strona.Controllers
{
    public class AdminController : Controller
    {

        public ActionResult AdminLogin()
        {
            HttpContext.Session.Add("footer_text", Footer.Value);
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(Nowa_Strona.Models.AdminLogin admin)
        {
            if (admin != null)
            {
                Session["login"] = admin.Login;         
                Session["Pass"] = admin.Pass;
                if(Session["login"].ToString().Equals("admin") && Session["Pass"].ToString().Equals("adminadmin"))
                return RedirectToAction("AdminLogged");
            }

            return View(admin);
        }

        public ActionResult AdminLogged()
        {
            if (Session["login"] != null && Session["Pass"] !=null)
            {
                var model = new EditorViewModel();
                model.TextField = Footer.Value;
                return View(model);
            }
            else
            {
                return RedirectToAction("AdminLogin");
            }
        }
        [HttpPost]
        public ActionResult AdminLogged(EditorViewModel model)
        {
            Footer.Value = model.TextField;
            HttpContext.Session.Add("footer_text", Footer.Value);
            return View(model);
        }
        
    }
}
