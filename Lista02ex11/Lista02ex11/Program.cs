using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;

            Console.WriteLine("Digite a nota da primeira avaliação (P1):");
            p1 = double.Parse(Console.ReadLine());
           
            p2 = (3 * 5 - p1) / 2;

            Console.WriteLine($"O aluno precisa tirar {p2:f2} na segunda avaliação (P2) para ser aprovado.");
        }
    }
}
