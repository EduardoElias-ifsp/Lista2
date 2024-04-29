using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1;
            int lado2;
            int lado3;

            Console.WriteLine("Digite o primeiro lado:");
            lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado:");
            lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado:");
            lado3 = int.Parse(Console.ReadLine());

            if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
                if (lado1 == lado2 && lado1 == lado3)
                    Console.WriteLine("Triângulo Equilátero");
                else
                    if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    Console.WriteLine("Triângulo Isósceles");
                else
                    Console.WriteLine("Triângulo Escaleno");
            else
                Console.WriteLine("Não forma um triângulo.");
        }
    }
}
