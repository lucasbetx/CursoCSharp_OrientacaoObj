using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4e5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exercicio 5");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();


            int Ex1qntPec1 = 1;
            double Ex1valPec1 = 5.30;
            int Ex1qntPec2 = 2;
            double Ex1valPec2 = 5.10;

            int Ex2qntPec1 = 2;
            double Ex2valPec1 = 15.30;
            int Ex2qntPec2 = 4;
            double Ex2valPec2 = 5.20;

            int Ex3qntPec1 = 1;
            double Ex3valPec1 = 15.10;
            int Ex3qntPec2 = 1;
            double Ex3valPec2 = 15.10;


            Console.WriteLine("VALOR A PAGAR: R$ " + ((Ex1valPec1 * Ex1qntPec1) + (Ex1valPec2 * Ex1qntPec2)).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("VALOR A PAGAR: R$ " + ((Ex2valPec1 * Ex2qntPec1) + (Ex2valPec2 * Ex2qntPec2)).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("VALOR A PAGAR: R$ " + ((Ex3valPec1 * Ex3qntPec1) + (Ex3valPec2 * Ex3qntPec2)).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exercicio 6");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();

            double a1 = 3.0;
            double b1 = 4.0;
            double c1= 5.2;
            double raio = 3.14159;

            double trapezio = ((a1 + b1) * c1) / 2;

            Console.WriteLine("TRIANGULO: " + ((a1 * c1) / 2).ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + (raio * (c1 * c1)).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + (b1 * b1).ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + (a1 * b1).ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine();

            double a2 = 12.7;
            double b2 = 10.4;
            double c2 = 15.2;


            double trapezio2 = ((a2 + b2) * c2) / 2;

            Console.WriteLine("TRIANGULO: " + ((a2 * c2) / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + (raio * (c2 * c2)).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio2.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + (b2 * b2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + (a2 * b2).ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
