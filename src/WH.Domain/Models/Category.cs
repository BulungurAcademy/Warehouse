using System.ComponentModel.DataAnnotations.Schema;

namespace Wh.Domain.Models
{
    /// <summary>
    /// Product categories to organize products.
    /// </summary>
    [Table("category")]
    public class Category
    {
        [Column("description")]
        public string Description { get; set; } = default!;
    }
}
