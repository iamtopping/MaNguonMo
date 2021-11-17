using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models
{
    [Table("Students")]
    public class Students : Person {
        [Key]
        public string University {get; set;}
        public string Address { get; set; }     
        public string  FullName{ get; set; }     
    }
}