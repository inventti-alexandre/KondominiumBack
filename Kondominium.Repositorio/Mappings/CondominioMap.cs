using Kondominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kondominium.RepositoryBase.Mappings
{
    public class CondominioMap : IEntityTypeConfiguration<Condominio>
    {
        public void Configure(EntityTypeBuilder<Condominio> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CEP)
            .HasColumnType("varchar(8)")
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(c => c.Nome)
           .HasColumnType("varchar(100)")
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(c => c.Rua)
           .HasColumnType("varchar(100)")
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(c => c.Complemento)
          .HasColumnType("varchar(100)")
              .HasMaxLength(100)
              .IsRequired();

           

            builder.Property(c => c.Cidade)
           .HasColumnType("int")
               .IsRequired();

            builder.Property(c => c.Estado)
           .HasColumnType("int")
               .IsRequired();

            builder.Property(c => c.Excluido)
            .HasColumnType("bit")
               .IsRequired();
        }
    }
}
