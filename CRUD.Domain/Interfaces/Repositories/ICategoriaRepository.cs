using CRUD.Domain.Entities;
using System.Collections.Generic;

namespace CRUD.Domain.Interfaces.Repositories
{
    public interface ICategoriaRepository : IRepositoryBase<Categoria>
    {
        //IEnumerable<Categoria> BuscarPorNome(string nome);
        //Categoria ObterCategoria(int categoriaId);
    }
}
