using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.controladores
{
    internal class ProfessorController
    {
        List<Professor> professores;
        ProjetoContext context;

        public ProfessorController(ProjetoContext context)
        {
            this.context = context;
        }

        public List<Professor> ListarProfessor()
        {
            professores = new List<Professor>();
            var professor = context.Professor.ToList();
            professores.AddRange(professor);
            return professores;
        }

        public void InserirProfessor(string nome, string email, string nif)
        {

            var nifFuncionarioExistente = context.Funcionario.FirstOrDefault(f => f.nif == nif);
            var nifEstudanteExistente = context.Estudante.FirstOrDefault(e => e.nif == nif);
            var nifProfessorExistente = context.Professor.FirstOrDefault(p => p.nif == nif);

            if (nifFuncionarioExistente != null || nifEstudanteExistente != null || nifProfessorExistente != null)
            {

                MessageBox.Show("Esse NIF já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var professor = new Professor { nome_Utilizador = nome, nif = nif, email = email };
                context.Professor.Add(professor);
                context.SaveChanges();
                MessageBox.Show("Professor Inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        public int ProcurarProfessor(string nif)
        {
            Professor professor = context.Professor.FirstOrDefault(p => p.nif == nif);
            if (professor != null)
            {
                int id = professor.id;
                return id;
            }
            else
            {
                MessageBox.Show("Professor não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public void AlterarProfessor(int id, string nome, string nif, string email)
        {
            var professor = context.Professor.Find(id);
            if (professor != null)
            {
                professor.nome_Utilizador = nome;
                professor.nif = nif;
                professor.email = email;
                context.SaveChanges();
                MessageBox.Show("Professor Atualizado", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Professor não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoverProfessor(int id)
        {

            var professor = context.Professor.Find(id);

            if (professor != null)
            {
                context.Professor.Remove(professor);
                context.SaveChanges();
                MessageBox.Show("Professor apagado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Profes não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
