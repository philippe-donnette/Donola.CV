using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV.DataAccessLayer.Entities
{
    public class ProjectImage
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string ImageUrl { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
    }
}
