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

namespace Projeto_DA.vistas
{
    public partial class Saldo : Form
    {
        float saldoAdicional = 0, saldo = 0;
        SaldoController saldoController;
        ProjetoContext context;
        int id;
        public Saldo()
        {
            InitializeComponent();
            context = new ProjetoContext();
            saldoController = new SaldoController(context);
            id = Menuclientes.id;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menuclientes cliente = new Menuclientes();
            cliente.Show();
            this.Close();
        }

        private void btnAddSaldo_Click(object sender, EventArgs e)
        {
            saldoAdicional = float.Parse(textBoxsaldo.Text);
            if (saldoAdicional != 0)
            {
                saldoController.AlterarSaldo(id, saldoAdicional);
                saldo = saldoController.GetSaldo(id);
                textBoxsaldo.Clear();
            }
        }
    }
}
