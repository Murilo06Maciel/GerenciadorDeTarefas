using Layout;

namespace Tarefas
{
    class Tarefas
    {
        public int ID { get; private set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        public Tarefas()
        {
            ID = id;
            Descricao = descricao;
            Concluida = false;
        }

        public static void ExibirTarefa()
        {
            Formatacao.Cor($"\[{(Concluida ? "X" : " ")}] ID: (id) - {Descricao}", ConsoleColor.Yellow);
        }
    }
}