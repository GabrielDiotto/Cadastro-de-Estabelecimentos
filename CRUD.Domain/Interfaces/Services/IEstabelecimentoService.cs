using System.Collections.Generic;
using CRUD.Domain.Entities;
namespace CRUD.Domain.Interfaces.Services
{
    public interface IEstabelecimentoService : IServiceBase<Estabelecimento>
    {
        IEnumerable<Estabelecimento> BuscarPorNome(string nome);
    }
}
