using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.modelos
{
    public class ItemFatura
    {
        public int id {  get; set; }

        public string descricaoFatura {  get; set; }

        public float precoFatura {  get; set; }

        public Fatura faturas { get; set; }
    }
}
