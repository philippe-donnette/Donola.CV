using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Entities
{
    public class ExperienceSkillVersion
    {
        public int ExperienceId { get; set; }
        public int SkillId { get; set; }
        public int SkillVersionId { get; set; }

        [ForeignKey("SkillVersionId")]
        public virtual SkillVersion Version { get; set; }
        public virtual ExperienceSkill ExperienceSkill { get; set; }
    }
}
