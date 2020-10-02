using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio2Secao10
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double anualIncome = AnualIncome;
            double healthExpenditures = HealthExpenditures;
            double result;
            double finaleResult;

            healthExpenditures.ToString("F2", CultureInfo.InvariantCulture);
            anualIncome.ToString("F2", CultureInfo.InvariantCulture);



            if (anualIncome < 20000.00)
            {
                result = anualIncome * 15.0 / 100.0;
            }
            else
            {
                result = anualIncome * 25.0 / 100.0;
            }

            if (healthExpenditures > 0)
            {
                finaleResult = result - (healthExpenditures * 50.0 / 100.0);

                return finaleResult;
            }
            else
            {
                return result;
            }
        }
    }
}
