using eAgenda.Dominio.ContatoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace eAgenda.Tests.ContatoModule
{
    [TestClass]
    public class ControladorContatoTest
    {
        [TestMethod]
        public void MyTestMethod()
        {
            List<Contato> contatos = new List<Contato>
            {
                new Contato("Victor Henrique", "arkhandyr@gmail.com", "+5549991368617", "NDD", "Estagiario"),
                new Contato("Joao Xavier", "joaoxavier@gmail.com", "+5549981372952", "NDD", "Estagiario"),
                new Contato("Vinicius Jordao", "vinijordao@gmail.com", "+5549998132718", "NDD", "Estagiario"),
                new Contato("Valmir Tortelli", "tortelli@gmail.com", "+5549998132816", "NDD", "Diretor"),
                new Contato("Jackson Cenci", "jacksondopandeiro@gmail.com", "+5549991382841", "NDD", "Diretor"),
                new Contato("Hugo", "hugo@gmail.com", "+5549991391752", "NDD", "Diretor")
            };

            var contatosAgrupados = new AgrupadorContato().Agrupar(contatos, x => x.Cargo);

            Assert.AreEqual(2, contatosAgrupados.Count);
            Assert.AreEqual(3, contatosAgrupados[0].Contatos.Count);
            Assert.AreEqual(3, contatosAgrupados[1].Contatos.Count);
        }
    }
}
