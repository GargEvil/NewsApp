using NewsApp.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsApp.Controllers.Api
{
    public class NewsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewsController()
        {
            _context = new ApplicationDbContext();
        }

        
        public IEnumerable<News> GetNews()
        {
            return _context.News.ToList();
        }

        
        //[Authorize(Roles = "Admin")]
        [HttpDelete]
        public IHttpActionResult DeleteNews(int id)
        {
            var newsInDb = _context.News.SingleOrDefault(n => n.Id == id);

            if (newsInDb == null)
                NotFound();

            _context.News.Remove(newsInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
