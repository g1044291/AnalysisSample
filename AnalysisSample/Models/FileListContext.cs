using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AnalysisSample.Models;

public partial class FileListContext : DbContext
{
    public FileListContext()
    {
    }

    public FileListContext(DbContextOptions<FileListContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DirectoryManagementMaster> DirectoryManagementMasters { get; set; }

    public virtual DbSet<FileList> FileLists { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TagMaster> TagMasters { get; set; }

    public virtual DbSet<VDuplicateList> VDuplicateLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=NucBox5;Database=FileList;User Id=admin;Password=admin;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Japanese_CI_AS");

        modelBuilder.Entity<DirectoryManagementMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DirectoryManagementMaster");

            entity.Property(e => e.DirectoryName).HasMaxLength(50);
            entity.Property(e => e.ParentDirecotry).HasMaxLength(50);
            entity.Property(e => e.TempDirectory).HasMaxLength(50);
        });

        modelBuilder.Entity<FileList>(entity =>
        {
            entity.ToTable("FileList");

            entity.Property(e => e.DirectoryName).HasMaxLength(255);
            entity.Property(e => e.Extension).HasMaxLength(50);
            entity.Property(e => e.Size).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ViewsCount).HasDefaultValue(0);
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.Property(e => e.TagName).HasMaxLength(20);
        });

        modelBuilder.Entity<TagMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TagMaster");

            entity.Property(e => e.TagName).HasMaxLength(20);
        });

        modelBuilder.Entity<VDuplicateList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_DuplicateList");

            entity.Property(e => e.Size).HasColumnType("decimal(18, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
