using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, soma;

            Console.Write("Digite o primeiro numero: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro numero: ");
            z = int.Parse(Console.ReadLine());

            soma = y + z;

            if(x > (y + z))
            {
                Console.WriteLine(x + " e maior que " + y + " + " + z + " que e " + soma);
            }
            else
            {
                Console.WriteLine(x + " nao e maior que " + y + " + " + z + " que e " + soma);
            }
            Console.Read();
        }
    }
}