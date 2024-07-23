using System.ComponentModel.DataAnnotations.Schema;
using WhDomain.Models;

namespace Wh.Domain.Models
{
    /// <summary>
    /// Inventory records the quantity of Products in Whs.
    /// </summary>
    [Table("inventory")]
    public class Inventory : AuditableModelBase<long>
    {
        [Column("warehouse_id"), ForeignKey(nameof(Warehouse))]
        public long WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; } = default!;

        [Column("product_id"), ForeignKey(nameof(Product))]
        public long ProductId { get; set; }
        public virtual Product Product { get; set; } = default!;

        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
