namespace Do_An_DAL.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_DAT_PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_DAT_PHONG()
        {
            CHI_TIET_PHIEU_DAT_PHONG = new HashSet<CHI_TIET_PHIEU_DAT_PHONG>();
        }

        [Key]
        [StringLength(11)]
        public string SO_PHIEU_DAT_PHONG { get; set; }

        [Required]
        [StringLength(11)]
        public string MA_KH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYLAP { get; set; }

        [Column(TypeName = "money")]
        public decimal? DATCOC { get; set; }

        [Column(TypeName = "money")]
        public decimal? TONGTIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHIEU_DAT_PHONG> CHI_TIET_PHIEU_DAT_PHONG { get; set; }

        public virtual KHACH_HANG KHACH_HANG { get; set; }
    }
}
