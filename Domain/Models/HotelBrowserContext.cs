using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HotelBrowser.Domain.Models
{
    public partial class HotelBrowserContext : DbContext
    {
        public HotelBrowserContext()
        {
        }

        public HotelBrowserContext(DbContextOptions<HotelBrowserContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hotel> Hotel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=PTLW10JROVIRALT\\SQLEXPRESS;Initial Catalog=HotelBrowser;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .IsFixedLength();

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasColumnName("shortDescription")
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasMaxLength(250)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
