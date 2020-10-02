using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dólar ? ");
            double cotDolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares voce vai comprar? ");
            double dolars = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double cot = ConversorDeMoeda.CalcValor(cotDolar, dolars);

            double resultFinl = ConversorDeMoeda.AplicPorc(cot);

            Console.WriteLine("Valor a ser pago em reais = " + resultFinl.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
