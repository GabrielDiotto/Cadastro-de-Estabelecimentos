using System.Collections.Generic;
using CRUD.Application.Interface;
using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces.Services;

namespace CRUD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
            private readonly IProdutoService _produtoService;

            public ProdutoAppService(IProdutoService produtoService)
                : base(produtoService)
            {
                _produtoService = produtoService;
            }

            public IEnumerable<Produto> BuscarPorNome(string nome)
            {
                return _produtoService.BuscarPorNome(nome);
            }
    }
}
