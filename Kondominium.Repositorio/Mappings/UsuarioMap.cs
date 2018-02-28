using Kondominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kondominium.RepositoryBase.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Login)
            .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Senha)
                .HasColumnType("varchar(50)")
                    .HasMaxLength(50)
                    .IsRequired();

            builder.Property(c => c.Email)
            .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Telefone1)
            .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .IsRequired();
            builder.Property(c => c.Telefone2)
            .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.Ativo)
            .HasColumnType("bit")
               .IsRequired();

            builder.Property(c => c.Sindico)
           .HasColumnType("bit")
              .IsRequired();

            builder.Property(c => c.ViceSindico)
           .HasColumnType("bit")
              .IsRequired();

            builder.Property(c => c.Proprietario)
           .HasColumnType("bit")
              .IsRequired();

            builder.Property(c => c.RepresentanteOficial)
          .HasColumnType("bit")
             .IsRequired();

            builder.Property(c => c.Morador)
          .HasColumnType("bit")
             .IsRequired();

            builder.Property(c => c.Funcionario)
         .HasColumnType("bit")
            .IsRequired();

            builder.Property(c => c.Admininstrador)
         .HasColumnType("bit")
            .IsRequired();

        }
    }
}
