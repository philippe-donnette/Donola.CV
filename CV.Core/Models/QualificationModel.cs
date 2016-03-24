using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Models
{
    public class QualificationModel
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ImageUrl { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string WebsiteUrl { get; set; }
        public string DegreeFile { get; set; }
    }
}
