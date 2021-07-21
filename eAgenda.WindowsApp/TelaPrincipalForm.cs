using eAgenda.Controladores.TarefaModule;
using eAgenda.WindowsApp.Features.Contato;
using eAgenda.WindowsApp.Features.Tarefas;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ICadastravel operacoes;
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void menuItemTarefas_Click(object sender, EventArgs e)
        {
            ConfigurarToolBox(new ConfiguracaoTarefaToolBox());


            operacoes = new OperacoesTarefa(new ControladorTarefa());

            ConfigurarPainelRegistros();
        }

        private void menuItemContato_Click(object sender, EventArgs e)
        {
            ConfigurarToolBox(new ConfiguracaoContatoToolBox());

            operacoes = new OperacoesContato();

            ConfigurarPainelRegistros();
        }

        private void menuItemCompromissos_Click(object sender, EventArgs e)
        {
            ConfigurarToolBox(new ConfiguracaoContatoToolBox());
        }
              
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            operacoes.InserirNovoRegistro();
        }
       
        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacoes.EditarRegistro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacoes.ExcluirRegistro();
        }

        private void ConfigurarPainelRegistros()
        {
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(operacoes.ObterTabela());
        }

        private void ConfigurarToolBox(IConfiguracaoToolBox configuracao)
        {
            labelTipoCadastro.Text = configuracao.TipoCadastro;

            btnAdicionar.ToolTipText = configuracao.ToolTipAdicionar;
            btnEditar.ToolTipText = configuracao.ToolTipEditar;
            btnExcluir.ToolTipText = configuracao.ToolTipExcluir;
        }
    }
}
