﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string Firstname { get; set; }
        [StringLength(200)]
        public string Lastname { get; set; }
        [StringLength(200)]
        public string PrimaryImage { get; set; }
        [StringLength(200)]
        public string AboutImage { get; set; }
        [StringLength(200)]
        public string HomeImage { get; set; }
        [StringLength(1000)]
        public string AboutText { get; set; }
        [StringLength(200)]
        public string AboutCaption { get; set; }
        [StringLength(400)]
        public string AboutMotto { get; set; }
        [StringLength(200)]
        public string Occupation { get; set; }
        [StringLength(400)]
        public string OccuptionMotto { get; set; }
        [StringLength(400)]
        public string LinkedinUrl { get; set; }
        [StringLength(400)]
        public string GitHubUrl { get; set; }
    }
}
