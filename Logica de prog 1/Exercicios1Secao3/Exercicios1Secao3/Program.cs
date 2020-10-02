using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1Secao3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exercicio 1");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();

            int a1 = 10;
            int a2 = 30;

            Console.WriteLine("Resultado: " + (a1 + a2));

            int b1 = -30;
            int b2 = 10;

            Console.WriteLine("Resultado: " + (b1 + b2));

            int c1 = 0;
            int c2 = 0;

            Console.WriteLine("Resultado: " + (c1 + c2));

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();

            double aa1 = 2.00;
            double bb2 = 100.64;
            double cc3 = 150.00;

            double raio = 3.14159;

            double resultado1 = raio * (aa1 * aa1);
            double resultado2 = raio * (bb2 * bb2);
            double resultado3 = raio * (cc3 * cc3);

            Console.WriteLine("Resultado: " + resultado1.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Resultado: " + resultado2.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Resultado: " + resultado3.ToString("F4", CultureInfo.InvariantCulture));



        }
    }
}
