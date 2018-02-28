using Kondominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kondominium.RepositoryBase.Mappings
{
    public class ApartamentoMap : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Numero)
            .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Excluido)
            .HasColumnType("bit")
               .IsRequired();

            builder.HasOne(c => c.Bloco);
        }
    }
}
