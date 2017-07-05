using CRUD.Domain.Entities;
using CRUD.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace CRUD.Infra.Data.Contexto
{
    public class CRUDContext : DbContext
    {
        public CRUDContext()
            : base("CRUD")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remover convenções
            //Não deixar no plural as tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Não deletar em cascata relações de um para muitos
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //Não deletar em cascata relações de N para N
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Configurando campo id
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
