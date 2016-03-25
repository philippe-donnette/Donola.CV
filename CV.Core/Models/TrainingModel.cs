using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Models
{
    public class TrainingModel
    {
        public int Id { get; set; }
        public string Provider { get; set; }
        public string ImageUrl { get; set; }
        public string WebsiteUrl { get; set; }
        public string CertificateFile { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
    }
}
