namespace DTO.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonThuoc")]
    public partial class ChiTietDonThuoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaChiTiet { get; set; }

        public int MaDonThuoc { get; set; }

        [Required]
        [StringLength(100)]
        public string TenThuoc { get; set; }

        [StringLength(50)]
        public string LieuLuong { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(100)]
        public string CachDung { get; set; }

        public virtual DonThuoc DonThuoc { get; set; }
    }
}
