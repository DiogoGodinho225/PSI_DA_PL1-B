using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.modelos
{
    public class Multa
    {
        public int id{  get; set; }

        public float multa {  get; set; }

        public TimeSpan numHoras { get; set; }

        public override string ToString()
        {
            return multa.ToString() + " €" + " Para : " + numHoras.ToString() + " horas";
        }
    }
}
