using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Entities
{
    public class ProjectSkillVersion
    {
        public int ProjectId { get; set; }
        public int SkillId { get; set; }
        public int SkillVersionId { get; set; }

        [ForeignKey("SkillVersionId")]
        public virtual SkillVersion Version { get; set; }
        public virtual ProjectSkill ProjectSkill { get; set; }
    }
}
