using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Entities
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Caption { get; set; }
        [StringLength(100)]
        public string CaptionIconClass { get; set; }
        [StringLength(200)]
        public string ImageFrontUrl { get; set; }
        [StringLength(500)]
        public string TextFront { get; set; }
        [StringLength(200)]
        public string ImageBackUrl { get; set; }
        [StringLength(500)]
        public string TextBack { get; set; }
        [StringLength(1)]
        public string Rotate { get; set; }
    }
}
