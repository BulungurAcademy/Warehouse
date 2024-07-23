using System.ComponentModel.DataAnnotations.Schema;

namespace Wh.Domain.Models
{
    /// <summary>
    ///  Information about the suppliers who provide the products.
    /// </summary>
    [Table("supplier")]
    public class Supplier : ModelBaseName<long>
    {
        [Column("contract_name")]
        public string ContractName { get; set; } = default!;

        [Column("address")]
        public string Address { get; set; } = default!;

        [Column("city")]
        public string? City { get; set; }

        [Column("postal_code")]
        public string? PostalCode { get; set; }

        [Column("country")]
        public string? Country { get; set; }
    }
}
