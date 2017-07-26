using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.Interface
{
    public interface ICategoriaAppService : IAppServiceBase<Categoria>
    {
        IEnumerable<Categoria> ObterCategoriasEspeciais();
        Categoria ObterCategoria(int categoriaId);
    }
}
