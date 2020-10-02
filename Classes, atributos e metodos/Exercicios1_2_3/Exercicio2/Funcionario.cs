using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            double salarioBruto = SalarioBruto;
            double imposto = Imposto;

            double resultLiq = salarioBruto - imposto;

            SalarioBruto = resultLiq;

            return SalarioBruto;
        }

        public void AumentarSalario(double porcentagem)
        {
            string nome = Nome;
            double novoResultado;
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
            novoResultado = SalarioBruto;

            Console.WriteLine("Dados atualizados: " + nome + ", $ " + novoResultado.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
