using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace myAbp.Core
{
    [Table("Babies")]
    public class Baby : FullAuditedEntity<int>
    {
        private string name;

        /// <summary>
        /// 宝宝名称
        /// </summary>
        public string Name { get; set; }

       
        public int FamilyId { get; set; }
        public Family Family { get; set; }
    
    }
    }