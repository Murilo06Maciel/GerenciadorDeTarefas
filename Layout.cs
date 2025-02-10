namespace Layout
{
   class Formatacao
   {
        public static void Cor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public static void ImprimirCabeçalho()
        {
            Console.WriteLine("======================");
            Console.WriteLine("GERENCIADOR DE TAREFAS");
            Console.WriteLine("======================");
        }

   } 
}