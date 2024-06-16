using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.modelos
{
    public class Utilizador
    {
        public int id { get; set; }
        public string nome_Utilizador { get; set; }
        public string nif {  get; set; }

        public override string ToString()
        {
            return nome_Utilizador + " | " + nif;
        }
    }
}   
