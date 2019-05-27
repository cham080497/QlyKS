namespace QLKS_TTN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAHD { get; set; }

        public int? MATHUEPHONG { get; set; }

        public int? MANV { get; set; }

        public int? MAKH { get; set; }

        public int? THANHTIEN { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual THUEPHONG THUEPHONG { get; set; }
    }
}
