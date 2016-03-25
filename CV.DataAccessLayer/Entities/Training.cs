using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Entities
{
    public class Training
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Provider { get; set; }
        [StringLength(200)]
        public string ImageUrl { get; set; }
        [StringLength(200)]
        public string WebsiteUrl { get; set; }
        [StringLength(200)]
        public string CertificateFile { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(200)]
        public string Subject { get; set; }
    }
}
