using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Concrete;
using Factories;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id)
        {
         

            IInvoice objInvoice = FactoryInvoice.GetInvoice(id);


            ViewBag.Message = objInvoice.Print();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetMovies(int id)
        {
            var provider = new Provider();

            MovieProvider movieProvider = (MovieProvider) id;
            Cinema cinema = provider.GetCinema(movieProvider);
            int i = 30;
            List<Movies> movieses = cinema.GetMovie();
            return View(movieses);
        }
    }
}
