using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Entities
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public int ExperienceRating { get; set; }
        public int InterestRating { get; set; }
        public int UsageRating { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(200)]
        public string IconClass { get; set; }
        public bool IsVisible { get; set; }

        public virtual ICollection<SkillVersion> Versions { get; set; }
    }
}
