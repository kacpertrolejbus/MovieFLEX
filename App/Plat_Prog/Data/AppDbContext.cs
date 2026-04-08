using Microsoft.EntityFrameworkCore;
using Plat_prog.Models;
using System.Collections.Generic;

namespace Plat_prog.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
