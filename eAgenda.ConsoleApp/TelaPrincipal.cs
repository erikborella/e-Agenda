using System;

namespace eAgenda.ConsoleApp
{
    public class TelaPrincipal : TelaBase
    {
        //private readonly ControladorTarefa controladorTarefa;              
        //private readonly TelaTarefa telaTarefa;

        //private readonly ControladorContato controladorContato;
        //private readonly TelaContato telaContato;


        public TelaPrincipal() : base("Tela Principal")
        {
            //controladorTarefa = new ControladorTarefa();          
            //telaTarefa = new TelaTarefa(controladorTarefa);            

            PopularAplicacao();
        }

        private void PopularAplicacao()
        {
            //Tarefa a1 = new Tarefa("Helena", "Alexandre", "321", "Colégio");
            //controladorTarefa.InserirNovo(a1);

            //Caixa caixa = new Caixa("Azul", "xua-654");
            //controladorCaixa.InserirNovo(caixa);

            //Revista r = new Revista("Superman", "Trilogia", 10, caixa);
            //controladorRevista.InserirNovo(r);
        }        

        public TelaBase ObterTela()
        {
            ConfigurarTela("Escolha uma opção: ");

            TelaBase telaSelecionada = null;
            string opcao;
            do
            {
                Console.WriteLine("Digite 1 para o Cadastro de Tarefas");
                Console.WriteLine("Digite 2 para o Cadastro de Contatos");

                Console.WriteLine("Digite S para Sair");
                Console.WriteLine();
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                { /*telaSelecionada = telaTarefa; */}

                if (opcao == "2")
                { /*telaSelecionada = telaCaixa; */}


                else if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    telaSelecionada = null;

            } while (OpcaoInvalida(opcao));

            return telaSelecionada;
        }

        private bool OpcaoInvalida(string opcao)
        {
            if (opcao != "1" && opcao != "2" /*&& opcao != "3" && opcao != "4" && opcao != "S"*/ && opcao != "s")
            {
                ApresentarMensagem("Opção inválida", TipoMensagem.Erro);
                return true;
            }
            else
                return false;
        }
    }

}
