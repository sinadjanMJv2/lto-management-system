using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Queueing_Management_System.Entities
{
    public partial class lto_queueng_management_systemContext : DbContext
    {
        public lto_queueng_management_systemContext()
        {
        }

        public lto_queueng_management_systemContext(DbContextOptions<lto_queueng_management_systemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Staffing> Staffings { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=lto_queueng_management_system;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.Property(e => e.AdminId)
                    .HasColumnType("int(11)")
                    .HasColumnName("admin_id");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(250)
                    .HasColumnName("fullname");

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(250)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("booking");

                entity.Property(e => e.BookingId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bookingId");

                entity.Property(e => e.Age)
                    .HasColumnType("int(11)")
                    .HasColumnName("age");

                entity.Property(e => e.BookingDate)
                    .HasMaxLength(250)
                    .HasColumnName("bookingDate");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(250)
                    .HasColumnName("firstname");

                entity.Property(e => e.Gmail)
                    .HasMaxLength(250)
                    .HasColumnName("gmail");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(250)
                    .HasColumnName("lastname");

                entity.Property(e => e.Middlename)
                    .HasMaxLength(250)
                    .HasColumnName("middlename");

                entity.Property(e => e.Prioritynumber)
                    .HasMaxLength(250)
                    .HasColumnName("prioritynumber");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("status");

                entity.Property(e => e.TransactionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("transactionId");

                entity.Property(e => e.ValidId)
                    .HasMaxLength(250)
                    .HasColumnName("validID");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.Property(e => e.ClientId)
                    .HasColumnType("int(11)")
                    .HasColumnName("clientId");

                entity.Property(e => e.Age)
                    .HasColumnType("int(11)")
                    .HasColumnName("age");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(250)
                    .HasColumnName("firstname");

                entity.Property(e => e.Gmail)
                    .HasMaxLength(250)
                    .HasColumnName("gmail");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(250)
                    .HasColumnName("lastname");

                entity.Property(e => e.Middlename)
                    .HasMaxLength(250)
                    .HasColumnName("middlename");

                entity.Property(e => e.ValidId)
                    .HasMaxLength(250)
                    .HasColumnName("validId");
            });

            modelBuilder.Entity<Staffing>(entity =>
            {
                entity.HasKey(e => e.StaffId)
                    .HasName("PRIMARY");

                entity.ToTable("staffing");

                entity.Property(e => e.StaffId)
                    .HasColumnType("int(11)")
                    .HasColumnName("staff_id");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(250)
                    .HasColumnName("fullname");

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .HasColumnName("password");

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .HasColumnName("status");

                entity.Property(e => e.Username)
                    .HasMaxLength(250)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transaction");

                entity.Property(e => e.TransactionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("transaction_id");

                entity.Property(e => e.TransactionName)
                    .HasMaxLength(250)
                    .HasColumnName("transaction_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
