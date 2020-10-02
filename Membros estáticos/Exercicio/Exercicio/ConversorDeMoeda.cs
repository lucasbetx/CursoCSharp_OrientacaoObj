using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class ConversorDeMoeda
    {
        public static double CalcValor(double cotdol, double dol)
        {
            return cotdol * dol;
        }

        public static double AplicPorc(double vlue)
        {
            return vlue + (vlue * 6 / 100.0);
        }
    }
}
