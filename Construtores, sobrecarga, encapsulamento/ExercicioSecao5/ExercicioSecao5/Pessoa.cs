using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSecao5
{
    class Pessoa
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Deposito { get; private set; }
        public Pessoa(int numeroConta, string nomeTitular, double deposito)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Deposito = deposito;
        }

        public void AtualizaDados(int numeroConta, string nomeTitual, double deposito, double novoDeposito)
        {

            double depositoFinal = deposito + novoDeposito;

            Deposito = depositoFinal;
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine("Conta " + numeroConta + ", Titular: " + nomeTitual + ", Saldo: $ " + depositoFinal.ToString("F2",CultureInfo.InvariantCulture));
        }

        public void OperacSaque(int numeroConta, string nomeTitual, double deposito, double novoSaque)
        {
            double depositoFinal = deposito - novoSaque;
            depositoFinal = depositoFinal - 5;

            Deposito = depositoFinal;
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine("Conta " + numeroConta + ", Titular: " + nomeTitual + ", Saldo: $ " + depositoFinal.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
