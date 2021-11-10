using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models
{
    [Table("Employees")]
    public class Employee {
        [Key]
        public string ID {get; set;}
        public string Name { get; set; }     
            public string  PhoneNumber { get; set; }     
    }
}