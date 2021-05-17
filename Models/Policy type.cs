using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_of_the_Insurance_Company.Models
{
    public class Policy_type
    {
        public long ID { get; set; }
        [Display(Name = "Код вида полиса")]
        public long Policy_type_ID { get; set; }
        [Display(Name = "Наименование вида полиса")]
        public string Policy_type_name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Условия")]
        public string Conditions { get; set; }
        [Display(Name = "Риск 1")]
        public DbSet<Risks> Risks_ID1 { get; set; }
        [Display(Name = " Код риска 1")]
        public long RisksID1 { get; set; }
        [Display(Name = "Риск 2")]
        public DbSet<Risks> Risks_ID2 { get; set; }
        [Display(Name = " Код риска 2")]
        public long RisksID2 { get; set; }
        [Display(Name = "Риск 3")]
        public DbSet<Risks> Risks_ID3 { get; set; }
        [Display(Name = " Код риска 3")]
        public long RisksID3 { get; set; }
    }
}
