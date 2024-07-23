using System.ComponentModel.DataAnnotations.Schema;

namespace Wh.Domain.Models
{
    public abstract class ModelBaseId<TId> where TId : struct
    {
        [Column("id")]
        public TId Id { get; set; }
    }

    public abstract class AuditableModelBase<TId> : ModelBaseId<TId> where TId : struct
    {
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }

    public abstract class ModelBaseName<TId> : AuditableModelBase<TId> where TId : struct
    {
        [Column("name")]
        public string Name { get; set; } = default!;
    }
}
