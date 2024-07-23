using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Domain.Models
{
    /// <summary>
    /// Product categories to organize products.
    /// </summary>
    [Table("category")]
    public class Category : ModelBaseName<long>
    {
        [Column("description")]
        public string Description { get; set; } = default!;
    }
}
