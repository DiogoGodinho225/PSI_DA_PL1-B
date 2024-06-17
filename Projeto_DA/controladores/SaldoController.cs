using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.controladores
{
    internal class SaldoController
    {
        ProjetoContext context;

        public SaldoController(ProjetoContext context)
        {
            this.context = context;
        }

        public void AlterarSaldo(int id, float saldo)
        {
            Cliente cliente = context.Cliente.FirstOrDefault(s => s.id == id);

            if (cliente != null)
            {
                cliente.saldo += saldo;

                context.SaveChanges();
                MessageBox.Show("Saldo Adicionado", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cliente não encontrado", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            context.SaveChanges();
        }
    }
}
