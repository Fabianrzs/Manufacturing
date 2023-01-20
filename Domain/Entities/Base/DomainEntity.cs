using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Base
{
    public class DomainEntity
    {
        [Key]
        public Guid Id { get; set; }
        public int State { get; set; }

    }
}
