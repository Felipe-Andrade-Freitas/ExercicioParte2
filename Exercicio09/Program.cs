using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            
            if(nome == "Felipe")
            {
                Console.WriteLine("Nome Correto");
            }
            else if(nome == "felipe")
            {
                Console.WriteLine("Nome Correto");
            }
            else
            {
                Console.WriteLine("Nome Incorreto");
            }
            Console.Read();
        }
    }
}