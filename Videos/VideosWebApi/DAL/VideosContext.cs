using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VideosWebApi.Domain.Entity;

namespace VideosWebApi.DAL
{
    public partial class VideosContext : DbContext
    {
     

        public VideosContext(DbContextOptions<VideosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<Responsavel> Responsavels { get; set; } = null!;
        public virtual DbSet<Video> Videos { get; set; } = null!;
        public virtual DbSet<VideoCategorium> VideoCategoria { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.Property(e => e.IdCategoria).ValueGeneratedNever();

                entity.Property(e => e.NomeCategoria)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Responsavel>(entity =>
            {
                entity.HasKey(e => e.IdResponsavel);

                entity.ToTable("Responsavel");

                entity.Property(e => e.IdResponsavel).ValueGeneratedNever();

                entity.Property(e => e.NomeResponsavel)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.HasKey(e => e.IdVideo);

                entity.ToTable("Video");

                entity.Property(e => e.IdVideo).ValueGeneratedNever();

                entity.Property(e => e.Url)
                    .HasMaxLength(2083)
                    .HasColumnName("URL");

                entity.HasOne(d => d.IdResponsavelNavigation)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.IdResponsavel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Video_Responsavel");
            });

            modelBuilder.Entity<VideoCategorium>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoCategoria_Categoria");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdVideo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoCategoria_Video");
            });

        }

    }
}
