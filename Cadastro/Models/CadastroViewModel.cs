using System.ComponentModel.DataAnnotations;

namespace Cadastro.Models
{
    public class CadastroViewModel
    {
        [Display(Name="Usuário:")]
        public string Usuario { get; set; }

        [Display(Name = "Senha:")]
        public string Senha { get; set; }
    }
}