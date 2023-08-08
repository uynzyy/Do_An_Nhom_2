namespace Do_An_DAL.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIEN_NGHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIEN_NGHI()
        {
            PHONGs = new HashSet<PHONG>();
        }

        [Key]
        [StringLength(11)]
        public string MA_TN { get; set; }

        [StringLength(30)]
        public string TEN_TN { get; set; }

        [StringLength(30)]
        public string KICH_THUOC { get; set; }

        [StringLength(20)]
        public string MAU_SAC { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONGs { get; set; }
    }
}
