using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Digite o primeiro lado:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado:");
            c = int.Parse(Console.ReadLine());

            // Verifica se os valores digitados formam um triângulo
            if (a + b > c && a + c > b && b + c > a)
            {
                // Verifica se é um triângulo retângulo
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                {
                    Console.WriteLine("Os lados formam um triângulo retângulo.");
                }
                else
                {
                    Console.WriteLine("Os lados não formam um triângulo retângulo.");
                }
            }
            else
            {
                Console.WriteLine("Os valores digitados não formam um triângulo.");
            }
        }
    }
}
