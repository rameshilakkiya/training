using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LocalBusiness1.Models
{
    public partial class LocalBussinessdfaContext : DbContext
    {
        public LocalBussinessdfaContext()
        {
        }

        public LocalBussinessdfaContext(DbContextOptions<LocalBussinessdfaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Users2> Users2s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LocalBussinessdfa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rolename");
            });

            modelBuilder.Entity<Users2>(entity =>
            {
                entity.ToTable("users2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Zipcode).HasColumnName("zipcode");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users2s)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__users2__role_id__2C3393D0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
