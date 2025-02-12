namespace Layout
{
   class Formatacao
   {
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();

            // Console.ForegroundColor = ConsoleColor.Green;
            // Console.ForegroundColor = ConsoleColor.White;
            // Console.ForegroundColor = ConsoleColor.Yellow;
            // Console.ForegroundColor = ConsoleColor.Red;
        }
        public static void ImprimirCabeçalho()
        {
            Console.WriteLine("\t\t\t======================");
            Console.WriteLine("\t\t\tGERENCIADOR DE TAREFAS");
            Console.WriteLine("\t\t\t======================\n");
        }

   } 
}