using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_DA.modelos;

namespace Projeto_DA.controladores
{
    internal class QuantidadeExtrasController
    {

        ProjetoContext context;

        public QuantidadeExtrasController(ProjetoContext context)
        {
            this.context = context;

        }

        public void AlterarQuantidade(int id_extra, int qntExtra)
        {
            var quantidadeExtra = context.QuantidadeExtra.FirstOrDefault(q => q.id_extra == id_extra);

            if (quantidadeExtra != null)
            {
                quantidadeExtra.qntExtra += qntExtra;

                context.SaveChanges();
                MessageBox.Show("Quantidade Alterada", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                quantidadeExtra = new QuantidadeExtra { id_extra = id_extra, qntExtra = qntExtra };
   
                context.QuantidadeExtra.Add(quantidadeExtra);
                MessageBox.Show("Quantidade Adicionada", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            context.SaveChanges();
        }


        public int GetQuantidade(int id)
        {
            var quantidadeExtra = context.QuantidadeExtra.FirstOrDefault(q => q.id_extra == id);
            if (quantidadeExtra != null)
            {
                return quantidadeExtra.qntExtra;
            }
             return 0;
        }
    }
}
