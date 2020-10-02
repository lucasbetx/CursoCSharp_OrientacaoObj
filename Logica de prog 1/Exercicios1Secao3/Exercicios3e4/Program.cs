using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios3e4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();

            int a1 = 5;
            int a2 = 6;
            int a3 = 7;
            int a4 = 8;

            int b1 = 5;
            int b2 = 6;
            int b3 = -7;
            int b4 = 8;

            int diferenca = ((a1 * a2) - (a3 * a4));
            int diferenca2 = ((b1 * b2) - (b3 * b4));

            Console.WriteLine("Resposta: " + diferenca);
            Console.WriteLine("Resposta: " + diferenca2);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exercicio 4");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();

            int numFunc1 = 25;
            int horasTrab1 = 100;
            double valorHor1 = 5.50;


            int numFunc2 = 1;
            int horasTrab2 = 200;
            double valorHor2 = 20.50;


            int numFunc3 = 6;
            int horasTrab3 = 145;
            double valorHor3 = 15.55;

            Console.WriteLine("NUMBER = " + numFunc1);
            Console.WriteLine("SALARY = " + (horasTrab1 * valorHor1).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("NUMBER = " + numFunc2);
            Console.WriteLine("SALARY = " + (horasTrab2 * valorHor2).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("NUMBER = " + numFunc3);
            Console.WriteLine("SALARY = " + (horasTrab3 * valorHor3).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
