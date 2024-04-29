using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double imc;

            Console.WriteLine("Digite o peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 19)
                Console.WriteLine("Abaixo do peso (Feminino)");
            else if (imc < 24)
                Console.WriteLine("Peso ideal (Feminino)");
            else
                Console.WriteLine("Acima do peso (Feminino)");

            Console.WriteLine();

            if (imc < 20)
                Console.WriteLine("Abaixo do peso (Masculino)");
            else if (imc < 25)
                Console.WriteLine("Peso ideal (Masculino)");
            else
                Console.WriteLine("Acima do peso (Masculino)");
        }
    }
}
