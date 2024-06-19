using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_DA.controladores
{
    public class FaturaController
    {
        ProjetoContext context;

        public FaturaController(ProjetoContext context)
        {
            this.context = context;

        }

        public void GuardarFatura(float total, DateTime dataHora, List<Extra> extras, Projeto_DA.modelos.Menu menu)
        {
            var itemFatura = new ItemFatura(); 
            var Fatura = new Fatura { total = total, dataHora = dataHora, menu = menu };
            context.Fatura.Add(Fatura);
            for (int i = 0; i < extras.Count; i++)
            {
                itemFatura = new ItemFatura { descricaoFatura = extras[i].descricaoExtra, precoFatura = extras[i].precoExtra, faturas = Fatura };
                context.ItemFatura.Add(itemFatura);
                context.SaveChanges();
            }
            
            MessageBox.Show("Fatura adicionada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
