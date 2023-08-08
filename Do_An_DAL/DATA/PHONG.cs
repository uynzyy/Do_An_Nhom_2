namespace Do_An_DAL.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            CHI_TIET_PHIEU_DAT_PHONG = new HashSet<CHI_TIET_PHIEU_DAT_PHONG>();
            TIEN_NGHI = new HashSet<TIEN_NGHI>();
        }

        [Key]
        [StringLength(11)]
        public string MA_PHONG { get; set; }

        [StringLength(11)]
        public string SO_PHONG { get; set; }

        public bool? TRANG_THAI { get; set; }

        public byte? TANG { get; set; }

        [Required]
        [StringLength(11)]
        public string MA_LOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PHIEU_DAT_PHONG> CHI_TIET_PHIEU_DAT_PHONG { get; set; }

        public virtual LOAI_PHONG LOAI_PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIEN_NGHI> TIEN_NGHI { get; set; }
    }
}
