﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Entits
{
    class OrderItem
    {

        public int Quantity { get; set; }

        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
    }
}
