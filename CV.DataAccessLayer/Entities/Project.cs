using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Entities
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public byte[] PrimaryImage { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        
        public virtual ICollection<ProjectSkill> Skills { get; set; }
    }
}
