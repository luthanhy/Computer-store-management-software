namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Required]
        [StringLength(20)]
        public string MaHH { get; set; }

        [Required]
        [StringLength(20)]
        public string MaHD { get; set; }

        public int SoLuong { get; set; }

        public double DonGia { get; set; }

        [Key]
        [StringLength(20)]
        public string MAChiTietHD { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual HangHoa HangHoa { get; set; }
    }
}
