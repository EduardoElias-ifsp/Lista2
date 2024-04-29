using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int bas;
          int alt;
          int area;

          Console.WriteLine("Digite a base do retângulo");
          bas = int.Parse(Console.ReadLine());
          Console.WriteLine("Digite a altura do retângulo");
          alt = int.Parse(Console.ReadLine());

            area = bas * alt;
            if (area > 100)
                Console.WriteLine("Terreno grande");
        }
    }
}
