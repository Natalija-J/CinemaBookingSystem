using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CinemaBookingSystem.DB
{
    public partial class CinemaDb : DbContext
    {
        public CinemaDb()
        {
        }

        public CinemaDb(DbContextOptions<CinemaDb> options)
            : base(options)
        {
        }

        public virtual DbSet<Bookings> Bookings { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<PlayingTime> PlayingTime { get; set; }
        public virtual DbSet<Price> Price { get; set; }
        public virtual DbSet<Theaters> Theaters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Stephen\\Documents\\Natalija\\Accenture .Net\\Cinema\\CinemaDB.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bookings>(entity =>
            {
                entity.Property(e => e.WatchingTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.Image).HasMaxLength(300);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.Property(e => e.Director).HasMaxLength(200);

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.MainActor)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlayingTime).HasColumnType("datetime");

                entity.Property(e => e.PriceId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TextAbout).HasMaxLength(3000);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PlayingTime>(entity =>
            {
                entity.ToTable("PlayingTIme");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price1)
                    .HasColumnName("Price")
                    .HasColumnType("decimal(4, 2)");
            });

            modelBuilder.Entity<Theaters>(entity =>
            {
                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
