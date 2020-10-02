using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSecao6
{
    class Quarto
    {
        public int Identificacao { get; set; }
        public string NomeEstudante { get; set; }
        public string Email { get; set; }

        public Quarto(int identificacao, string nomeEstudante, string email)
        {
            Identificacao = identificacao;
            NomeEstudante = nomeEstudante;
            Email = email;
        }
    }

}
