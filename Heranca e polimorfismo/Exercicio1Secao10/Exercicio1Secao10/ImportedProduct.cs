using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio1Secao10
{
    class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) : base (name,price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            double total = TotalPrice();
            
            return $"{Name} $ {total.ToString("F2",CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public double TotalPrice()
        {
            Price = Price + CustomsFee;
            return Price;
        }


    }
}
