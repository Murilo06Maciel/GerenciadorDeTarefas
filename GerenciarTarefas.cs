using Layout;
using Tarefas;

namespace GerenciarTarefas
{
    class Gerenciador
    {
        private List<Tarefa> tarefas = new List<Tarefa>();
        private int ProximoId = 1;

        public void AdicionarTarefa(string descricao)
        {
            var novaTarefa = new Tarefa(ProximoId++, descricao);
            tarefas.Add(novaTarefa);
             Console.WriteLine($"[ ] ID: {novaTarefa.Id} - {novaTarefa.Descricao}");
            ProximoId++;
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
        public void MostrarTarefas()
        {
            Console.WriteLine("Tarefas:\n");
        }
        public void ListarTarefa()
        {
             if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa encontrada.");
            return;
        }

            foreach (var tarefa in tarefas)
        {
           string status = tarefa.Concluida ? "[X]" : "[ ]";
            Console.WriteLine($"{status} ID: {tarefa.Id} - {tarefa.Descricao}", ConsoleColor.Yellow);
        }
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