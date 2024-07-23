using System.ComponentModel.DataAnnotations.Schema;
using WHDomain.Models;

namespace WH.Domain.Models
{
    /// <summary>
    /// Inventory records the quantity of Products in WHs.
    /// </summary>
    [Table("inventory")]
    public class Inventory : AuditableModelBase<long>
    {
        [Column("warehouse_id"), ForeignKey(nameof(WH))]
        public long WHId { get; set; }
        public virtual WH WH { get; set; } = default!;

        [Column("product_id"), ForeignKey(nameof(Product))]
        public long ProductId { get; set; }
        public virtual Product Product { get; set; } = default!;

        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
