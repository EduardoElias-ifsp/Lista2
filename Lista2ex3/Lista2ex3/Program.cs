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

            if (v1 == v2)
                if (v1 == v3)
                    Console.WriteLine("Todos valores são iguais = {0}", v1);
                else
                    if (v1 > v3)
                    Console.WriteLine("O primeiro e segundo valor são os maiores = {0} ",v1);
                else
                    Console.WriteLine("O terceiro valor é o maior = {0}",v3);
            else
                if (v1 == v3)
                if (v1 > v3)
                    Console.WriteLine("O primeiro e terceiro valor são os maiores = {0}", v1);
                else
                    Console.WriteLine("O segundo valor é o maior = {0}",v2);
            else
                    if (v2 == v3)
                if (v2 > v1)
                    Console.WriteLine("O segundo e terceiro valores são os maiores = {0}",v2);
                else
                    Console.WriteLine("O primeiro valor é o maior = {0}",v1);
            else
                if (v2 > v3)
                Console.WriteLine("O segundo valor é o maior = {0}", v2);
            else
                Console.WriteLine("O terceiro valor é o maior = {0}",v3);
        }
    }
}
