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
            var tarefa = tarefas.Find( t => t.Id == id);
            if(tarefa != null)
            {
                tarefa.Concluida = true;
            }
            Formatacao.Cor("\nTarefa concluída!\n", ConsoleColor.Green);
        }
        public void ListarTarefa()
        {
            Console.WriteLine("Tarefas:\n");
            foreach (var tarefa in tarefas)
        {
           string status = tarefa.Concluida ? "[X]" : "[ ]";
            Formatacao.Cor($"{status} ID: {tarefa.Id} - {tarefa.Descricao}", ConsoleColor.Yellow);
        }
        }
        public void RemoverTarefa(int id)
        {
            var tarefa = tarefas.Find(Rtarefa => Rtarefa.Id == id);
            if (tarefa != null)
            {
                tarefas.RemoveAll(Rtarefa => Rtarefa.Id == id);
                Formatacao.Cor($"\nTarefa removida com sucesso!\n", ConsoleColor.Red);
            }
        }
        public void Sair()
        {
            Formatacao.Cor("\nSaindo...\n", ConsoleColor.Red);
        }
    }
}