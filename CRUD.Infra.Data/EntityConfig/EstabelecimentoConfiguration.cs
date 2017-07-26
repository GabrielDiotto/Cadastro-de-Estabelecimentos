using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infra.Data.EntityConfig
{
    public class EstabelecimentoConfiguration : EntityTypeConfiguration<Estabelecimento>
    {
        public EstabelecimentoConfiguration()
        {
            HasKey(p => p.EstabelecimentoId);

            Property(c => c.NomeFantasia)
                .IsRequired()
                .HasMaxLength(250);

            Property(c => c.CNPJ)
                .IsRequired();

            HasRequired(p => p.Categoria)
            .WithMany()
            .HasForeignKey(p => p.CategoriaId);
        }

    }
}
