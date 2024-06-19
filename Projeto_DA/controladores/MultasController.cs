using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_DA.modelos;

namespace Projeto_DA.controladores
{
    
    public class MultasController
    {
        ProjetoContext context;
        List<Multa> multas;

        public MultasController(ProjetoContext context)
        {
            this.context = context;
        }

        public List<Multa> ListarMulta()
        {
            multas = new List<Multa>();
            var multa = context.Multa.ToList();
            multas.AddRange(multa);
            return multas;
        }

        public void InserirMulta(float multa, DateTime numHoras)
        {
            var multas = new Multa { multa = multa, numHoras =  numHoras.TimeOfDay};
            context.Multa.Add(multas);
            context.SaveChanges();
            MessageBox.Show("Multa Inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public int ProcurarMulta(DateTime numHoras)
        {
            Multa multa = context.Multa.FirstOrDefault(m => m.numHoras == numHoras.TimeOfDay);
            if (multa != null)
            {
                int id = multa.id;
                return id;
            }
            else
            {
                MessageBox.Show("Multa não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public void RemoverMulta(int id)
        {

            var multa = context.Multa.Find(id);

            if (multa != null)
            {
                context.Multa.Remove(multa);
                context.SaveChanges();
                MessageBox.Show("Multa apagada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Multa não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AlterarMulta(int id, float multa, DateTime numHoras)
        {
            var multas = context.Multa.Find(id);
            if (multas != null)
            {
                multas.multa = multa;
                multas.numHoras = numHoras.TimeOfDay;
                context.SaveChanges();
                MessageBox.Show("Multa Atualizado", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Multa não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
