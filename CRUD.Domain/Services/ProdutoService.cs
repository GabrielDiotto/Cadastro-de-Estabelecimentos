using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces.Repositories;
using CRUD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CRUD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
