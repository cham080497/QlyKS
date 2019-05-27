namespace QLKS_TTN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [StringLength(40)]
        public string USERNAME { get; set; }

        [StringLength(40)]
        public string MATKHAU { get; set; }

        public int? MANV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
