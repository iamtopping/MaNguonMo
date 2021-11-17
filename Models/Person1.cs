using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Peoples")]
    public class Person {
        [Key]
        public string ID {get; set;}
        public string Name { get; set; }         
    }
}