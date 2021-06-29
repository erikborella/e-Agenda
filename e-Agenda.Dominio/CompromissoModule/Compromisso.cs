using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.Shared;
using System;

namespace eAgenda.Dominio.CompromissoModule
{
    public class Compromisso : EntidadeBase
    {
        public Compromisso(string assunto, string local, string link, DateTime data, TimeSpan horaInicio, TimeSpan horaFim, Contato contato)
        {
            Assunto = assunto;
            Local = local;
            Link = link;
            Data = data;
            HoraInicio = horaInicio;
            HoraFim = horaFim;
            Contato = contato;
        }

        public string Assunto { get; }
        public string Local { get; }
        public string Link { get; }
        public DateTime Data { get; }
        public TimeSpan HoraInicio { get; }
        public TimeSpan HoraFim { get; }
        public Contato Contato { get; }

        public override string Validar()
        {
            return "ESTA_VALIDO";
        }
    }
}
