using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;  
            Console.WriteLine("Digite a nota da primeira avaliação (P1):");
            p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda avaliação (P2):");
            p2 = double.Parse(Console.ReadLine());

            double media = (p1 + 2 * p2) / 3;

            Console.WriteLine($"Média: {media}");

            if (media >= 5)
                Console.WriteLine("Aprovado");
            else
                Console.WriteLine("Reprovado");

        }
    }
}
