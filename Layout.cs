namespace Layout
{
   class Formatacao
   {
        public static void CorVerde()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void CorBranco()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void CorAmarelo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void CorVermelho()
        {
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