using System.ComponentModel.Design;
using GerenciarTarefas;
using Layout;


int opcao; bool escolha;
Gerenciador gerenciador = new Gerenciador();
inicio:
            gerenciador.ListarTarefa();
            Formatacao.ImprimirCabeçalho();
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
                Console.Clear();
                    Console.Write("Digite a descrição da tarefa: ");
                    string descricao = Console.ReadLine();
                    Console.Clear();
                    gerenciador.AdicionarTarefa(descricao);
                    goto inicio;
                case 2:
                Console.Clear();
                    gerenciador.ListarTarefa();
                    Console.WriteLine("\n\n1) Voltar:");
                    escolha = Console.ReadLine() == "1";
                    if(escolha)
                    {
                        Console.Clear();
                        goto inicio;
                    }
                    break;
                case 3:
                    Console.Clear();
                    gerenciador.ListarTarefa();
                    Console.WriteLine("\nDigite o ID da tarefa a ser concluída:");
                    int idTarefa = int.Parse(Console.ReadLine());
                    Console.Clear();
                    gerenciador.ConcluirTarefa(idTarefa);
                    goto inicio;
                case 4:
                    Console.Clear();
                    gerenciador.ListarTarefa();
                    Console.WriteLine("\nDigite o ID da tarefa a ser removida:");
                    int idRemover = int.Parse(Console.ReadLine());
                    Console.Clear();
                    gerenciador.RemoverTarefa(idRemover);
                    goto inicio;
                case 0:
                Console.Clear();
                    gerenciador.Sair();

                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }