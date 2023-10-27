namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AcountSignUp")]
    public partial class AcountSignUp
    {
        [Key]
        [StringLength(30)]
        public string Iduser { get; set; }

        [StringLength(50)]
        public string username_signup { get; set; }

        [StringLength(50)]
        public string password_signup { get; set; }
    }
}
