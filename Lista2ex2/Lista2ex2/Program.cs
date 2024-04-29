using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex2
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
                Console.WriteLine("O primeiro valor é maior = {0}",v1);
            else
                if(v1 < v2)
                    Console.WriteLine("O segundo valor é maior = {0}",v2);
                else
                    Console.WriteLine("Os valores são iguais");

        }
    }
}
