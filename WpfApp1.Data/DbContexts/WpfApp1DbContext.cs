using Microsoft.EntityFrameworkCore;
using WpfApp1.Domain.Entities;

namespace WpfApp1.Data.DbContexts
{
    public class WpfApp1DbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Market> Markets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;port=3306;database=mydatabase;user=root;password=Coderfrom2022";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
