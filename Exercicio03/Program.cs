using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAnos, numCigarrosPorDia, precoCigarro, gasto;

            Console.Write("Digite o numero de cigarros que fuma por dia: ");
            numCigarrosPorDia = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de anos que fuma: ");
            numAnos = int.Parse(Console.ReadLine());
            Console.Write("Digite o preco do cigarro: ");
            precoCigarro = int.Parse(Console.ReadLine());

            if (precoCigarro > 0)
            {
                gasto = (365 * numAnos * numCigarrosPorDia / 20) * precoCigarro;
                Console.WriteLine("Voce gastou R$" + gasto + ",00 com cigarros.");
            }
            else
            {
                Console.WriteLine("Voce digitou o preco do cigarro errado.");
            }
            Console.Read();
        }
    }
}