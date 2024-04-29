using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pes;
            double alt;
            double rpa;
           
            Console.WriteLine("Digite o peso da pessoa");
            pes = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura da pessoa");
            alt = double.Parse(Console.ReadLine());

            rpa = pes / (alt*alt);
            Console.WriteLine(rpa);

            if (rpa < 20)
                Console.WriteLine("Abaixo do peso");
            else
            if(rpa >=20 && rpa < 25)
                Console.WriteLine("Peso ideal");
            else
                Console.WriteLine("Acima do peso");
          
        }
    }
}
