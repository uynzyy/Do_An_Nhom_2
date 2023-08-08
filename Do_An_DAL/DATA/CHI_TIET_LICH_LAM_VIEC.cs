namespace Do_An_DAL.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_LICH_LAM_VIEC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(11)]
        public string MA_NV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(11)]
        public string MA_LICH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAY_LAM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? GIO_BAT_DAU { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? GIO_KET_THUC { get; set; }

        public virtual LICH_LAM_VIEC LICH_LAM_VIEC { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
