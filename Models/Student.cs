using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models
{
    [Table("Students")]
    public class Student {
        [Key]
        public string ID {get; set;}
        public string Name { get; set; }     
        public string  Address { get; set; }     
    }
}