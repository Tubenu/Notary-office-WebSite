using Nowa_Strona.Models;
using Nowa_Strona.Models.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Nowa_Strona.Controllers
{
    public class HomeController : Controller
    {
        
        public HomeController()
        {
            
        }

        public ActionResult Index()
        {
            HttpContext.Session.Add("footer_text", Footer.Value);
            return View();
        }

        public ActionResult Download()
        {
            HttpContext.Session.Add("footer_text", Footer.Value);
            return View();
        }

        public ActionResult Contact()
        {
            HttpContext.Session.Add("footer_text", Footer.Value);

            return View();
        }

        public ActionResult Kalkulator()
        {
            HttpContext.Session.Add("footer_text", Footer.Value);
            var list = new SelectList(
            new List<object>() {
            new{ Text = "Sprzedaż lokalu mieszkalnego", Value = "2", Selected = false },
            new { Text = "Czynnosc na przyszlosc", Value = "3", Selected = false }
        }, "Value", "Text");


            var viewModel = new KalkulatorViewModel();
            viewModel.ChoosedValue = 1.ToString();
            viewModel.Result = new CalculateResult();


            ViewBag.CalcItems = list;

            return View(viewModel);
        }
        
        [HttpPost]
        public ActionResult Kalkulator(KalkulatorViewModel model)
        {
            var list = new SelectList(
           new List<object>() {
                new  { Text = "Sprzedaż lokalu mieszkalnego", Value = "2", Selected = false },
                new  { Text = "Czynnosc na przyszlosc", Value = "3", Selected = false }
                     },"Value", "Text");

            var kalkulator = new Kalkulator();
  
            if(string.IsNullOrEmpty(model.Cena))
            {
                model.Result = new CalculateResult();
                ViewBag.CalcItems = list;
                model.ChoosedValue = 1.ToString();
                return View(model);
            }
            ViewBag.CalcItems = list;
            var result = kalkulator.Sprzedaz_lokalu_mieszkalnego(double.Parse(model.Cena));
            model.Result = result;
                           
                return View(model);
            
        }
    }
}