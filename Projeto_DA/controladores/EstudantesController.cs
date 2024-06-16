using System;
using Projeto_DA.modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.controladores
{
    internal class EstudantesController
    {
        public List<Estudante> estudantes;
        ProjetoContext context;

        public EstudantesController(ProjetoContext context)
        {
            this.context = context;
        }

        public List<Estudante> ListarEstudante()
        {
            estudantes = new List<Estudante>();
            var estudante = context.Estudante.ToList();
            estudantes.AddRange(estudante);
            return estudantes;
        }


        public void InserirEstudante(string nome, int numEstudante, string nif)
        {

            var estudanteExistente = context.Estudante.FirstOrDefault(e => e.numEstudante == numEstudante);
            if (estudanteExistente != null)
            {
                MessageBox.Show("Número de estudante já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var estudante = new Estudante { nome_Utilizador = nome, nif = nif, numEstudante = numEstudante };
            context.Estudante.Add(estudante);
            context.SaveChanges();
            MessageBox.Show("Estudante Inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public int ProcurarEstudante(int numestudante)
        {
           Estudante estudante = context.Estudante.FirstOrDefault(e => e.numEstudante == numestudante);
            if (estudante != null)
            {
                int id = estudante.id;
                return id;
            }
            else
            {
                MessageBox.Show("Estudante não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public void RemoverEstudante(int id)
        {

            var estudante = context.Estudante.Find(id);

            if (estudante != null)
            {
                context.Estudante.Remove(estudante);
                context.SaveChanges();
                MessageBox.Show("Estudante apagado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Estudante não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AlterarEstudante(int id, string nome, string nif, int numestudante)
        {
            var estudante = context.Estudante.Find(id);
            if (estudante != null)
            {
                estudante.nome_Utilizador = nome;
                estudante.nif = nif;
                estudante.numEstudante = numestudante;
                context.SaveChanges();
                MessageBox.Show("Estudante Atualizado", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Estudante não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
