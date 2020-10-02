using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int qtdEmp = int.Parse(Console.ReadLine());
            int codEmp = 1;

            Console.WriteLine();

            for (int i = 0; i < qtdEmp; i++)
            {
                Console.WriteLine("Employee #" + codEmp + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));

                Console.WriteLine("");

                codEmp++;
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idSalary = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.Id == idSalary);
            double percent;

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist");
            }


            Console.WriteLine();

            Console.WriteLine("Update list of employees:");
            foreach (var show in list)
            {
                Console.WriteLine(show.Id + ", " + show.Name + ", " + show.Salary.ToString("F2",CultureInfo.InvariantCulture));
            }

            Console.WriteLine();

        }
    }
}
