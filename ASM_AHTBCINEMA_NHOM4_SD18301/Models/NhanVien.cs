using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AHTBCinema_NHOM4_SD18301.Models
{
    public class NhanVien
    {
        [Key]
        public int IdNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public DateTime NamSinh { get; set;}
        public string ChucVu { get; set; }
        public string Password { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
