
using Cadastro.Data;
using Cadastro.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace Cadastro.Controllers
{
    public class HomeController : Controller
    {
        CheckData CD = new CheckData();

        public ActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        //aqui se testa com o banco de dados lembre
        [HttpPost]
        public ActionResult Index(LoginViewModel login)
        {

            if (!ModelState.IsValid)
            {
                return View(login);
            }
            bool check = CD.CheckDatabase(login.Usuario, login.Senha);

            if (check)
            {
                return Redirect("~/Conta/Funcionarios");
            }
            else
            {
                return View(login);
                ModelState.AddModelError("", "Login invalido.");
            }

            
        }
    }
}