using System.Data.Entity;
using EntityFrameworkDemo.Models;

namespace EntityFrameworkDemo.DBContext
{
    public class Context : DbContext
    {
        public Context(): base("demo")
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}