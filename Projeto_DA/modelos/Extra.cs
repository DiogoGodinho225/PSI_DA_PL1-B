using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.modelos
{
    public class Extra
    {
        public int id{ get; set; }
        public string descricaoExtra {  get; set; }

        public float precoExtra {  get; set; }

        public bool ativoExtra { get; set; }

        public override string ToString()
        {
            return descricaoExtra + " | Preco: " + precoExtra;  
        }
    }
}
