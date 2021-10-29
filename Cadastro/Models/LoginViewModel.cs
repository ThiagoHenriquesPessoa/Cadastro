using System.ComponentModel.DataAnnotations;

namespace Cadastro.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Informe o usuário.")]
        [Display(Name="Usuário:")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Informe a senha.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        public string Senha { get; set; }

        [Required]
        [Display(Name = "Lembrar Me")]
        public bool Lembrarme { get; set; }
    }
}