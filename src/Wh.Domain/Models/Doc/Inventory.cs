using Adm.Core.BaseModels.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
using Wh.Domain.Models.Cmp;

namespace Wh.Domain.Models.Doc
{
    public class Inventory : AuditedEntity, IAudited
    {
        public int WarehouseId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(WarehouseId))]
        public virtual Warehouse? Warehouse { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product? Product { get; set; }
    }
}
