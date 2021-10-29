using Cadastro.Data;
using Cadastro.Models;
using System.Web.Mvc;

namespace Cadastro.Controllers
{
    public class SenhaController : Controller
    {
        // GET: Senha
        public ActionResult RecuperarSenha()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RecuperarSenha(SenhaViewModel recuperaSenha)
        {
            SenhaUpdate SU = new SenhaUpdate();

            SU.NewSenha(recuperaSenha.Usuario, recuperaSenha.Senha);

            return Redirect("/Home/Index");
        }
    }
}