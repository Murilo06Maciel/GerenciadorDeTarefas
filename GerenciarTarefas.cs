using Layout;

namespace GerenciarTarefas
{
    class Gerenciar
    {
        private List<Tarefa> tarefas = new List<Tarefa>();
        private int contadorId = 1;
        public static void AdicionarTarefa(string descricao)
        {
            var novaTarefa = new Tarefa(contadorId++, descricao);
            Tarefas.Add(novaTarefa);
            Console.WriteLine("\tTarefa adicionada com sucesso!", ConsoleColor.Green);        
        }
        public static void ConcluirTarefa(int id)
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