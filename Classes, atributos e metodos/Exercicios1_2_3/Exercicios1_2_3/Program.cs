using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            Console.WriteLine("Nome do aluno:");
            a1.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a1.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a1.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a1.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double notFinal = a1.CalcNota();
            string result = a1.ResultNota();
            double calPonts = a1.CalcFaltaPonts(); 

            Console.WriteLine("NOTA FINAL = " + notFinal.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(result);

            if (notFinal < 60.00)
            {
                Console.WriteLine("FALTARAM " + calPonts.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
