namespace QLKS_TTN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUDUNGDV")]
    public partial class SUDUNGDV
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MASD { get; set; }

        public int? MATHUEPHONG { get; set; }

        public int? MADV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSD { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual THUEPHONG THUEPHONG { get; set; }
    }
}
