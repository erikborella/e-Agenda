using eAgenda.Dominio.Shared;
using System;

namespace eAgenda.Dominio.TarefaModule
{
    public class Tarefa : EntidadeBase
    {
        public string Titulo;
        public DateTime DataCriacao;
        public DateTime? DataConclusao;
        public int Percentual;

        public Tarefa(string titulo, DateTime dataCriacao, PrioridadeEnum prioridade)
        {
            Titulo = titulo;
            Prioridade = new Prioridade(prioridade);
            DataCriacao = dataCriacao;
        }

        public Prioridade Prioridade { get; set; }

        public void AtualizarPercentual(int p)
        {
            Percentual = p;

            if (Percentual == 100)
            {
                DataConclusao = DateTime.Now.Date;
            }
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Titulo))
                resultadoValidacao = "O campo título é obrigatório";

            if (DataCriacao == DateTime.MinValue)
                resultadoValidacao += "O campo título é obrigatório";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

    }
}