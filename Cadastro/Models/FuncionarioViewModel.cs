using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cadastro.Models
{
    public class FuncionarioViewModel
    {

        public string Id { get; set; }

        [Required(ErrorMessage = "Informe o nome completo.")]
        [Display(Name = "Nome:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o número do telefona.")]
        [Display(Name = "Telefone:")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe sua data de nascimento.")]
        [Display(Name = "Data De Nascimento:")]
        public DateTime DataDeNascimento { get; set; }
                
        public int Idade { get; set; }

        [Required(ErrorMessage = "Informe o Gênero.")]
        [Display(Name = "Sexo:")]
        public string Sexo { get; set; }

        public string Ativo { get; set; }

        [Required(ErrorMessage = "Selecione o cargo.")]
        [Display(Name = "Cargo:")]
        public string Cargo { get; set; }
    }
}