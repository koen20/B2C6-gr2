using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using B2C6_gr2.Models;

namespace B2C6_gr2.Data
{
    public class B2C6_gr2Context : DbContext
    {
        public B2C6_gr2Context (DbContextOptions<B2C6_gr2Context> options)
            : base(options)
        {
        }

        public DbSet<B2C6_gr2.Models.Article> Article { get; set; }
    }
}
