using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace api_video_juegos.Models
{
    public partial class video_juegos_bd : DbContext
    {
        public video_juegos_bd()
            : base("name=video_juegos_bd")
        {
        }

        public virtual DbSet<consola> Consolas { get; set; }
        public virtual DbSet<juego> Juegos { get; set; }
        public virtual DbSet<mando> Gamepads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<consola>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<consola>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<juego>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<juego>()
                .Property(e => e.plataforma)
                .IsUnicode(false);

            modelBuilder.Entity<mando>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<mando>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<mando>()
                .Property(e => e.compatibilidad)
                .IsUnicode(false);
        }
    }
}
