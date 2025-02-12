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
            Formatacao.Cor("\nTarefa adicionada com sucesso!\n", ConsoleColor.Green);       
        }
        public void ConcluirTarefa(int id)
        {
            Formatacao.Cor("\nTarefa concluída!\n", ConsoleColor.Green);
            var tarefa = tarefas.Find( t => t.Id == id);
            if(tarefa != null)
            {
                tarefa.Concluida = true;
            }
            foreach (var t in tarefas)
        {
           string status = t.Concluida ? "[X]" : "[ ]";
            Formatacao.Cor($"{status} ID: {t.Id} - {t.Descricao}", ConsoleColor.Yellow);
        }
        }
        public void ListarTarefa()
        {
            Console.WriteLine("Tarefas:\n");
             if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa encontrada.");
            return;
        }

            foreach (var tarefa in tarefas)
        {
           string status = tarefa.Concluida ? "[X]" : "[ ]";
            Formatacao.Cor($"{status} ID: {tarefa.Id} - {tarefa.Descricao}", ConsoleColor.Yellow);
        }
        }
        public void RemoverTarefa(int id)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefas.RemoveAll(t => t.Id == id);
                Formatacao.Cor($"\nTarefa removida com sucesso!\n", ConsoleColor.Red);
            }
            else
            {
                Formatacao.Cor("\nTarefa não encontrada!\n", ConsoleColor.Red);
            }

            ListarTarefa();
        }
        public void Sair()
        {
            Formatacao.Cor("\nSaindo...\n", ConsoleColor.Red);
        }
    }
}