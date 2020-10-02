using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio.Entits.Enum;
using System.Globalization;

namespace Exercicio.Entits
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {

        }

        public Order(DateTime moment, Client client)
        {
            Moment = moment;
            Client = client;
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Add(item);
        }

        

        public void Mostra()
        {
            List<double> Calcula = new List<double>();

            foreach (OrderItem orderItem in Items)
            {
                double Preco = orderItem.Product.Price;
                int Quantidade = orderItem.Quantity;

                double resultado = Preco * Quantidade;

                resultado.ToString("F2", CultureInfo.InvariantCulture);

                Calcula.Add(resultado);

                Console.WriteLine(orderItem.Product.Name + ", $" + orderItem.Product.Price.ToString("F2",CultureInfo.InvariantCulture) + ", Quantity: " + orderItem.Quantity + ", Subtotal: $" + resultado);
            }

            var firstItem = Calcula.ElementAt(0);
            var secondItem = Calcula.ElementAt(1);

            var result = firstItem + secondItem;

            Console.WriteLine("Total price: $" + result.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
