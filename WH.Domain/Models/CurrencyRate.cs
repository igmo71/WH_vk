using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WH.Domain.Models
{
    public class CurrencyRate
    {
        public Guid Id { get; set; }

        [Column(TypeName = nameof(SqlDbType.Date))]
        public DateTime Date { get; set; }

        [MaxLength(6)]
        public string? CurrencyCode { get; set; }

        public decimal Value { get; set; }
    }
}
