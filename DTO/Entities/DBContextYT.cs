using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DTO.Entities
{
    public partial class DBContextYT : DbContext
    {
        public DBContextYT()
            : base("name=DBContextYT")
        {
        }

        public virtual DbSet<BacSi> BacSis { get; set; }
        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<ChiSoYTe> ChiSoYTes { get; set; }
        public virtual DbSet<ChiTietDonThuoc> ChiTietDonThuocs { get; set; }
        public virtual DbSet<DonThuoc> DonThuocs { get; set; }
        public virtual DbSet<KhamBenh> KhamBenhs { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BacSi>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.CMND_CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<KhamBenh>()
                .HasMany(e => e.DonThuocs)
                .WithOptional(e => e.KhamBenh)
                .WillCascadeOnDelete();
        }
    }
}
