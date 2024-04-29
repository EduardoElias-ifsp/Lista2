using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1;
            int v2;
            int v3;

            Console.WriteLine("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            v3 = int.Parse(Console.ReadLine());

            if (v1 > v2 && v1 > v3)
                Console.WriteLine("O primeiro valor é o Maior = {0}",v1);
            if (v2 > v1 && v2 > v3)
                Console.WriteLine("O segundo valor é o Maior = {0}",v2);
            if (v3 > v1 && v3 > v2)
                Console.WriteLine("O terceiro valor é o Maior = {0}", v3);


        }
    }
}
