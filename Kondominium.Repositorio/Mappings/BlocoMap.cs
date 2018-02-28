using Kondominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kondominium.RepositoryBase.Mappings
{
    public class BlocoMap : IEntityTypeConfiguration<Bloco>
    {
        public void Configure(EntityTypeBuilder<Bloco> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
            .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Excluido)
            .HasColumnType("bit")
               .IsRequired();

            builder.HasOne(c => c.Condominio);
        }
    }
}
