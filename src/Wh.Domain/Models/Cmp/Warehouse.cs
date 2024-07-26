using Adm.Core.BaseModels.Auditing;
using Adm.Core.BaseModels.BaseEntities;
using NetTopologySuite.Geometries;

namespace Wh.Domain.Models.Cmp
{
    public class Warehouse : AuditedEntityWithName, IAudited, IMustHaveTenant
    {
        public required int TenantId { get; set; }
        public Point? Location { get; set; }
    }
}
