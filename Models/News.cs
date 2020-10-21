using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NewsApp.ViewModel;

namespace NewsApp.Models
{
    public class News
    {

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorId { get; set; }

        public ApplicationUser Author { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime? Date { get; set; }

        public string imageUrl { get; set; }

        public Category Category { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public static News SaveNews(NewsFormVM viewModel, string userId)
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

            return news;
        }

        public static void UpdateNews(News news, NewsFormVM viewModel)
        {
            news.CategoryId = viewModel.CategoryId;
            news.Content = viewModel.Content;
            news.Title = viewModel.Title;
        }
    }
}