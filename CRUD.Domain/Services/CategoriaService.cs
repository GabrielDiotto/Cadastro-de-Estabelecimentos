using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces.Repositories;
using CRUD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace CRUD.Domain.Services
{
    public class CategoriaService : ServiceBase<Categoria>, ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
            : base(categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IEnumerable<Categoria> ObterCategoriasEspeciais(IEnumerable<Categoria> categorias)
        {
            return categorias.Where(c => c.Especial);
        }

        public Categoria ObterCategoria(int categoriaId) {
            return _categoriaRepository.GetById(categoriaId);
        }
    }
}
