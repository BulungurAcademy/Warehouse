using Adm.Core.BaseModels.Auditing;
using Adm.Core.BaseModels.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wh.Domain.Models.Cmp
{
    public class Product : AuditedEntityWithName, IAudited, IMustHaveTenant
    {
        public required int TenantId { get; set; }
        public int? SupplierId { get; set; }
        public required int CategoryId { get; set; }

        public decimal UnitPrice { get; set; }
        public decimal UnitsInStock { get; set; }
        public string? ImageUrl { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category? Category { get; set; }
    }
}
