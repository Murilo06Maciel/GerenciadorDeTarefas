using GerenciarTarefas;
using Layout;

Formatacao.ImprimirCabeçalho();
int opcao;
do
        {
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
                    Gerenciar.AdicionarTarefa();
                    break;
                case 2:
                    Gerenciar.ListarTarefa();
                    break;
                case 3:
                    Gerenciar.ConcluirTarefa();
                    break;
                case 4:
                    Gerenciar.RemoverTarefa();
                    break;
                case 0:
                    Gerenciar.Sair();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao > 4);