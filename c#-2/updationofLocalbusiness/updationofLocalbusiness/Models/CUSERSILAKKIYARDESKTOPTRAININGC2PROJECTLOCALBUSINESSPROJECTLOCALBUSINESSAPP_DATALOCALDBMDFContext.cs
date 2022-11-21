using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace updationofLocalbusiness.Models
{
    public partial class CUSERSILAKKIYARDESKTOPTRAININGC2PROJECTLOCALBUSINESSPROJECTLOCALBUSINESSAPP_DATALOCALDBMDFContext : DbContext
    {
        public CUSERSILAKKIYARDESKTOPTRAININGC2PROJECTLOCALBUSINESSPROJECTLOCALBUSINESSAPP_DATALOCALDBMDFContext()
        {
        }

        public CUSERSILAKKIYARDESKTOPTRAININGC2PROJECTLOCALBUSINESSPROJECTLOCALBUSINESSAPP_DATALOCALDBMDFContext(DbContextOptions<CUSERSILAKKIYARDESKTOPTRAININGC2PROJECTLOCALBUSINESSPROJECTLOCALBUSINESSAPP_DATALOCALDBMDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<Servicebooking> Servicebookings { get; set; } = null!;
        public virtual DbSet<Serviceprovider> Serviceproviders { get; set; } = null!;
        public virtual DbSet<Users1> Users1s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\ILAKKIYA.R\\DESKTOP\\TRAINING\\C#-2\\PROJECTLOCALBUSINESS\\PROJECTLOCALBUSINESS\\APP_DATA\\LOCALDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rolename");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("services");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Servicebooking>(entity =>
            {
                entity.ToTable("servicebooking");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Providerdescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("providerdescription");

                entity.Property(e => e.Serviceid).HasColumnName("serviceid");

                entity.Property(e => e.Spid).HasColumnName("spid");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Servicebookings)
                    .HasForeignKey(d => d.Serviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_servicebooking_ToTable");

                entity.HasOne(d => d.Sp)
                    .WithMany(p => p.Servicebookings)
                    .HasForeignKey(d => d.Spid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_servicebooking_ToTable_1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Servicebookings)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_servicebooking_ToTable_2");
            });

            modelBuilder.Entity<Serviceprovider>(entity =>
            {
                entity.ToTable("serviceprovider");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Serviceid).HasColumnName("serviceid");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength();

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Serviceproviders)
                    .HasForeignKey(d => d.Serviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_serviceprovider_ToTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Serviceproviders)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_serviceprovider_ToTable_1");
            });

            modelBuilder.Entity<Users1>(entity =>
            {
                entity.ToTable("users1");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Lastlogin)
                    .HasColumnType("datetime")
                    .HasColumnName("lastlogin");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.Mobile).HasColumnName("mobile");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Zipcode).HasColumnName("zipcode");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users1s)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_users1_ToTable");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
