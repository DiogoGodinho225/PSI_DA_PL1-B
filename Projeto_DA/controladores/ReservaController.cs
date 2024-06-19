using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.InteropServices.WindowsRuntime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Projeto_DA.controladores
{
    public class ReservaController
    {
        ProjetoContext context;
        List<Reserva> reservas;

        public ReservaController(ProjetoContext context)
        {
            this.context = context;
        }

        public Reserva CriarReserva(Prato prato, Cliente cliente, Projeto_DA.modelos.Menu menu)
        {
            var reserva = new Reserva { pratos = prato, clientes = cliente, menus = menu };
            context.Reserva.Add(reserva);
            context.SaveChanges();
            MessageBox.Show("Reserva Inserida", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return reserva;
        }

        public void CriarExtrasReserva(List<Extra> extra, Reserva reservas)
        {
            foreach(var extras in extra)
            {
                var reserva = new ReservaExtras {extra = extras, reserva = reservas};
                context.ReservaExtras.Add(reserva);
            }
            context.SaveChanges();
        }

        public List<Reserva> ListarReservas()
        {
            reservas = new List<Reserva>();
            var reserva = context.Reserva.Include(r => r.pratos).Include(r => r.clientes).ToList();
            reservas.AddRange(reserva);
            return reservas;
        }

        public List<Reserva> verificarReservaDia(Projeto_DA.modelos.Menu menu)
        {
            var reserva = context.Reserva.Include(r => r.pratos).Include(r => r.clientes).Where(r => r.menus == menu).ToList();

            if(reserva.Any())
            {
                return reserva;
            }
            return null;
        }

    }
}
