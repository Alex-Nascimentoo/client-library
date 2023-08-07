using Microsoft.EntityFrameworkCore;
using fullstack.src.Models;

namespace fullstack.src.Persistence;

public class Context : DbContext
{
  public Context(DbContextOptions<Context> options) : base(options)
  {}

  public DbSet<Client> Clients { get; set; }

  public DbSet<Contract> Contracts { get; set; }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Client>(c => {
      c.HasKey(e => e.Id);
      c.HasMany(e => e.Contracts)
        .WithOne()
        .HasForeignKey(e => e.ClientId);
    });

    builder.Entity<Contract>(c => {
      c.HasKey(e => e.Id);
    });
  }
}