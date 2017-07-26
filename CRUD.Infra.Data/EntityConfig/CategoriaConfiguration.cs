using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infra.Data.EntityConfig
{
    public class CategoriaConfiguration : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
            HasKey(c => c.CategoriaId);
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
