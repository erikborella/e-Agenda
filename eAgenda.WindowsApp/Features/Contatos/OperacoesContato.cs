using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Contato
{
    public class OperacoesContato : ICadastravel
    {
        public void InserirNovoRegistro()
        {
            TelaContatoForm tela = new TelaContatoForm();

            tela.ShowDialog();
        }

        public void EditarRegistro()
        {
            TelaContatoForm tela = new TelaContatoForm();

            tela.ShowDialog();
        }

        public void ExcluirRegistro()
        {
            System.Windows.Forms.MessageBox.Show("Tem ceerteza que deseja remover um contato");
        }        

        public UserControl ObterTabela()
        {
            return new TabelaContatoControl();
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
