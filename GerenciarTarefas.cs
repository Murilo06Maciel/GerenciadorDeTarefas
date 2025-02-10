using Layout;

namespace GerenciarTarefas
{
    class Gerenciar
    {
        public static void AdicionarTarefa()
        {
            Console.Clear();
            Console.WriteLine("Digite a descrição da tarefa:");
            string descriçãoTarefa = Console.ReadLine();
            Formatacao.CorVerde();
            Console.WriteLine("Tarefa adicionada com sucesso!");        
        }
        public static void ConcluirTarefa()
        {
            Console.WriteLine();
        }
        public static void ListarTarefa()
        {
            Console.WriteLine();
        }
        public static void RemoverTarefa()
        {
            Console.WriteLine();
        }
        public static void Sair()
        {
            Console.WriteLine();
        }
    }
}