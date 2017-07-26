using CRUD.Domain.Entities;
using System.Collections.Generic;

namespace CRUD.Domain.Interfaces.Repositories
{
    public interface IEstabelecimentoRepository : IRepositoryBase<Estabelecimento>
    {
        IEnumerable<Estabelecimento> BuscarPorNome(string nome);
    }
}
