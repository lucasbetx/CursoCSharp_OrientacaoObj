using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio.Entits;
using Exercicio.Entits.Enum;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cli = new Client();
            List<OrderItem> lista = new List<OrderItem>();

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            string status = Console.ReadLine();
            OrderStatus orderStatus;
            Enum.TryParse(status, true, out orderStatus);

            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, client);


            Console.Write("How many items to this order: ");
            int items = int.Parse(Console.ReadLine());

            int cont = 1;

            for (int i = 0; i < items; i++)
            {

                Console.WriteLine($"Enter #{cont} item data:");

                Console.Write("Product name: ");
                string nome = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantidade = int.Parse(Console.ReadLine());

                Product prod = new Product(nome, price);
                OrderItem orderItem = new OrderItem(quantidade, price, prod);

                order.AddItem(orderItem);

                cont++;
            }


            var dateFormat = "dd/MM/yyyy";

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order moment: " + DateTime.Now);
            Console.WriteLine("Order status: " + order.ToString());
            Console.WriteLine("Client: " + client.Name + " (" + client.BirthDate.ToString(dateFormat) + ") - " + client.Email);
            Console.WriteLine("Order items:");
            order.Mostra();



        }
    }
}
