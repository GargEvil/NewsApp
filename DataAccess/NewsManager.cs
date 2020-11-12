using NewsApp.Models;
using NewsApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApp.DataAccess
{
    public static class NewsManager
    {



        public static void Add(NewsFormVM viewModel, string userId)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                var news = new News
                {
                    AuthorId = userId,
                    Date = DateTime.Now,
                    Title = viewModel.Title,
                    Content = viewModel.Content,
                    CategoryId = viewModel.CategoryId,
                    imageUrl = viewModel.imageUrl

                };

                _context.News.Add(news);
                _context.SaveChanges();
            }
        }

        public static void Update(News news, NewsFormVM viewModel)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                news.CategoryId = viewModel.CategoryId;
                news.Content = viewModel.Content;
                news.Title = viewModel.Title;


                _context.SaveChanges();
            }
        }
    }
}