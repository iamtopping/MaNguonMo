using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models
{
    [Table("Persons")]
    public class Person {
        [Key]
        public string ID {get; set;}
        public string Name { get; set; }         
    }
}