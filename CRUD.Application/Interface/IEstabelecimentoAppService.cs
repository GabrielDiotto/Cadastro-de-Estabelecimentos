using System.Collections.Generic;
using CRUD.Domain.Entities;

namespace CRUD.Application.Interface
{
    public interface IEstabelecimentoAppService : IAppServiceBase<Estabelecimento>
    {
        IEnumerable<Estabelecimento> BuscarPorNome(string nome);
    }
}
