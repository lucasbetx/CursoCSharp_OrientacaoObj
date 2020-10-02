using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioSecao14.Entities;
using ExercicioSecao14.Services;
using System.Globalization;

namespace ExercicioSecao14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());


            Contract contract = new Contract(numero, data, value);

            Console.WriteLine("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(contract, installments);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
