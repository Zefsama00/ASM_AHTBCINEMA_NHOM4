using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AHTBCinema_NHOM4_SD18301.Models
{
    public class KhachHang
    {
        [Key]
        public string IdKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set;}
        public DateTime NamSinh { get; set; }
        public string Email { get; set;}
        public string Password { get; set;}
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
