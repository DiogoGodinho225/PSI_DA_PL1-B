using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.modelos
{
    public class Professor:Cliente
    {
     
        public string email { get; set; }

        public override string ToString()
        {
            return nome_Utilizador + " | " + nif;
        }
    }
}
