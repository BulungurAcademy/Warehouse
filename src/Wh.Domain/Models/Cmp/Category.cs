using Adm.Core.BaseModels.Auditing;
using Adm.Core.BaseModels.BaseEntities;

namespace Wh.Domain.Models.Cmp
{
    public class Category : AuditedEntityWithName, IAudited, IMustHaveTenant
    {
        public required int TenantId { get; set; }
        public string? Description { get; set; }
    }
}
