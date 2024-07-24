using System.ComponentModel.DataAnnotations.Schema;
using Wh.Domain.Models;

namespace WhDomain.Models
{
    /// <summary>
    /// Information about the products stored in the warehouse.
    /// </summary>
    [Table("product")]
    public class Product
    {
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
