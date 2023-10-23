namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangHoa")]
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [StringLength(20)]
        public string MaHang { get; set; }

        [Required]
        [StringLength(40)]
        public string TenHang { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiHang { get; set; }

        public int SoLuong { get; set; }

        public double GiaBan { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiMatHang { get; set; }

        public DateTime ngaycapnhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
