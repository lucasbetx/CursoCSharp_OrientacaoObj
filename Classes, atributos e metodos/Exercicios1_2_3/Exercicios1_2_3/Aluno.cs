using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1_2_3
{
    class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }


        public double CalcNota()
        {
            double NotFinal = Nota1 + Nota2 + Nota3;
            return NotFinal;
        }

        public double CalcFaltaPonts()
        {
            double NotFinal = Nota1 + Nota2 + Nota3;
            return 60 - NotFinal;
        }

        public string ResultNota()
        {
            double NotFinal = Nota1 + Nota2 + Nota3;
            if (NotFinal >= 60.00)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO";
            }
        }
    }
}
