using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_of_the_Insurance_Company.Models
{
    public class Policies
    {
        public long ID { get; set; }
        [Display(Name = "Номер полиса")]
        public long Policies_ID { get; set; }
        [Display(Name = "Дата начала")]
        public DateTime Start_date { get; set; }
        [Display(Name = "Дата окончания")]
        public DateTime End_date { get; set; }
        [Display(Name = "Стоимость")]
        public int Cost { get; set; }
        [Display(Name = "Сумма выплаты")]
        public int Payment_amount { get; set; }
        [Display(Name = "Вид полиса")]
        public DbSet<Policy_type> Policy_type_ID { get; set; }
        [Display(Name = "Код вида полиса")]
        public long Policy_typeID { get; set; }
        [Display(Name = "Отметка о выплате")]
        public string Payment_mark { get; set; }
        [Display(Name = " Отметка об окончании")]
        public string End_mark { get; set; }
        [Display(Name = "Клиент")]
        public DbSet<Client> Clients_ID { get; set; }
        [Display(Name = "Код клиента")]
        public long ClientsID { get; set; }
        [Display(Name = "Сотрудник")]
        public DbSet<Staff> Staff_ID { get; set; }
        [Display(Name = "Код сотрудника")]
        public long StaffID { get; set; }
    }
}
