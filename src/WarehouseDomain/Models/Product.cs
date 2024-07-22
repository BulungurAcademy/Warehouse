using System.ComponentModel.DataAnnotations.Schema;
using Warehouse.Domain.Models;

namespace WarehouseDomain.Models
{
    public class Product : AuditableModelBase<long>
    {
        [Column("name")]
        public string Name { get; set; } = default!;

        [Column("category_id"), ForeignKey(nameof(Category))]
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; } = default!;

        [Column("supplier_id"), ForeignKey(nameof(Supplier))]
        public long SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; } = default!;

        [Column("unit_price")]
        public decimal UnitPrice { get; set; }

        [Column("units_in_stock")]
        public int UnitsInStock { get; set; }
    }
}
