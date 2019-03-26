using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace myAbp.Core
{
    [Table("Families")]
    public class Family:FullAuditedEntity<int>
    {
        public Guid MotherId { get; set; }

        public Guid FatherId { get; set; }
    }
}