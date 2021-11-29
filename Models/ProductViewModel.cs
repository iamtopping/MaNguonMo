using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MaNguonMo.Models
{
    public class ProductViewModel
    {
        public List<Product> Products {get; set;}
        public SelectList Quantitys {get; set;}
        public string productName { get; set; }
        public string quantityType { get; set; }
    }
}