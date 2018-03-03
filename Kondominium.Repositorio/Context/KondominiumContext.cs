
using Kondominium.Domain.Entities;
using Kondominium.RepositoryBase.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Kondominium.RepositoryBase.Context
{
    public class KondominiumContext : DbContext
    {
        public DbSet<Condominio> Condominio { get; set; }
        public DbSet<Bloco> Bloco { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Apartamento> Apartamento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ApartamentoMap());
            modelBuilder.ApplyConfiguration(new CondominioMap());
            modelBuilder.ApplyConfiguration(new BlocoMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
