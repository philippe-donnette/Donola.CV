using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV.DataAccessLayer.Entities
{
    public class ProjectSkill
    {
        public int ProjectId { get; set; }
        public int SkillId { get; set; }
        public int UsageRating { get; set; }

        public virtual Project Project { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
