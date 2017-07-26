using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CRUD.Infra.Data.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
        public IEnumerable<Categoria> BuscarPorNome(string nome)
        {
            return Db.Categorias.Where(p => p.Nome == nome);
        }
        //public Categoria ObterCategoria(int categoriaId) {
        //    return Db.Categorias.FirstOrDefault(c => c.CategoriaId == categoriaId);
        //}
    }
}
