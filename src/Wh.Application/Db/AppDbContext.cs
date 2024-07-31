using Adm.Core.DbContext;
using Microsoft.EntityFrameworkCore;
using Wh.Domain.Models.Cmp;
using Wh.Domain.Models.Doc;

namespace Wh.Application.Db
{
    public class AppDbContext : BaseDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op)
            : base(op)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
    }
}
