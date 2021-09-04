using System;

namespace exercicios_etec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write(" Digite seu primeiro nome:");

            string primeironome= Console.ReadLine();
            
            Console.ResetColor();
            Console.WriteLine();

            string sobrenome= Console.ReadLine();

            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine();

            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.Write("Nome completo: ");
            Console.WriteLine($"{primeironome} {sobrenome}");

            Console.ForegroundColor= ConsoleColor.DarkMagenta;
            Console.Write("Nome de catálogo: ");
            Console.Write(sobrenome.ToUpper());
            Console.Write(" , ");
            Console.WriteLine(primeironome);

            Console.ResetColor();
            Console.ReadKey();







        }
    }
}

