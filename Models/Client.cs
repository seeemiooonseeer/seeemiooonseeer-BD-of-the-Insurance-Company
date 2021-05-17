using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_of_the_Insurance_Company.Models
{
    public class Client
    {
        public long ID { get; set; }
        [Display(Name = "Код клиента")]
        public long Client_ID { get; set; }
        [Display(Name = "ФИО")]
        public string Full_name { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Display(Name = "Пол")]
        public string Gender { get; set; }
        [Display(Name = "Адрес")]
        public string Adress { get; set; }
        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }
        [Display(Name = "Паспортные данные")]
        public string Passport_data { get; set; }
        [Display(Name = "Группа")]
        public DbSet<Groups> Groups_ID { get; set; }
        [Display(Name = "Код группы")]
        public long GroupsID { get; set; }
    }
}
