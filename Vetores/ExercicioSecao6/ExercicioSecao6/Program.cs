using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSecao6
{
    class Program
    {
        static void Main(string[] args)
        {

            int qtdQuartos = 10;

            Quarto[] quartos = new Quarto[qtdQuartos];

            Console.Write("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int numero = 1;

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Aluguel #" + numero + ":");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                quartos[room] = new Quarto(room, name, email);
                Console.WriteLine();
                numero++;
            }

            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i + ": " + quartos[i].NomeEstudante + ", " + quartos[i].Email);
                }
            }
        }
    }
}
