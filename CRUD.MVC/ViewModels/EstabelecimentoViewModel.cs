using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.MVC.ViewModels
{
    public class EstabelecimentoViewModel
    {
        [Key]
        public int EstabelecimentoId { get; set; }

        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Fantasia")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Preencha o campo CNPJ")]
        [StringLength(18, ErrorMessage = "Objeto CNPJ deve conter 18 caracteres.")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Preencha o campo Email")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um email válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public string Telefone { get; set; }

        public int CategoriaId { get; set; }

        public virtual CategoriaViewModel Categoria { get; set; }

        [DisplayName("Status")]
        public bool Status { get; set; }

        public IEnumerable<ValidationResult> Result { get; set; }
    }
}