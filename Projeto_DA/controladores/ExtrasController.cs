using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_DA.modelos;


namespace Projeto_DA.controladores
{
    public class ExtrasController
    {
        public List<Extra> extras;
        ProjetoContext context;
        QuantidadeExtrasController quantidadeExtrasController;

        public ExtrasController(ProjetoContext context)
        {
            this.context = context;
           
        }

        public List<Extra> ListarExtra()
        {
            extras = new List<Extra>();
            var extra = context.Extra.ToList();
            extras.AddRange(extra);
            return extras;
        }

        public void InserirExtra(string descricaoExtra, float precoExtra)
        { 
            var extra = new Extra { descricaoExtra = descricaoExtra, precoExtra = precoExtra, ativoExtra = true};
            context.Extra.Add(extra);
            context.SaveChanges();
            MessageBox.Show("Extra Inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void RemoverExtra(int id)
        {
            int id_extra = id;
            var extra = context.Extra.Find(id);
            var eliminarExtra = context.QuantidadeExtra.FirstOrDefault(e => e.id_extra == id);
            if (extra != null)
            {
                context.Extra.Remove(extra);
                context.QuantidadeExtra.Remove(eliminarExtra);
                context.SaveChanges();
                MessageBox.Show("Extra apagado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Extra não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AlterarExtra(int id, string descricaoExtra, float precoExtra)
        {
            var extra = context.Extra.Find(id);
            if (extra != null)
            {
               extra.descricaoExtra = descricaoExtra;
               extra.precoExtra = precoExtra;
              // extra.ativoExtra = ativoExtra;
               context.SaveChanges();
               MessageBox.Show("Extra Atualizado", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Extra não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int ProcurarExtra(string desc)
        {
            Extra extra = context.Extra.FirstOrDefault(e => e.descricaoExtra == desc);
            if (extra != null)
            {
                int id = extra.id;
                return id;
            }
            else
            {
                MessageBox.Show("Extra não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

    }
}
