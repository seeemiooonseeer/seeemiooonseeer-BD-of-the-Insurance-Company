using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_of_the_Insurance_Company.Models
{
    public class Risks
    {
        public long ID { get; set; }
        [Display(Name = "Код риска")]
        public long Risks_ID { get; set; }
        [Display(Name = "Наименование риска")]
        public string Risks_name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Средняя вероятность")]
        public int Average_Probability { get; set; }
    }
}
