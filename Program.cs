using GerenciarTarefas;
using Layout;

Formatacao.ImprimirCabeçalho();
int opcao;

            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Concluir Tarefa");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Gerenciador.AdicionarTarefa();
                    break;
                case 2:
                    Gerenciador.ListarTarefa();
                    break;
                case 3:
                    Gerenciador.ConcluirTarefa();
                    break;
                case 4:
                    Gerenciador.RemoverTarefa();
                    break;
                case 0:
                    Gerenciador.Sair();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }