using NewsApp.Models;
using NewsApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace NewsApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index(string query=null)
        {
            var allNews = _context.News.Include(n => n.Category)
                .Include(n => n.Author);

            if(!String.IsNullOrWhiteSpace(query))
            {
                allNews = allNews.
                    Where(n => n.Content.Contains(query) || 
                    n.Author.UserName.Contains(query) || 
                    n.Title.Contains(query));
            }

            var viewModel = new NewsVM
            {
                News = allNews
            };

            
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CategoryVijesti()
        {
            var vijesti = _context.News.Include(n => n.Category).Where(c => c.CategoryId == 1);

            var VM = new NewsVM
            {
                News = vijesti
            };

            return View("Index",VM);
        }
        public ActionResult CategoryBiznis()
        {
            var biznis = _context.News.Include(n => n.Category).Where(c => c.CategoryId == 2);

            var VM = new NewsVM
            {
                News = biznis
            };

            return View("Index", VM);
        }

        public ActionResult CategorySport()
        {
            var sport = _context.News.Include(n => n.Category).Where(c => c.CategoryId == 3);

            var VM = new NewsVM
            {
                News = sport
            };

            return View("Index", VM);
        }

        public ActionResult CategoryMagazin()
        {
            var magazin = _context.News.Include(n => n.Category).Where(c => c.CategoryId == 4);

            var VM = new NewsVM
            {
                News = magazin
            };

            return View("Index", VM);
        }
        public ActionResult CategoryLifestyle()
        {
            var lifestyle = _context.News.Include(n => n.Category).Where(c => c.CategoryId == 5);

            var VM = new NewsVM
            {
                News = lifestyle
            };

            return View("Index", VM);
        }

        public ActionResult CategoryScitech()
        {
            var scitech = _context.News.Include(n => n.Category).Where(c => c.CategoryId == 6);

            var VM = new NewsVM
            {
                News = scitech
            };

            return View("Index", VM);
        }

        public ActionResult CategoryAuto()
        {
            var auto = _context.News.Include(n => n.Category).Where(c => c.CategoryId == 7);

            var VM = new NewsVM
            {
                News = auto
            };

            return View("Index", VM);
        }

        public ActionResult CategoryCrnaHronika()
        {
            var crnahronika = _context.News.Include(n => n.Category).Where(c => c.CategoryId == 8);

            var VM = new NewsVM
            {
                News = crnahronika
            };

            return View("Index", VM);
        }
    }
}