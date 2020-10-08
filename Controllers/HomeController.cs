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

        public ActionResult CategoryNews()
        {
            var news = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 1);

            var vm = new NewsVM
            {
                News = news
            };

            return View("Index",vm);
        }
        public ActionResult CategoryBussiness()
        {
            var bussiness = _context.News.Include(n=>n.Author).Include(n => n.Category).Where(c => c.CategoryId == 2);

            var vm = new NewsVM
            {
                News = bussiness
            };

            return View("Index", vm);
        }

        public ActionResult CategorySport()
        {
            var sport = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 3);

            var vm = new NewsVM
            {
                News = sport
            };

            return View("Index", vm);
        }

        public ActionResult CategoryMagazine()
        {
            var magazine = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 4);

            var vm = new NewsVM
            {
                News = magazine
            };

            return View("Index", vm);
        }
        public ActionResult CategoryLifestyle()
        {
            var lifestyle = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 5);

            var vm = new NewsVM
            {
                News = lifestyle
            };

            return View("Index", vm);
        }

        public ActionResult CategoryScitech()
        {
            var scitech = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 6);

            var vm = new NewsVM
            {
                News = scitech
            };

            return View("Index", vm);
        }

        public ActionResult CategoryAuto()
        {
            var auto = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 7);

            var vm = new NewsVM
            {
                News = auto
            };

            return View("Index", vm);
        }

        public ActionResult CategoryBlackChronicle()
        {
            var blackchronicle = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 8);

            var vm = new NewsVM
            {
                News = blackchronicle
            };

            return View("Index", vm);
        }
    }
}