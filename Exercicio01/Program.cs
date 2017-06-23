using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sucessor;

            Console.Write("Digite o numero: ");
            n = int.Parse(Console.ReadLine());

            sucessor = n + 1;

            Console.WriteLine("O sucessor do numero " + n + " e: " + sucessor);
            Console.Read();
        }
    }
}