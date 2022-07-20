using Microsoft.EntityFrameworkCore;
using LoginAuthEg.Models;
using LoginAuthEgown.Models;

namespace LoginAuthEg.Models
{
    public class OrgContext:DbContext
    {
        public OrgContext() { }
        public OrgContext(DbContextOptions options) : base(options) { }
        public DbSet<User> users { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<LoginAuthEg.Models.Product> Product { get; set; }
        //public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }
    }
}
