using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.modelos
{
    public class Estudante:Cliente
    {
        public int numEstudante { get; set; }

        public override string ToString()
        {
            return numEstudante + " | " + nome_Utilizador;
        }
    }
}
