using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.modelos
{
    public class Prato
    {
        public int id{  get; set; }

        public string descricao { get; set; }

        public string tipo { get; set; }

        public bool ativoPrato { get; set; }

        public override string ToString()
        {
            if (ativoPrato == true)
            {
                return descricao + " | Tipo: " + tipo + " (Ativo)";
            }
            else
            {
                return descricao + " | Tipo: " + tipo + " (Desativo)";
            }
        }

    }
}
