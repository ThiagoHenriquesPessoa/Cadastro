using Cadastro.Data;
using Cadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xceed.Wpf.Toolkit;

namespace Cadastro.Controllers
{
    public class CadastroController : Controller
    {        
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CadastroViewModel cadastro)
        {

            DataInsert DI = new DataInsert();

            DI.InsertToDatabase(cadastro.Usuario, cadastro.Senha);

            return Redirect("/Home/Index");
        }
    }
}