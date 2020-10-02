using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSecao5
{
    class Program
    {
        static void Main(string[] args)
        {

            double deposito;

            Console.Write("Entre com o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());


            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string dpsInicial = Console.ReadLine();

            if (dpsInicial == "s")
            {
                Console.Write("Entre o valor do deposito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                deposito = 0;
            }

            Pessoa p1 = new Pessoa(numeroConta, nomeTitular, deposito);

            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine("Conta " + numeroConta + ", Titular: " + nomeTitular + ", Saldo: $ " + deposito.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.WriteLine();

            double novoDeposito;
            Console.Write("Entre um valor para depósito: ");
            novoDeposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            p1.AtualizaDados(numeroConta, nomeTitular, deposito, novoDeposito);

            deposito += novoDeposito;

            Console.WriteLine();

            double saque;
            Console.Write("Entre um valor para saque: ");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p1.OperacSaque(numeroConta, nomeTitular, deposito, saque);

            Console.WriteLine();

        }
    }
}
