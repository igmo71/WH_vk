using System.ComponentModel.DataAnnotations;

namespace WH.Api.Jobs
{
    public class JobResult
    {
        public Guid Id { get; set; }

        [MaxLength(100)]
        public required string Name { get; set; }

        //[Column(TypeName = nameof(SqlDbType.Date))]
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

        public bool Success { get; set; }
    }
}
