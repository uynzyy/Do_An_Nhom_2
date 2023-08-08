namespace Do_An_DAL.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHACH_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH_HANG()
        {
            PHIEU_DAT_PHONG = new HashSet<PHIEU_DAT_PHONG>();
        }

        [Key]
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

        [StringLength(255)]
        public string EMAIL { get; set; }

        [StringLength(255)]
        public string DIACHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_DAT_PHONG> PHIEU_DAT_PHONG { get; set; }
    }
}
