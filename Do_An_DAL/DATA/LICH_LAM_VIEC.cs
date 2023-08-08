namespace Do_An_DAL.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LICH_LAM_VIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LICH_LAM_VIEC()
        {
            CHI_TIET_LICH_LAM_VIEC = new HashSet<CHI_TIET_LICH_LAM_VIEC>();
        }

        [Key]
        [StringLength(11)]
        public string MA_LICH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_LICH_LAM_VIEC> CHI_TIET_LICH_LAM_VIEC { get; set; }
    }
}
