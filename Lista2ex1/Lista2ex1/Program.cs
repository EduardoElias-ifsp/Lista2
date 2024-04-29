using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1;
            int v2;

            Console.WriteLine("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            v2 = int.Parse(Console.ReadLine());

            if (v1 > v2)
                Console.WriteLine("O primeiro é o maior número = {0}",v1);
            else
                Console.WriteLine("O segundo é o maior número = {0}", v2);
        }
    }
}
