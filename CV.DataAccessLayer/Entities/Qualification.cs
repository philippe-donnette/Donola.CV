using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Entities
{
    public class Qualification
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string SchoolName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [StringLength(200)]
        public string ImageUrl { get; set; }
        [StringLength(200)]
        public string City { get; set; }
        [StringLength(200)]
        public string Country { get; set; }
        [StringLength(200)]
        public string Subject { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(200)]
        public string WebsiteUrl { get; set; }
        [StringLength(200)]
        public string DegreeFile { get; set; }
    }
}
