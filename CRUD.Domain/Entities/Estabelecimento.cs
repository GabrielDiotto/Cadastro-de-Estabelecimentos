using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain.Entities
{
    public class Estabelecimento
    {
        public int EstabelecimentoId { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public bool Status { get; set; }
        public void VinculaCategoria(Categoria categoria) {
            if(categoria.CategoriaId!=0)
                this.Categoria = categoria;
        }
        public IEnumerable<ValidationResult> Validate()
        {
            var validationResults = new List<ValidationResult>();

            //-->Check special is true
            if (this.Categoria != null && this.Categoria.Especial)
            {
                if (String.IsNullOrEmpty(this.Telefone) || String.IsNullOrWhiteSpace(this.Telefone))
                    validationResults.Add(new ValidationResult("Categoria especial precisa de um telefone"));
            }

            return validationResults;
        }
    }
}
