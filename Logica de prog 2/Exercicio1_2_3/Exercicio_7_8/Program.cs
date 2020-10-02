using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0.00 && salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario >= 2000.01 && salario <= 3000.00)
            {
                double result = ((double)8 / 100) * salario;
                Console.WriteLine(result.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario >= 3000.01 && salario <= 4500.00)
            {
                double result1 = ((double)18 / 100) * salario;
                Console.WriteLine(result1.ToString("F2",CultureInfo.InvariantCulture));
            }
            else if (salario >= 4500.00)
            {
                double result2 = ((double)28 / 100) * salario;
                Console.WriteLine(result2.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
