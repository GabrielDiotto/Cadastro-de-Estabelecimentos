using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.MVC.ViewModels
{
    public class CategoriaViewModel
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }
        public bool Especial { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}