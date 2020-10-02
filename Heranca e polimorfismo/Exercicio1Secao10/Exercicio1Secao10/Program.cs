using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio1Secao10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> lista = new List<Product>();

            Console.Write("Enter the number of products: ");
            int cont = int.Parse(Console.ReadLine());

            int itemProduct = 1;

            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine($"Product {itemProduct} data:");
                Console.Write("Common, used or imported (c/u/i): ");
                char verifica = char.Parse(Console.ReadLine());


                if (verifica == 'c')
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    lista.Add(new Product(nome, price));


                }else if (verifica == 'u')
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manafatura = DateTime.Parse(Console.ReadLine());

                    lista.Add(new UsedProduct(nome, price, manafatura));

                }
                else if (verifica == 'i')
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    lista.Add(new ImportedProduct(nome, price, customFee));

                }
                else
                {
                    Console.WriteLine("Você não digitou o tipo de produto de forma correta!");
                }
                itemProduct++;
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in lista)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
