namespace DTO.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiSoYTe")]
    public partial class ChiSoYTe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaChiSo { get; set; }

        public int MaBenhNhan { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDo { get; set; }

        public double? ChieuCao { get; set; }

        public double? CanNang { get; set; }

        [StringLength(20)]
        public string HuyetAp { get; set; }

        public int? NhipTim { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }
    }
}
