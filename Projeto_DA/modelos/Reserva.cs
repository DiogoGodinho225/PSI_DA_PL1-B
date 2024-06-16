using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.modelos
{
    public class Reserva
    {
        public int id{  get; set; }

        public Prato pratos { get; set; }

        public Extra extras { get; set; }

        public Multa multas { get; set; }

        public Cliente clientes { get; set; }

        public Menu menus { get; set; }
    }
}
