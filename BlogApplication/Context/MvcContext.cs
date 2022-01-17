using BlogApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApplication.Context
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}
