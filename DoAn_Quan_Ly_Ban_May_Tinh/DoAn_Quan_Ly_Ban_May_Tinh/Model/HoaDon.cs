namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            PhieuXuatHangs = new HashSet<PhieuXuatHang>();
        }

        [Key]
        [StringLength(20)]
        public string MaHoaDo { get; set; }

        [Required]
        [StringLength(20)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(20)]
        public string SoHoaDon { get; set; }

        public DateTime NgayLap { get; set; }

        public double ThanhTien { get; set; }

        public double VAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuatHang> PhieuXuatHangs { get; set; }
    }
}
