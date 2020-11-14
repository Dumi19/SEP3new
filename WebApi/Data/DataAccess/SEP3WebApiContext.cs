using Microsoft.EntityFrameworkCore;
using Models;

namespace WebApi.Data.DataAccess
{
    public class SEP3WebApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = SEP.db");
        }
    }
}