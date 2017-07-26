using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Entities
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public bool Especial { get; set; }

        public void TransformaCategoriaEmEspecial(Categoria categoria)
        {
            Especial = true;
        }
    }
}
