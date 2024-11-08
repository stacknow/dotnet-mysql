using Microsoft.EntityFrameworkCore;
using MySqlApp.Models;

namespace MySqlApp.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
