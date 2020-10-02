using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercicio 1");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();

            int a1 = -10;
            int a2 = 8;
            int a3 = 0;


            if (a1 >= 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

            if (a2 >= 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

            if (a3 >= 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();


            int ex2a1 = int.Parse(Console.ReadLine());

            if (ex2a1 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            
            int ex2a2 = int.Parse(Console.ReadLine());

            if (ex2a2 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

            int ex2a3 = int.Parse(Console.ReadLine());

            if (ex2a3 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();

            int ex3a1 = int.Parse(Console.ReadLine());
            int ex3b1 = int.Parse(Console.ReadLine());

            if (ex3b1 % 2 == 0 && ex2a1 % 2 == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }


            int ex3a2 = int.Parse(Console.ReadLine());
            int ex3b2 = int.Parse(Console.ReadLine());

            if (ex3a2 % 2 == 0 && ex3b2 % 2 == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }


            int ex3a3 = int.Parse(Console.ReadLine());
            int ex3b3 = int.Parse(Console.ReadLine());

            if (ex3a3 % 2 == 0 && ex3b3 % 2 == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }




        }
    }
}
