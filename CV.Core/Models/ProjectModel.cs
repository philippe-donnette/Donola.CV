using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryImage { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
    }
}
