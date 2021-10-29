using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Cadastro.Verificacao
{
    public static class Verificacao
    {

        public static string ValidacaoString(this string texto)
        {
            return string.IsNullOrWhiteSpace(texto) ? throw new Exception("Propriedade deve esta preenchida.") : texto;
        }

        public static string SetaSenha(this string senha)
        {
            senha = senha.ValidacaoString();
            if (!Regex.IsMatch(senha, @"^(?=.*?[a-z])(?=.*?[0-9]).{8,}$"))
            {
                throw new Exception("Senha invalida");
            }
            return senha;
        }
    }
}