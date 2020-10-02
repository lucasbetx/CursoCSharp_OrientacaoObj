using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio2Secao10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int taxPayers = int.Parse(Console.ReadLine());

            int taxPayerData = 1;

            for (int i = 0; i < taxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{taxPayerData} data:");
                Console.Write("Individual or company (i/c)? ");
                char escolha = char.Parse(Console.ReadLine());

                if (escolha == 'i')
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Health expenditures: ");
                    double healthExpenditues = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(nome, anualIncome, healthExpenditues));

                }
                else
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(nome, anualIncome, numberOfEmployees));

                }
                taxPayerData++;
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double sum = 0.0;

            foreach (TaxPayer tax in list)
            {
                double taxs = tax.Tax();

                Console.WriteLine(tax.Name + ": $ " + tax.Tax().ToString("F2",CultureInfo.InvariantCulture));

                sum += taxs;


            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
