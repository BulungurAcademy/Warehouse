using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Domain.Models
{
    public abstract class ModelBase<TId> where TId : struct
    {
        [Column("id")]
        public TId Id { get; set; }
    }

    public abstract class AuditableModelBase<TId> : ModelBase<TId> where TId : struct
    {
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
