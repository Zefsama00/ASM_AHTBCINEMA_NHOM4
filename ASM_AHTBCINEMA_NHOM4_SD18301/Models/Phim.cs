using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace AHTBCinema_NHOM4_SD18301.Models
{
    public class Phim
    {
        [Key]
        public string IdPhim { get; set; }
        public string TenPhim { get; set; }
        public Byte Hinhanh { get; set; }
        public string DangPhim { get; set; }
        [ForeignKey("LoaiPhim")]
        public string TheLoai { get; set; }
        public LoaiPhim LoaiPhim { get; set; }
        public int ThoiLuong { get; set; }
        public ICollection<CaChieu> CaChieus { get; set; }
    }
}
