namespace Do_An_DAL.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DataGridView_Tab3
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(11)]
        public string SO_PHIEU_DAT_PHONG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(11)]
        public string MA_KH { get; set; }

        [StringLength(100)]
        public string TEN_KH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(15)]
        public string CCCD { get; set; }

        [StringLength(13)]
        public string SDT { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(11)]
        public string MA_PHONG { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAY_DAT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAY_TRA { get; set; }

        [Column(TypeName = "money")]
        public decimal? DATCOC { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGTIEN { get; set; }
    }
}
