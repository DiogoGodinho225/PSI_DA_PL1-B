using Projeto_DA.controladores;
using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_DA.vistas
{
    public partial class VerificarReservas : Form
    {
        ProjetoContext context;
        ReservaController reservaController;
        List<Reserva> reservas;
        bool menuencontrado = false;
        DateTime menuDiaEncontrado;
        MenusController menusController;
        List<Reserva> reservaslist;
        List<Projeto_DA.modelos.Menu> menuList;
        Projeto_DA.modelos.Menu menuReserva;
        public VerificarReservas()
        {
            InitializeComponent();
            context = new ProjetoContext();
            reservaController = new ReservaController(context);
            menusController = new MenusController(context);
            reservaslist = new List<Reserva>();
            menuList = new List<Projeto_DA.modelos.Menu>();
        }

        private void btnEntregue_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuReservas reservas = new MenuReservas();
            reservas.Show();
            this.Close();
        }

        private void dateTimeDia_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
