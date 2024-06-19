using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.modelos
{
    public class ReservaExtras
    {
        public int id {  get; set; }
        public Reserva reserva { get; set; }
        public Extra extra { get; set; }
    }
}
