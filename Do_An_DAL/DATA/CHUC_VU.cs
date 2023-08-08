namespace Do_An_DAL.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHUC_VU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUC_VU()
        {
            NHAN_VIEN = new HashSet<NHAN_VIEN>();
        }

        [Key]
        [StringLength(11)]
        public string MA_CV { get; set; }

        [StringLength(30)]
        public string TEN_CV { get; set; }

        public int? LCB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAN_VIEN> NHAN_VIEN { get; set; }
    }
}
