using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaNguonMo.Models
{
    [Table("KhachHangs")]
    public class KhachHang {
        [Key]
        public string KhachHangID {get; set;}
        public string TenKhachHang { get; set; }
        public int SDT { get; set; }    
        public ICollection<HoaDon> HoaDons {get; set;}
    }
}
