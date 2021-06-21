using System;

namespace eAgenda.Dominio
{
    public class Tarefa : EntidadeBase
    {
        private int percentual;

        public string Titulo;
        public DateTime DataCriacao;
        public DateTime? DataConclusao;
        public int Prioridade;
        public Tarefa(string titulo)
        {
            Titulo = titulo;
            DataCriacao = DateTime.Now.Date;
        }

        public Tarefa(string titulo, int prioridade) :this(titulo)
        {

        }

        public int Percentual 
        {
            get
            {
                return percentual;
            }            
        }

        public void AtualizarPercentual(int p)
        {
            percentual = p;

            if (percentual == 100)
            {
                DataConclusao = DateTime.Now.Date;
            }
        }

        
    }
}