using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CRUD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public IEnumerable<Cliente> BuscarPorNome(string nome)
        {
            return Db.Clientes.Where(p => p.Nome == nome);
        }
    }
}
