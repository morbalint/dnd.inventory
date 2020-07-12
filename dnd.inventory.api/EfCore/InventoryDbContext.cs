using dnd.inventory.api.Model;

using Microsoft.EntityFrameworkCore;

using System.Diagnostics.CodeAnalysis;

namespace dnd.inventory.api.EfCore
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item>? Items { get; set; }

        public DbSet<InventoryEntry>? InventoryEntries { get; set; }
    }
}
