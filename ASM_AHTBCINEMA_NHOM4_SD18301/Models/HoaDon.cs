using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHTBCinema_NHOM4_SD18301.Models
{
    public class HoaDon
    {
        [Key]
        public int IdHD { get; set; }
        [ForeignKey("Ve")]
        public int IdVe { get; set; }
        public Ve Ve { get; set; }
        [ForeignKey("Combos")]
        public string Combo { get; set; }
        public DoAnvaNuoc Combos { get; set; }
        [ForeignKey("NhanViens")]
        public string NhanVien { get; set; }
        public NhanVien NhanViens { get; set; }
        [ForeignKey("KhachHangs")]
        public string KhachHang { get; set; }
        public KhachHang KhachHangs { get; set; }
        public int KhuyenMai {  get; set; }
        public float TongTien { get;set; }
        
    }
}
