using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1_2_3
{
    class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }


        public double Area()
        {
            double area =  Largura * Altura; 
            return area;
        }

        public double Perimetro()
        {
            double perimetro = 2 * (Largura + Altura);
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal = (Largura * Largura) + (Altura * Altura);
            diagonal = Math.Sqrt(diagonal);
            return diagonal;
        }



    }
}
