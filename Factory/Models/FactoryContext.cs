using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<ClassName> ClassName { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}