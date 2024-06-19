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
    internal class QuantidadePratosController
    {

        ProjetoContext context;

        public QuantidadePratosController(ProjetoContext context)
        {
            this.context = context;

        }

        public void AlterarQuantidade(int idPrato, int qntPrato)
        {
            var quantidadePrato = context.QuantidadePratos.FirstOrDefault(q => q.idPrato == idPrato);

            if (quantidadePrato != null)
            {
                quantidadePrato.quantidadePrato += qntPrato;

                context.SaveChanges();
                MessageBox.Show("Quantidade Alterada", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                quantidadePrato = new QuantidadePratos { idPrato = idPrato, quantidadePrato = qntPrato };

                context.QuantidadePratos.Add(quantidadePrato);
                MessageBox.Show("Quantidade Adicionada", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            context.SaveChanges();
        }


        public int GetQuantidade(int id)
        {
            var quantidadePrato = context.QuantidadePratos.FirstOrDefault(q => q.idPrato == id);
            if (quantidadePrato != null)
            {
                return quantidadePrato.quantidadePrato;
            }
            return 0;
        }

        public void TirarQuantidadePrato(int id, int qntPrato)
        {
            QuantidadePratos quantidadePratos = context.QuantidadePratos.FirstOrDefault(q => q.id == id);

            if (quantidadePratos != null)
            {
                if (quantidadePratos.quantidadePrato > qntPrato)
                {
                    quantidadePratos.quantidadePrato = qntPrato;
                }
            }
            else
            {
                MessageBox.Show("Não existe quantidade", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            context.SaveChanges();

        }
    }
}

