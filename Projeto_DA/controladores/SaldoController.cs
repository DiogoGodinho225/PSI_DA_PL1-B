using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.controladores
{
    public class SaldoController
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
                cliente = new Cliente { saldo = saldo};
                context.Cliente.Add(cliente);
                MessageBox.Show("Saldo Adicionado", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            context.SaveChanges();
        }

        public float GetSaldo(int id)
        {
            var saldo = context.Cliente.FirstOrDefault(s => s.id == id);
            if (saldo != null)
            {
                return saldo.saldo;
            }
            return 0;
        }
    }
}
