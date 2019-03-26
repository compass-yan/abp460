using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace myAbp.Core
{
    [Table("PlayerProfessions")]
    public class PlayerProfession : FullAuditedEntity<int>
    {
        public Guid PlayerId { get; set; }
        public int FamilyId { get; set; }
        public int ProfessionId { get; set; }
        //public Profession Profession { get; set; }
        //public Family Family { get; set; }
        //public Player Player { get; set; }
        public bool IsCurrent { get; set; }

        /// <summary>
        /// 是否虚拟转职
        /// </summary>
        public bool IsVirtualRecharge { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public int Level { get; set; }
    }
}