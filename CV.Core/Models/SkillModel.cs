using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Models
{
    public class SkillModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IconClass { get; set; }
        public int ExperienceRating { get; set; }
        public int UsageRating { get; set; }
        public int InterestRating { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        
        public List<string> Versions { get; set; }
    }
}
