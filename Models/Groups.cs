using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_of_the_Insurance_Company.Models
{
    public class Groups
    {
        public long ID { get; set; }
        [Display(Name = "Код группы")]
        public long Groups_ID { get; set; }
        [Display(Name = "Наименование группы")]
        public string Groups_name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}
