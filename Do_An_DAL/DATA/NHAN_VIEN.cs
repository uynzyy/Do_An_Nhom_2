namespace Do_An_DAL.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAN_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAN_VIEN()
        {
            CHI_TIET_LICH_LAM_VIEC = new HashSet<CHI_TIET_LICH_LAM_VIEC>();
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(11)]
        public string MA_NV { get; set; }

        [StringLength(100)]
        public string TEN_NV { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYSINH { get; set; }

        public bool? GIOITINH { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [Required]
        [StringLength(15)]
        public string CCCD { get; set; }

        [StringLength(255)]
        public string EMAIL { get; set; }

        [StringLength(255)]
        public string DIACHI { get; set; }

        [Required]
        [StringLength(11)]
        public string MA_CV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_LICH_LAM_VIEC> CHI_TIET_LICH_LAM_VIEC { get; set; }

        public virtual CHUC_VU CHUC_VU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
