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
            NewsFormVM viewModel = new NewsFormVM
            {
                Categories = _context.Categories.ToList()
            };

            return View("NewsForm",viewModel);

        }

        [HttpPost]
        [Authorize(Roles="Admin")]
        public ActionResult AddNews(NewsFormVM viewModel)
        {
            switch (viewModel.CategoryId)
            {
                case 1:
                    viewModel.imageUrl="news.png";
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
                    viewModel.imageUrl = "crnhronika.jpg";
                    break;
                default:
                    viewModel.imageUrl = "noimage.jpg";
                    break;
            }


            var news = new News
            {
                AuthorId = User.Identity.GetUserId(),
                Date = DateTime.Now,
                Title = viewModel.Title,
                Content = viewModel.Content,
                CategoryId = viewModel.CategoryId,
                imageUrl=viewModel.imageUrl
    
            };

            _context.News.Add(news);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Update(NewsFormVM viewModel)
        {

            var news = _context.News
                .Single(n => n.Id == viewModel.Id);

            news.CategoryId = viewModel.CategoryId;
            news.Content = viewModel.Content;
            news.Title = viewModel.Title;

            _context.SaveChanges();

           return RedirectToAction("Index", "Home");


        }


        [Authorize(Roles ="Admin")]
        public ActionResult Edit(int id)
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

            return View("NewsForm",viewModel);
        }

        public ActionResult Search(NewsVM viewModel)
        {
            return RedirectToAction("Index", "Home", new { query = viewModel.SearchTerm });
        }
       
        [Authorize(Roles ="Admin")]
        public ActionResult MyNews()
        {
            var allNews = _context.News.Include(n => n.Category)
                .Include(n => n.Author);

            var viewModel = new NewsVM
            {
                News = allNews
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var news = _context.News.Include(n => n.Category)
                .Include(n => n.Author).Single(n=>n.Id == id);

            return View(news);
        }
    }
}