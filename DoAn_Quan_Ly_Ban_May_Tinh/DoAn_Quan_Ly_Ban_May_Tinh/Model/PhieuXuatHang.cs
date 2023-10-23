namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuXuatHang")]
    public partial class PhieuXuatHang
    {
        [Required]
        [StringLength(20)]
        public string SoPhieu { get; set; }

        public DateTime NgayTao { get; set; }

        public int SoLuong { get; set; }

        [Required]
        [StringLength(20)]
        public string MAKH { get; set; }

        [Required]
        [StringLength(20)]
        public string MAHD { get; set; }

        [Key]
        [StringLength(20)]
        public string MaPX { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
