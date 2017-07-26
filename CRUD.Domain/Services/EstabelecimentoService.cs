using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces.Repositories;
using CRUD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CRUD.Domain.Services
{
    public class EstabelecimentoService : ServiceBase<Estabelecimento>, IEstabelecimentoService
    {
        private readonly IEstabelecimentoRepository _estabelecimentoRepository;

        public EstabelecimentoService(IEstabelecimentoRepository estabelecimentoRepository)
            : base(estabelecimentoRepository)
        {
            _estabelecimentoRepository = estabelecimentoRepository;
        }

        public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        {
            return _estabelecimentoRepository.BuscarPorNome(nome);
        }
    }
}
