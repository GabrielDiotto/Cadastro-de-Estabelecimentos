using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CRUD.Infra.Data.Repositories
{
    public class EstabelecimentoRepository : RepositoryBase<Estabelecimento>, IEstabelecimentoRepository
    {
        public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        {
            return Db.Estabelecimento.Where(p => p.Nome == nome);
        }
    }
}
