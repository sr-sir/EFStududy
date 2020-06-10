using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFStudy.Models
{
    public class address
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "省")]
        public string province { get; set; }
        [Display(Name = "市")]
        public string city { get; set; }
        [Display(Name = "区")]
        public string area { get; set; }
        [Display(Name = "街道")]
        public string stree { get; set; }
        [Display(Name = "测试")]
        public string green { get; set; }

    }
}
