using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--Peso Ideal--");
            Console.ResetColor();
            Console.WriteLine();

            double altura;
            bool sexo;
            

            Console.WriteLine("Insira os seguintes dados para descobrir o seu peso ideal!");
            Console.WriteLine();

            Console.Write("Insira sua altura em metros................................:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            altura = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            
            double idealMasc, idealFem;
            idealMasc = altura * 72.7 - 58.0;
            idealFem = altura * 62.1 - 44.7;

            Console.Write("Insira seu sexo, [M] para masculino ou [F] para feminino..: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            sexo = Console.ReadLine().ToUpper() =="M";
            Console.ResetColor();

            if (sexo)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Seu peso ideal é..: {idealMasc:N2}kg");
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Seu peso ideal é..: {idealFem:N2}kg");
                Console.WriteLine();
                Console.ResetColor();
            }
         }
    }
}
