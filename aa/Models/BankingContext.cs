using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace aa.Models
{
    public partial class BankingContext : DbContext
    {
        public BankingContext()
        {
        }

        public BankingContext(DbContextOptions<BankingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customeraccount> Customeraccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Banking;Username=postgres;Password=Darshan@2915");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customeraccount>(entity =>
            {
                entity.HasKey(e => e.Accnumber)
                    .HasName("account_accnumber_pk");

                entity.ToTable("customeraccount");

                entity.Property(e => e.Accnumber).HasColumnName("accnumber");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .HasColumnName("city");

                entity.Property(e => e.Custid)
                    .HasMaxLength(6)
                    .HasColumnName("custid");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lasttname)
                    .HasMaxLength(30)
                    .HasColumnName("lasttname");

                entity.Property(e => e.Mobileno)
                    .HasMaxLength(10)
                    .HasColumnName("mobileno");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(10)
                    .HasColumnName("occupation");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
