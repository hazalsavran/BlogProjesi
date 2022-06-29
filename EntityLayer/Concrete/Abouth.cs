using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Abouth
    {
        [Key]
        public int AbouthID { get; set; }
        public string AbouthDetails1 { get; set; }
        public string AbouthDetails2 { get; set; }
        public string AbouthImage1 { get; set; }
        public string AbouthImage2 { get; set; }
        public string AbouthMapLocation { get; set; }
        public bool AbouthStatus { get; set; }
        
    }
}
