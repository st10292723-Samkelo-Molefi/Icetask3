using System;
using System.Collections.Generic;
using IceTask3.Models;
using Microsoft.EntityFrameworkCore;

namespace IceTask3.Data;

public partial class IceTask3DbContext : DbContext
{
    public IceTask3DbContext()
    {
    }

    public IceTask3DbContext(DbContextOptions<IceTask3DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52A7925F14F33");

            entity.ToTable("Student");

            entity.HasIndex(e => e.Stnumber, "UQ__Student__D03461351FD68403").IsUnique();

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProfilePicture).IsUnicode(false);
            entity.Property(e => e.Stnumber)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("STnumber");
            entity.Property(e => e.Surname).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
