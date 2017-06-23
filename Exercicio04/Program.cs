using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, resto, quociente;

            Console.Write("Digite o valor inteiro para X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor inteiro para Y: ");
            y = int.Parse(Console.ReadLine());

            if(y == 0)
            {
                Console.WriteLine("Nao ha divisao por zero.");
            }
            else
            {
                quociente = x / y;
                resto = x % y;
                Console.WriteLine("O quociente e " + quociente + " e o resto e = " + resto);
            }
            Console.Read();
        }
    }
}