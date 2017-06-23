using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, quociente;

            Console.Write("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            if(n2 != 0)
            {
                quociente = n1 / n2;
                Console.WriteLine("A divisao de " + n1 + " e " + n2 + " e " + quociente);
            }
            else
            {
                quociente = 0;
                Console.WriteLine("A divisao de numeros por zero e " + quociente);
            }
            Console.Read();
        }
    }
}