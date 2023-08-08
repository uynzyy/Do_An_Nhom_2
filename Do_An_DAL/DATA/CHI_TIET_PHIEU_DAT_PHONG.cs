namespace Do_An_DAL.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_PHIEU_DAT_PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHI_TIET_PHIEU_DAT_PHONG()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(11)]
        public string SO_PHIEU_DAT_PHONG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(11)]
        public string MA_PHONG { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAY_DAT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAY_TRA { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual PHIEU_DAT_PHONG PHIEU_DAT_PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
