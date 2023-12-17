using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Models;

public partial class LalatdigitallibraryContext : DbContext
{
    public LalatdigitallibraryContext()
    {
    }

    public LalatdigitallibraryContext(DbContextOptions<LalatdigitallibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<StatusType> StatusTypes { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<TblBook> TblBooks { get; set; }

    public virtual DbSet<TblBranch> TblBranches { get; set; }

    public virtual DbSet<TblIpaddress> TblIpaddresses { get; set; }

    public virtual DbSet<TblPenalty> TblPenalties { get; set; }

    public virtual DbSet<TblPublication> TblPublications { get; set; }

    public virtual DbSet<TblRent> TblRents { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserCred> UserCreds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=sql.bsite.net\\MSSQL2016;Database=lalatdigitallibrary_;TrustServerCertificate=True;User Id=lalatdigitallibrary_;Password=DigitalLibraryDev;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<StatusType>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Students__32C52B99A4AA7C1B");

            entity.Property(e => e.Address)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Images)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.PinCode)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblBook>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__tblBooks__3DE0C20714079914");

            entity.ToTable("tblBooks");

            entity.Property(e => e.Author)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.BookName)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Branch)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasColumnType("datetime");
            entity.Property(e => e.Detail)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Images)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.Pdf).IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Publication)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblBranch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("PK__tblBranc__A1682FC5F834507C");

            entity.ToTable("tblBranch");

            entity.Property(e => e.BranchName)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblIpaddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblIPAdd__3214EC0795ADB253");

            entity.ToTable("tblIPAddress");

            entity.Property(e => e.Ipaddress)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
        });

        modelBuilder.Entity<TblPenalty>(entity =>
        {
            entity.HasKey(e => e.PenaltyId).HasName("PK__tblPenal__567E06C774C9B9C8");

            entity.ToTable("tblPenalty");

            entity.Property(e => e.BookName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Detail)
                .HasMaxLength(512)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblPublication>(entity =>
        {
            entity.HasKey(e => e.PublicationId).HasName("PK__tblPubli__05E6DC388131303B");

            entity.ToTable("tblPublication");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PublicationName)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblRent>(entity =>
        {
            entity.HasKey(e => e.RentId).HasName("PK__tblRent__783D47F5588A1113");

            entity.ToTable("tblRent");

            entity.Property(e => e.BookName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.IssueDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.Stats)
                .HasMaxLength(512)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.StatusTypeId).HasDefaultValueSql("((1))");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Roles");

            entity.HasOne(d => d.StatusType).WithMany(p => p.Users)
                .HasForeignKey(d => d.StatusTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_StatusTypes");
        });

        modelBuilder.Entity<UserCred>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.UserPwd)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithOne(p => p.UserCred)
                .HasForeignKey<UserCred>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserCreds_Users");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
