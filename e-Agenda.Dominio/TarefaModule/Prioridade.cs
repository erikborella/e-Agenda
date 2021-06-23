﻿using DescriptionLibrary;

namespace eAgenda.Dominio
{
    public class Prioridade
    {
        private PrioridadeEnum prioridade;       

        public Prioridade(PrioridadeEnum prioridade)
        {
            this.prioridade = prioridade;
        }

        public int Chave
        {
            get
            {
                return (int)prioridade;
            }
        }

        public override string ToString()
        {
            return prioridade.Description();
        }

    }
}