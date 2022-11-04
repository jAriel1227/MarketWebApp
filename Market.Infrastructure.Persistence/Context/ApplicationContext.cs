using Market.Core.Domain.Common;
using Market.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Market.Infrastructure.Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Articulos> articulos { get; set; }
        public DbSet<Categorias> categorias { get; set; }
        public DbSet<Galeria> galerias { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedTime = DateTime.Now;
                        entry.Entity.CreatedBy = "MarketUsuarioPorDefecto";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LasModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = "MarketUsuarioPorDefecto";
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API

            #region "Tablas"
            modelBuilder.Entity<Usuarios>()
                .ToTable("Usuarios");
            modelBuilder.Entity<Articulos>()
                .ToTable("Articulos");
            modelBuilder.Entity<Categorias>()
                .ToTable("Categorias");
            modelBuilder.Entity<Galeria>()
                .ToTable("Galeria_Fotos");
            #endregion

            #region "LLaves Primarias"
            modelBuilder.Entity<Usuarios>()
               .HasKey(usuario => usuario.Id);
            modelBuilder.Entity<Articulos>()
                .HasKey(articulo => articulo.Id);
            modelBuilder.Entity<Categorias>()
                .HasKey(categoria => categoria.Id);
            modelBuilder.Entity<Galeria>()
                .HasKey(galeria => galeria.IdGaleria);
            #endregion

            #region "Relaciones"
            modelBuilder.Entity<Categorias>()
                .HasMany<Articulos>(categoria => categoria.CategoriaArti)
                .WithOne(articulo => articulo.Categorias)
                .HasForeignKey(articulo => articulo.CategoriaID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Usuarios>()
                .HasMany<Articulos>(user => user.ArticulosUser)
                .WithOne(articulo => articulo.Usuario)
                .HasForeignKey(articulo => articulo.UsuarioID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Articulos>()
                .HasMany(art => art.Galeria)
                .WithOne(articulo => articulo.Articulos)
                .HasForeignKey(art => art.IdGaleria)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

          #region "Configuraciones"

            #region "Usuarios"

            modelBuilder.Entity<Usuarios>().
              Property(user => user.Username)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Usuarios>().
              Property(user => user.Contrasena)
              .IsRequired();

            modelBuilder.Entity<Usuarios>().
              Property(user => user.Nombre)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Usuarios>().
              Property(user => user.Apellido)
              .IsRequired()
              .HasMaxLength(100);

            modelBuilder.Entity<Usuarios>().
              Property(user => user.Email)
              .IsRequired();

            modelBuilder.Entity<Usuarios>().
              Property(user => user.Telephone)
              .IsRequired();
            #endregion

            #region "Articulos"

            modelBuilder.Entity<Articulos>().
                Property(advertisements => advertisements.Nombre)
                .IsRequired();

            modelBuilder.Entity<Articulos>().
               Property(advertisements => advertisements.Precio)
               .IsRequired();

            #endregion

            #region "Categorias"
            modelBuilder.Entity<Categorias>().
              Property(category => category.Nombre)
              .IsRequired()
              .HasMaxLength(100);
            #endregion

            #endregion
        }

    }
}
