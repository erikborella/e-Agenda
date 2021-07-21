using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Tarefas
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;


        public TelaTarefaForm()
        {
            InitializeComponent();

            CarregarPrioridades();
        }

        private void CarregarPrioridades()
        {
            cmbPrioridade.DataSource = Enum.GetValues(typeof(PrioridadeEnum));
        }

        public Tarefa Tarefa
        {
            get { return tarefa; }

            set { tarefa = value; }
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            PrioridadeEnum prioridade = (PrioridadeEnum)cmbPrioridade.SelectedValue;

            DateTime dataCriacao, dataConclusao;

            if (string.IsNullOrEmpty(txtId.Text)) //inserindo
                dataCriacao = DateTime.Now;
            else
                dataCriacao = Convert.ToDateTime(dateDataCriacao.Text);

            if (txtPercentual.Value == 100 && string.IsNullOrEmpty(dateDataConclusao.Text))
                dataConclusao = DateTime.Now;

            else if (string.IsNullOrEmpty(dateDataConclusao.Text) == false)
                dataConclusao = Convert.ToDateTime(dateDataConclusao.Text);

            else
                dataConclusao = DateTime.MinValue;

            tarefa = new Tarefa(titulo, dataCriacao, prioridade);

            tarefa.AtualizarPercentual((int)txtPercentual.Value, dataConclusao);
          
        }
    }
}
