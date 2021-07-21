using eAgenda.Controladores.TarefaModule;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Tarefas
{
    public class OperacoesTarefa : ICadastravel
    {
        private readonly ControladorTarefa controlador = null;
        public OperacoesTarefa(ControladorTarefa ctrlTarefa)
        {
            controlador = ctrlTarefa;
        }

        public void InserirNovoRegistro()
        {
            TelaTarefaForm tela = new TelaTarefaForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Tarefa);
            }
        }

        public void EditarRegistro()
        {
            TelaTarefaForm tela = new TelaTarefaForm();

            tela.ShowDialog();
        }

        public void ExcluirRegistro()
        {
            System.Windows.Forms.MessageBox.Show("Tem ceerteza que deseja remover uma tarefa");
        }        

        public UserControl ObterTabela()
        {
            return new TabelaTarefaControl();
        }
    }
}
