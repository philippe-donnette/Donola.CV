using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Core.Models
{
    public class CardModel
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string CaptionIconClass { get; set; }
        public string ImageFrontUrl { get; set; }
        public string TextFront { get; set; }
        public string ImageBackUrl { get; set; }
        public string TextBack { get; set; }
        public string Rotate { get; set; }
    }
}
