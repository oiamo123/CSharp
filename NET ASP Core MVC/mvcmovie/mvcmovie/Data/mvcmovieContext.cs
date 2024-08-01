using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvcmovie.Models;

namespace mvcmovie.Data
{
    public class mvcmovieContext : DbContext
    {
        public mvcmovieContext (DbContextOptions<mvcmovieContext> options)
            : base(options)
        {
        }

        public DbSet<mvcmovie.Models.Movie> Movie { get; set; } = default!;
    }
}
