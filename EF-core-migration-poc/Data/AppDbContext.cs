using EF_core_migration_poc.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_core_migration_poc.Data {
  public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions options) : base(options) {
    }

    public DbSet<Employee> Employees { get; set; }
  }
}
