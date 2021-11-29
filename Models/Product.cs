using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models
{
    [Table("Products")]
    public class Product {
        [Key]
        public string ID {get; set;}
        public string Name { get; set; }     
        public string UnitPrice { get; set; }     
        public string Quantity { get; set; }
    }
}