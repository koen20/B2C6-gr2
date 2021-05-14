using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace B2C6_gr2.Models
{
    public class Article
    {
        public int id { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }

    }

    public class ArticleDBContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}