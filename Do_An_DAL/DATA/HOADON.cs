namespace Do_An_DAL.DATA
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
        [StringLength(11)]
        public string SOHD { get; set; }

        [Required]
        [StringLength(11)]
        public string MA_NV { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYLAP { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGTIEN { get; set; }

        [Required]
        [StringLength(11)]
        public string SO_PHIEU_DAT_PHONG { get; set; }

        [Required]
        [StringLength(11)]
        public string MA_PHONG { get; set; }

        public virtual CHI_TIET_PHIEU_DAT_PHONG CHI_TIET_PHIEU_DAT_PHONG { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
