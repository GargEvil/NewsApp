using Microsoft.AspNet.Identity;
using NewsApp.Models;
using NewsApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.IO;
using NewsApp.DataAccess;

namespace NewsApp.Controllers
{
    public class NewsController : Controller
    {
        private ApplicationDbContext _context;

        public NewsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddNews()
        {
            try
            {
                NewsFormVM viewModel = new NewsFormVM
                {
                    Categories = _context.Categories.ToList()
                };

                return View("NewsForm", viewModel);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        [Authorize(Roles = RoleName.Admin)]
        [ValidateAntiForgeryToken]
        [HttpPost]       
        public ActionResult AddNews(NewsFormVM viewModel)
        {
            try
            {
                var userId = User.Identity.GetUserId();


                if (!ModelState.IsValid)
                {
                    var vm = new NewsFormVM
                    {
                        Title = viewModel.Title,
                        CategoryId = viewModel.CategoryId,
                        Content = viewModel.Content,
                        Categories = _context.Categories.ToList()
                    };
                    return View("NewsForm", vm);
                }


                switch (viewModel.CategoryId)
                {
                    case 1:
                        viewModel.imageUrl = "news.png";
                        break;
                    case 2:
                        viewModel.imageUrl = "biznis.jpg";
                        break;
                    case 3:
                        viewModel.imageUrl = "sport.jpg";
                        break;
                    case 4:
                        viewModel.imageUrl = "magazin.jpg";
                        break;
                    case 5:
                        viewModel.imageUrl = "lifestyle.jpg";
                        break;
                    case 6:
                        viewModel.imageUrl = "scitech.png";
                        break;
                    case 7:
                        viewModel.imageUrl = "auto.jpg";
                        break;
                    case 8:
                        viewModel.imageUrl = "crnahronika.jpg";
                        break;
                    default:
                        viewModel.imageUrl = "noimage.jpg";
                        break;
                }


                NewsManager.Add(viewModel, userId);
                

                return RedirectToAction("Index", "Home");
            }
            catch(Exception ex)
            {
                throw ex;
            }
                      
        }

        [HttpPost]
        [Authorize(Roles = RoleName.Admin)]
        public ActionResult Update(NewsFormVM viewModel)
        {
            try
            {
                var news = _context.News
                    .Single(n => n.Id == viewModel.Id);

                NewsManager.Update(news, viewModel);

                return RedirectToAction("Index", "Home");

            }catch(Exception ex)
            {
                throw ex;
            }


        }


        [Authorize(Roles = RoleName.Admin)]
        public ActionResult Edit(int id)
        {
            try
            {
                var news = _context.News.Single(n => n.Id == id);

                var viewModel = new NewsFormVM
                {
                    Id = news.Id,
                    Title = news.Title,
                    CategoryId = news.CategoryId,
                    Categories = _context.Categories.ToList(),
                    Content = news.Content
                };

                return View("NewsForm", viewModel);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Search(NewsVM viewModel)
        {
            try
            {
                return RedirectToAction("Index", "Home", new { query = viewModel.SearchTerm });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [Authorize(Roles = RoleName.Admin)]
        public ActionResult MyNews()
        {
            try
            {
                var allNews = _context.News.Include(n => n.Category)
                .Include(n => n.Author);

                var viewModel = new NewsVM
                {
                    News = allNews
                };

                return View(viewModel);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Details(int id)
        {
            try
            {
                var news = _context.News.Include(n => n.Category)
                .Include(n => n.Author).Single(n => n.Id == id);

                return View(news);
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