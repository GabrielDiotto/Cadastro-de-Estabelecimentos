using System.Collections.Generic;
using CRUD.Application.Interface;
using CRUD.Domain.Entities;
using CRUD.Domain.Interfaces.Services;

namespace CRUD.Application
{
    public class CategoriaAppService : AppServiceBase<Categoria>, ICategoriaAppService
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaAppService(ICategoriaService categoriaService)
            : base(categoriaService)
        {
            _categoriaService = categoriaService;
        }

        public IEnumerable<Categoria> ObterCategoriasEspeciais()
        {
            return _categoriaService.ObterCategoriasEspeciais(_categoriaService.GetAll());
        }

        public Categoria ObterCategoria(int categoriaId) {
            return _categoriaService.ObterCategoria(categoriaId);
        }
    }
}
