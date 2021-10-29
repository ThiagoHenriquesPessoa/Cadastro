using System.ComponentModel.DataAnnotations;

namespace Cadastro.Models
{
    public class SenhaViewModel
    {
        [Display(Name = "Usuário")]
        public string Usuario { get; set; }

        [Display(Name = "Nova Senha")]
        public string Senha { get; set; }
    }
}