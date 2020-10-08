using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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

    }
}