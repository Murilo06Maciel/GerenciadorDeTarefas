using System.ComponentModel.Design;
using GerenciarTarefas;
using Layout;


int opcao;
Gerenciador gerenciador = new Gerenciador();
inicio:
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
                    Console.WriteLine("Digite a descrição da tarefa:");
                    string descricao = Console.ReadLine();
                    gerenciador.AdicionarTarefa(descricao);
                    goto inicio;
                case 2:
                    gerenciador.ListarTarefa();
                    break;
                case 3:
                Console.WriteLine("Digite o ID da tarefa a ser concluída:");
                int idTarefa = int.Parse(Console.ReadLine());
                    gerenciador.ConcluirTarefa(idTarefa);
                    break;
                case 4:
                    gerenciador.RemoverTarefa();
                    break;
                case 0:
                    gerenciador.Sair();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }