using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Entities
{
    public class SkillVersion
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int SkillId { get; set; }

        [ForeignKey("SkillId")]
        public virtual Skill Skill { get; set; }
    }
}
