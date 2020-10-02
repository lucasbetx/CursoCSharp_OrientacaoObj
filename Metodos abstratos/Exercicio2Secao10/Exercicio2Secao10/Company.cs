using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio2Secao10
{
    class Company : TaxPayer
    {

        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name,anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {

            double anualIncome = AnualIncome;
            int numberOfEmployees = NumberOfEmployees;

            anualIncome.ToString("F2", CultureInfo.InvariantCulture);

            if (numberOfEmployees > 10)
            {
                return anualIncome * 14.0 / 100.0;
            }
            else
            {
                return anualIncome * 16.0 / 100.0;
            }


        }

    }
}
