using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_of_the_Insurance_Company.Models
{
    public class Position
    {
        public long ID { get; set; }
        [Display(Name = "Код должности")]
        public long Position_ID { get; set; }
        [Display(Name = "Наименование должности")]
        public string Position_name { get; set; }
        [Display(Name = "Оклад")]
        public int Salary { get; set; }
        [Display(Name = "Обязанности")]
        public string Responsibilities { get; set; }
        [Display(Name = "Требования")]
        public string Requirements { get; set; }
        
    }
}
