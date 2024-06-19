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

        public Prato pratos { get; set; } = new Prato();

        public Multa multas { get; set; }

        public Cliente clientes { get; set; } = new Cliente();

        public Menu menus { get; set; }

        public bool utilizado { get; set; }

        public override string ToString()
        {
            return "Cliente: " + clientes.nome_Utilizador + " Prato: " + pratos.descricao;
        }
    }
}
