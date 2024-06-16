using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.modelos
{
    public class Fatura
    {

        public int id {  get; set; }
        public float total {  get; set; }

        public DateTime dataHora { get; set; }

        public Menu menu { get; set; }
    }
}
