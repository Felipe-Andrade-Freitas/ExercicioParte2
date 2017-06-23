using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int soma, resto, quociente;

            Console.Write("Digite um valor inteiro para x. ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor inteiro para y. ");
            y = int.Parse(Console.ReadLine());

            soma = x + y;

            if(y == 0)
            {
                Console.WriteLine("Nao ha divisao por zero.");
            }
            else
            {
                quociente = x / y;
                resto = x % y;
                Console.WriteLine("O quociente e = " + quociente + " e o resto e = " + resto);
            }
            Console.WriteLine("Soma = " + soma);
            Console.ReadLine();
        }
    }
}