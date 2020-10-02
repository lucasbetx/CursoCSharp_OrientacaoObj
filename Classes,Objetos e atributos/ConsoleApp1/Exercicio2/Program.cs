using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.WriteLine("Nome:");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salario:");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine();

            Console.WriteLine("Dados do segundo funcionario:");
            Console.WriteLine("Nome:");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salario:");
            f2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salario médio: " + media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
