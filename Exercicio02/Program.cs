using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Os 4 bimestres tem como total 100pts
            int b1, b2, b3;
            int notaFaltante;

            Console.Write("Digite a nota do primeiro bimestre: ");
            b1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do segundo bimestre: ");
            b2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do terceiro bimestre: ");
            b3 = int.Parse(Console.ReadLine());

            //Para calcular somamos as notas e subitraimos o que a pessoa deveria ter tirado
            notaFaltante = (45 - (b1 + b2 + b3));
            Console.WriteLine("Faltam " + notaFaltante + " pontos para voce ser aprovado.");
            Console.Read();
            
        }
    }
}