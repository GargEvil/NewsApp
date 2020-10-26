using NewsApp.Models;
using NewsApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

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
            try
            {


                var allNews = _context.News.Include(n => n.Category)
                    .Include(n => n.Author);

                if (!String.IsNullOrWhiteSpace(query))
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
            catch (Exception ex)
            {
                throw ex;
            }

            
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
            try
            {
                var news = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 1);

                var vm = new NewsVM
                {
                    News = news
                };

                return View("Index", vm);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult CategoryBussiness()
        {
            try
            {
                var bussiness = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 2);

                var vm = new NewsVM
                {
                    News = bussiness
                };

                return View("Index", vm);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult CategorySport()
        {
            try
            {
                var sport = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 3);

                var vm = new NewsVM
                {
                    News = sport
                };

                return View("Index", vm);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult CategoryMagazine()
        {
            try
            {
                var magazine = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 4);

                var vm = new NewsVM
                {
                    News = magazine
                };

                return View("Index", vm);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult CategoryLifestyle()
        {
            try
            {
                var lifestyle = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 5);

                var vm = new NewsVM
                {
                    News = lifestyle
                };

                return View("Index", vm);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult CategoryScitech()
        {
            try
            {
                var scitech = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 6);

                var vm = new NewsVM
                {
                    News = scitech
                };

                return View("Index", vm);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult CategoryAuto()
        {
            try
            {
                var auto = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 7);

                var vm = new NewsVM
                {
                    News = auto
                };

                return View("Index", vm);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult CategoryBlackChronicle()
        {
            try
            {
                var blackchronicle = _context.News.Include(n => n.Author).Include(n => n.Category).Where(c => c.CategoryId == 8);

                var vm = new NewsVM
                {
                    News = blackchronicle
                };

                return View("Index", vm);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        protected override void OnException(ExceptionContext filterContext)
        {
            Exception exception = filterContext.Exception;
            //Logging the Exception
            filterContext.ExceptionHandled = true;


            var Result = this.View("Error", new HandleErrorInfo(exception,
                filterContext.RouteData.Values["controller"].ToString(),
                filterContext.RouteData.Values["action"].ToString()));

            filterContext.Result = Result;

        }
    }
}