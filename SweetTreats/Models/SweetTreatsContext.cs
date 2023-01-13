using Microsoft.EntityFrameworkCore;

namespace SweetTreats.Models
{
  public class SweetTreatsContext : DbContext
  {
    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<FlavorTreat> FlavorTreats { get; set; }
    public SweetTreatsContext(DbContextOptions options) : base(options) { }
  }
}