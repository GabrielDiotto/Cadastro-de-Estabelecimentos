using CRUD.Domain.Entities;
using System.Collections.Generic;

namespace CRUD.Domain.Interfaces.Services
{
    public interface ICategoriaService : IServiceBase<Categoria>
    {
        IEnumerable<Categoria> ObterCategoriasEspeciais(IEnumerable<Categoria> categorias);
        Categoria ObterCategoria(int categoriaId);
    }
}
