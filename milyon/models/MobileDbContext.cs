using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace milyon.models;

public partial class MobileDbContext : DbContext
{
    public MobileDbContext()
    {
    }

    public MobileDbContext(DbContextOptions<MobileDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Mobile> Mobiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-MB2H1NT;Database=Mobile Db;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mobile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mobiles__3214EC0753F7B75D");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BrandName).HasColumnType("text");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("text")
                .HasColumnName("Created_at");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
