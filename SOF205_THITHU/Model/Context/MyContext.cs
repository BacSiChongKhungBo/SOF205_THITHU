using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SOF205_THITHU.Model.DomainClass;

namespace SOF205_THITHU.Model.Context;

public partial class MyContext : DbContext
{
    public MyContext()
    {
    }

    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chunhan> Chunhans { get; set; }

    public virtual DbSet<Cuahang> Cuahangs { get; set; }

    public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }

    public virtual DbSet<Phuhuynh> Phuhuynhs { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Sinhvien> Sinhviens { get; set; }

    public virtual DbSet<Thucung> Thucungs { get; set; }

    public virtual DbSet<Trungtam> Trungtams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= LAPTOP-S8183VSG\\SQLEXPRESS ;Initial Catalog= SOF205_FINAL_TEST;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chunhan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHUNHAN__3213E83F44B213F2");
        });

        modelBuilder.Entity<Cuahang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUAHANG__3213E83F2043706E");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.Cuahangs).HasConstraintName("FKCH_TT");
        });

        modelBuilder.Entity<Nhacungcap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NHACUNGC__3213E83FEC1A3CAF");
        });

        modelBuilder.Entity<Phuhuynh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PHUHUYNH__3213E83F0F06610A");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SANPHAM__3213E83FB7F39D54");

            entity.HasOne(d => d.IdNccNavigation).WithMany(p => p.Sanphams).HasConstraintName("FK_SP_NCC");
        });

        modelBuilder.Entity<Sinhvien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SINHVIEN__3213E83FFBDD1BBA");

            entity.HasOne(d => d.IdPhNavigation).WithMany(p => p.Sinhviens).HasConstraintName("FK_SV_PH");
        });

        modelBuilder.Entity<Thucung>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__THUCUNG__3213E83FAF020A8B");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.Thucungs).HasConstraintName("FK_TC_CN");
        });

        modelBuilder.Entity<Trungtam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TRUNGTAM__3213E83F100035CB");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
