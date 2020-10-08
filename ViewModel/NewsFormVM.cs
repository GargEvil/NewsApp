using NewsApp.Controllers;
using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace NewsApp.ViewModel
{
    public class NewsFormVM
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Naslov")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Sadržaj")]
        public string Content { get; set; }

        public DateTime? Date { get; set; }

        [Display(Name ="Učitaj sliku")]
        public string imageUrl { get; set; }

        [Required]
        [Display(Name ="Kategorija")]
        public int CategoryId { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }


        public string Action
        {
            get
            {
                Expression<Func<NewsController, ActionResult>> update =
                    (c => c.Update(this));

                Expression<Func<NewsController, ActionResult>> create =
                    (c => c.AddNews(this));

                var action = (Id != 0) ? update : create;

                var actionName = (action.Body as MethodCallExpression).Method.Name;

                return actionName;
            }
        }

    }
}