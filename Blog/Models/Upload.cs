using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Upload
    {
        private ICollection<Article> articles;

        [Key]
        public int Id { get; set; }

        public string Image { get; set; }

        
    }
}