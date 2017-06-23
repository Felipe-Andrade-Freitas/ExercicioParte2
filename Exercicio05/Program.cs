using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Digite o valor inteiro de x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor inteiro de y: ");
            y = int.Parse(Console.ReadLine());

            if(x%y == 0)
            {
                Console.Write("X e multiplo de Y");
            }
            else
            {
                Console.Write("X nao e multiplo de Y");
            }
            Console.Read();
        }
    }
}