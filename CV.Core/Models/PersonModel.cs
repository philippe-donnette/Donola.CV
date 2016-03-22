using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PrimaryImage { get; set; }
        public string AboutImage { get; set; }
        public string HomeImage { get; set; }
        public string AboutText { get; set; }
        public string AboutCaption { get; set; }
        public string AboutMotto { get; set; }
        public string Occupation { get; set; }
        public string OccupationMotto { get; set; }
        public string LinkedinUrl { get; set; }
        public string GitHubUrl { get; set; }
    }
}
