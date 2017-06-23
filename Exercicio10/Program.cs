using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Digite o primeiro numero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            b = int.Parse(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine(a + " e maior que " + b);
            }
            else if(a == b)
            {
                Console.WriteLine(a + " e igual a " + b);
            }
            else
            {
                Console.WriteLine(a + " e menor que " + b);
            }
            Console.Read();
        }
    }
}