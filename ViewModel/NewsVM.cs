using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApp.ViewModel
{
    public class NewsVM
    {
        public IEnumerable<News> News { get; set; }

        public string SearchTerm { get; set; }
    }
}