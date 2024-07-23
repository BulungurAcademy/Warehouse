using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations.Schema;

namespace WH.Domain.Models
{
    /// <summary>
    /// warehouse
    /// </summary>
    [Table("warehouse")]
    public class Warehouse : ModelBaseName<long>
    {
        public Point Location { get; set; } = default!;
    }
}
