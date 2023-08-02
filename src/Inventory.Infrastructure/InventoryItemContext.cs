using System.Reflection;
using Microsoft.EntityFrameworkCore;
namespace Inventory.Infrastructure;
public class InventoryItemContext : DbContext
{
    public InventoryItemContext(DbContextOptions<InventoryItemContext> options) : base(options)
    {

    }
    public DbSet<Domain.Inventory> InventoryItem { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new InventoryMapping());

    }
}