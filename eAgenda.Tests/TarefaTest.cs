using eAgenda.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace eAgenda.Tests
{
    [TestClass]
    public class TarefaTest
    {
        private Tarefa tarefa;

        public TarefaTest()
        {            
        }

        [TestMethod]
        public void DataConclusaoDeveEstarEmBranco()
        {
            tarefa = new Tarefa("Preparar aula", DateTime.Now);

            Assert.IsNull(tarefa.DataConclusao);
        }

        [TestMethod]
        public void DeveRegistrarDataConclusao()
        {
            Tarefa tarefa = new Tarefa("Preparar aula", DateTime.Now);

            tarefa.AtualizarPercentual(100);

            Assert.AreEqual(DateTime.Now.Date, tarefa.DataConclusao);
            Assert.AreEqual(100, tarefa.Percentual);
        }

        

    }
}
