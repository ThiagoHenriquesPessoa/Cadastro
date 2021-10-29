using Cadastro.Data;
using Cadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Cadastro.Controllers
{
    public class ContaController : Controller
    {
        
        public ActionResult Funcionarios()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Funcionarios(FuncionarioViewModel funcionario)
        {
            DataInsertFuncionario DIF = new DataInsertFuncionario();
            DataInsertCaegoDB DIC = new DataInsertCaegoDB();

            Random random = new Random();
            int id = random.Next(50000, 100000);

            TimeSpan tempo = DateTime.Now - funcionario.DataDeNascimento;
            int idade = tempo.Days / 30/ 12;

            DIF.InsertFuncionario(id, funcionario.Nome, funcionario.Telefone, funcionario.DataDeNascimento, idade, funcionario.Sexo, funcionario.Ativo, funcionario.Cargo);
            DIC.InsertCargoDB(id, funcionario.Cargo, funcionario.Ativo);

            return Redirect("/Home/Index");
        }
    }
}