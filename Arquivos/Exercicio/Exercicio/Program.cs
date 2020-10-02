using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string sourcePath = @"C:\Users\Computador\Desktop\Arquivo.txt";
            
            Directory.CreateDirectory(@"C:\Users\Computador\Desktop\out");

            string targetPath = @"C:\Users\Computador\Desktop\out\summary.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {

                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1],CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Produto p = new Produto(name, price, quantity);

                        double resultado = p.Calcula(price,quantity);

                        sw.WriteLine(name + "," + resultado.ToString("F2",CultureInfo.InvariantCulture));

                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
