using eAgenda.Dominio.Shared;
using System.Text.RegularExpressions;

namespace eAgenda.Dominio.ContatoModule
{
    public class Contato : EntidadeBase
    {
        public Contato(string nome, string email, string telefone, string empresa, string cargo)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }

        public string Nome { get; }
        public string Email { get; }
        public string Telefone { get; }
        public string Cargo { get; }
        public string Empresa { get; }

        public override string Validar()
        {
            string resultadoValidacao = ValidarEmail();

            resultadoValidacao += ValidarNumeroTelefone();

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

        private string ValidarNumeroTelefone()
        {
            return Telefone.Length > 7 ? "" : "Telefone Inválido!";
        }

        private string ValidarEmail()
        {
            Regex rg = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            return rg.IsMatch(Email) ? "" : "Email Inválido!";
        }
    }
}
