using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Mvc_task1.Models
{
    public partial class mvc_task1Context : DbContext
    {
        public mvc_task1Context()
        {
        }

        public mvc_task1Context(DbContextOptions<mvc_task1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Automobil> Automobil { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRES;Database=mvc_task1;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automobil>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cena).HasColumnName("cena");

                entity.Property(e => e.Foto)
                    .HasColumnName("foto");
                    
                entity.Property(e => e.Godiste)
                    .HasColumnName("godiste")
                    .HasColumnType("int");

                entity.Property(e => e.Gorivo)
                    .IsRequired()
                    .HasColumnName("gorivo")
                    .HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.Karoserija)
                    .IsRequired()
                    .HasColumnName("karoserija")
                    .HasMaxLength(50);

                entity.Property(e => e.Kontakt)
                    .IsRequired()
                    .HasColumnName("kontakt")
                    .HasMaxLength(50);

                entity.Property(e => e.Marka)
                    .IsRequired()
                    .HasColumnName("marka")
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasMaxLength(50);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasColumnName("opis")
                    .HasMaxLength(150);

                entity.Property(e => e.Snaga).HasColumnName("snaga");

                entity.Property(e => e.ZapreminaMotora).HasColumnName("zapremina_motora");
            });
        }
    }
}
