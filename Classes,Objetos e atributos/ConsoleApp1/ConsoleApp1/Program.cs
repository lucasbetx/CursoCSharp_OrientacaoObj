using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome:");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome:");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            p2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Pessoa mais velha: ");

            if (p1.idade > p2.idade)
            {
                Console.WriteLine(p1.nome);
            }
            else
            {
                Console.WriteLine(p2.nome);
            }

        }
    }
}
