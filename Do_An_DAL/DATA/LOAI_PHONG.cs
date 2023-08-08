namespace Do_An_DAL.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAI_PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_PHONG()
        {
            PHONGs = new HashSet<PHONG>();
        }

        [Key]
        [StringLength(11)]
        public string MA_LOAI { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIA_THUE_PHONG { get; set; }

        [Column("LOAI_PHONG")]
        [StringLength(50)]
        public string LOAI_PHONG1 { get; set; }

        public short? SO_LUONG_NGUOI_TOI_DA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONGs { get; set; }
    }
}
