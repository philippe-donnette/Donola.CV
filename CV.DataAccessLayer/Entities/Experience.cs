using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Entities
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        [StringLength(300)]
        public string CompanyName { get; set; }
        [StringLength(300)]
        public string WebsiteUrl { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string Country { get; set; }
        [StringLength(200)]
        public string RoleTitle { get; set; }
        [StringLength(3000)]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [StringLength(200)]
        public string ImageUrl { get; set; }
        
        public virtual ICollection<ExperienceSkill> Skills { get; set; }
    }
}
