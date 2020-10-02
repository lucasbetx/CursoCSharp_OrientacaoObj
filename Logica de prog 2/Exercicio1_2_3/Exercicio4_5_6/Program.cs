using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_5_6
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Exercicio 5");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();

            Console.WriteLine(" 1 - Cachorro Quente - R$ 4,00");
            Console.WriteLine(" 2 - X-Salada - R$ 4,50");
            Console.WriteLine(" 3 - X-Bacon - R$ 5,00");
            Console.WriteLine(" 4 - Torrada Simples - R$ 2,00");
            Console.WriteLine(" 5 - Refrigerante - R$ 1,50");
            Console.WriteLine();

            int i = 0;

            while (i <= 1)
            {
                Console.WriteLine("Digite o codigo do item que deseja comer:");

                int codigo;

                double cachorroQuente = 4.00;
                double xSalada = 4.50;
                double xBacon = 5.00;
                double torradaSimples = 2.00;
                double refrigerante = 1.50;

                codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade: ");
                int qtd = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        Console.WriteLine("Total: R$ " + (cachorroQuente * qtd).ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    case 2:
                        Console.WriteLine("Total: R$ " + (xSalada * qtd).ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    case 3:
                        Console.WriteLine("Total: R$ " + (xBacon * qtd).ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    case 4:
                        Console.WriteLine("Total: R$ " + (torradaSimples * qtd).ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    case 5:
                        Console.WriteLine("Total: R$ " + (refrigerante * qtd).ToString("F2", CultureInfo.InvariantCulture));
                        break;
                }
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Exercicio 6");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();

            double ent1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double ent2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double ent3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double ent4 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if ( ent1 >= 0.00 && ent1 <= 25.00 )
            {
                Console.WriteLine("Intervalo (0,25]");
            }else if ( ent1 >= 25.00 && ent1 <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }else if ( ent1 >= 50.00 && ent1 <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            }else if (ent1 >= 75.00 && ent1 <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }

            if (ent2 >= 0 && ent2 <= 25)
            {
                Console.WriteLine("Intervalo (0,25]");
            }
            else if (ent2 >= 25 && ent2 <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (ent2 >= 50 && ent2 <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (ent2 >= 75 && ent2 <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }

            if (ent3 >= 0 && ent3 <= 25)
            {
                Console.WriteLine("Intervalo (0,25]");
            }
            else if (ent3 >= 25 && ent3 <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (ent3 >= 50 && ent3 <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (ent3 >= 75 && ent3 <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }

            if (ent4 >= 0 && ent4 <= 25)
            {
                Console.WriteLine("Intervalo (0,25]");
            }
            else if (ent4 >= 25 && ent4 <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (ent4 >= 50 && ent4 <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (ent4 >= 75 && ent4 <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }

        }
    }
}
