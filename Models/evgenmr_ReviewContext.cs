using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Review.Models
{
    public partial class evgenmr_ReviewContext : DbContext
    {
        public evgenmr_ReviewContext()
        {
        }

        public evgenmr_ReviewContext(DbContextOptions<evgenmr_ReviewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MonthRewiev> MonthRewiev { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=sql.freeasphost.net\\MSSQL2016;Database=evgenmr_Review;User ID=evgenmr;Password=Vehvfycr2020;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MonthRewiev>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComplexFrost).HasDefaultValueSql("((0))");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.GlazedFrost).HasDefaultValueSql("((0))");

                entity.Property(e => e.Hoarfrost).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mist).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rday).HasColumnName("RDay");

                entity.Property(e => e.Rnight).HasColumnName("RNight");

                entity.Property(e => e.Snowstorm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tg).HasColumnName("TG");

                entity.Property(e => e.ThunderStorm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tmax).HasColumnName("TMax");

                entity.Property(e => e.Tmid).HasColumnName("TMid");

                entity.Property(e => e.Tmin).HasColumnName("TMin");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
