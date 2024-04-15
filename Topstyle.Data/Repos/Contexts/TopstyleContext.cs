using Microsoft.EntityFrameworkCore;
using Topstyle.Domain.Entites;

namespace Topstyle.Data.Repos.Contexts
{
    public class TopstyleContext : DbContext
    {
        public TopstyleContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

    }
}
