using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV.DataAccessLayer.Entities
{
    public class ExperienceSkill
    {
        public int ExperienceId { get; set; }
        public int SkillId { get; set; }
        public int UsageRating { get; set; }

        public virtual Experience Experience { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual ICollection<ExperienceSkillVersion> Versions { get; set; }
    }
}
