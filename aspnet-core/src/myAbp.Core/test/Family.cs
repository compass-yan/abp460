using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace myAbp.Core
{
    [Table("Families")]
    public class Family:FullAuditedEntity<int>
    {
    }
}