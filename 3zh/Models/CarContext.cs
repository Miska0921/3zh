using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _3zh.Models;

public partial class CarContext : DbContext
{
    public CarContext()
    {
    }

    public CarContext(DbContextOptions<CarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Model> Models { get; set; }

    public virtual DbSet<UpForSale> UpForSales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\vancs\\source\\repos\\3zh\\3zh\\hasznaltauto.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Brand__3213E83FCCD7141D");

            entity.ToTable("Brand");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Model__3213E83FAB6FBA1C");

            entity.ToTable("Model");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.Brand).WithMany(p => p.Models)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK__Model__brand_id__38996AB5");
        });

        modelBuilder.Entity<UpForSale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UpForSal__3213E83F591D4135");

            entity.ToTable("UpForSale");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Fuel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fuel");
            entity.Property(e => e.Horsepower).HasColumnName("horsepower");
            entity.Property(e => e.Mileage).HasColumnName("mileage");
            entity.Property(e => e.ModelId).HasColumnName("model_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Seller)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seller");

            entity.HasOne(d => d.Brand).WithMany(p => p.UpForSales)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK__UpForSale__brand__44FF419A");

            entity.HasOne(d => d.Model).WithMany(p => p.UpForSales)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("FK__UpForSale__model__45F365D3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
