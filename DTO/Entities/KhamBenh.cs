namespace DTO.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhamBenh")]
    public partial class KhamBenh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhamBenh()
        {
            DonThuocs = new HashSet<DonThuoc>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKhamBenh { get; set; }

        public int MaBenhNhan { get; set; }

        public int? MaBacSi { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKham { get; set; }

        [StringLength(200)]
        public string ChanDoan { get; set; }

        [StringLength(200)]
        public string Thuoc { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public virtual BacSi BacSi { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonThuoc> DonThuocs { get; set; }
    }
}
