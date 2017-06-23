using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1, b2, b3, b4;
            int media;

            Console.Write("Digite a nota do primeiro bimestre: ");
            b1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do segundo bimestre : ");
            b2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do terceiro bimestre: ");
            b3 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do quarto bimestre :");
            b4 = int.Parse(Console.ReadLine());

            media = (b1 + b2 + b3 + b4) / 4;
            Console.WriteLine("A media do aluno e: " + media);

            if(media >= 6)
            {
                Console.Write("Ele esta Aprovado!");
            }
            else
            {
                Console.Write("Ele esta Reprovado!");
            }
            Console.Read();

        }
    }
}