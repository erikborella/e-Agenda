using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Dominio.ContatoModule
{
    public class AgrupadorContato
    {
        public List<GrupoContato> Agrupar(List<Contato> contatos, Func<Contato, string> campo)
        {
            if (contatos == null || contatos.Count == 0)
                return null;

            List<GrupoContato> grupoContatos = new List<GrupoContato>();

            var agrupamentos = contatos.GroupBy(campo);

            foreach (var contatoAgrupado in agrupamentos)
            {
                GrupoContato gp = new GrupoContato(contatoAgrupado.Key);

                foreach (var contato in contatoAgrupado)
                {
                    gp.AdicionarContato(contato);
                }

                grupoContatos.Add(gp);
            }

            return grupoContatos;
        }

        #region agrupamento utilizando Dictionary
        //public List<GrupoContato> ContatosAgrupados
        //{
        //    get
        //    {
        //        var contatosAgrupados = new Dictionary<string, GrupoContato>();

        //        foreach (var c in contatos)
        //        {
        //            GrupoContato gp;

        //            if (contatosAgrupados.TryGetValue(c.Cargo, out gp) == false)
        //            {
        //                gp = new GrupoContato(c.Cargo);
        //                contatosAgrupados.Add(c.Cargo, gp);
        //            }

        //            gp.AdicionarContato(c);
        //        }

        //        return contatosAgrupados.Values.ToList();
        //    }
        //}
        #endregion
    }
}
