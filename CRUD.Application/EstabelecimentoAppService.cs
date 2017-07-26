using System.Collections.Generic;
using CRUD.Application.Interface;
using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces.Services;

namespace CRUD.Application
{
    public class EstabelecimentoAppService : AppServiceBase<Estabelecimento>, IEstabelecimentoAppService
    {
            private readonly IEstabelecimentoService _estabelecimentoService;

            public EstabelecimentoAppService(IEstabelecimentoService estabelecimentoService)
                : base(estabelecimentoService)
            {
                _estabelecimentoService = estabelecimentoService;
            }

            public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
            {
                return _estabelecimentoService.BuscarPorNome(nome);
            }
    }
}
