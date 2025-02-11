using Layout;
using Tarefas;

namespace GerenciarTarefas
{
    class Gerenciador
    {
        private List<Tarefa> tarefas = new List<Tarefa>();
        private int contadorId = 1;
        public void AdicionarTarefa(string descricao)
        {
            var novaTarefa = new Tarefa(contadorId++, descricao);
            tarefas.Add(novaTarefa);
            Console.WriteLine("\tTarefa adicionada com sucesso!", ConsoleColor.Green);        
        }
        public void ConcluirTarefa(int id)
        {
            var tarefa = tarefas.Find( t => t.Id == id);
            if(tarefa != null)
            {
                tarefa.Concluida = true;
                Console.Clear();
                ListarTarefa();
            }
        }
        public void ListarTarefa()
        {
            Console.WriteLine();
        }
        public void RemoverTarefa()
        {
            Console.WriteLine();
        }
        public void Sair()
        {
            Console.WriteLine();
        }
    }
}