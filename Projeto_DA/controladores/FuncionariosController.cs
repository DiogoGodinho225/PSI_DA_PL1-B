using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.controladores
{
    internal class FuncionariosController
    {
        public List<Funcionario> funcionarios;
        ProjetoContext context;

        public FuncionariosController(ProjetoContext context)
        {
            this.context = context;
        }

        public List<Funcionario> ListarFuncionario()
        {
            funcionarios = new List<Funcionario>();
            var funcionario = context.Funcionario.ToList();
            funcionarios.AddRange(funcionario);
            return funcionarios;
        }


        public void InserirFuncionario(string nome, string username, string nif)
        {
            var nifFuncionarioExistente = context.Funcionario.FirstOrDefault(f => f.nif == nif);
            var nifEstudanteExistente = context.Estudante.FirstOrDefault(e => e.nif == nif);
            var nifProfessorExistente = context.Professor.FirstOrDefault(p=> p.nif == nif);

            if (nifFuncionarioExistente != null || nifEstudanteExistente != null || nifProfessorExistente != null)
            {

                MessageBox.Show("Esse NIF já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var funcionarios = new Funcionario { nome_Utilizador = nome, nif = nif, userName = username };
                context.Funcionario.Add(funcionarios);
                context.SaveChanges();
                MessageBox.Show("Funcionario inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        public int ProcurarFuncionario(string nif)
        {
            Funcionario funcionario = context.Funcionario.FirstOrDefault(f=> f.nif == nif);
            
            if(funcionario != null)
            {
                int id = funcionario.id;
                return id;
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }   
        }

        public void RemoverFuncionario(int id)
        {

            var funcionario = context.Funcionario.Find(id);
           
            if(funcionario != null)
            {
                context.Funcionario.Remove(funcionario);
                context.SaveChanges();
                MessageBox.Show("Funcionario apagado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
            else
            {
                MessageBox.Show("Funcionario não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AlterarFuncionario(int id, string nome, string nif, string username)
        {
            var funcionario = context.Funcionario.Find(id);
            if (funcionario != null)
            {
                funcionario.nome_Utilizador = nome;
                funcionario.nif = nif;
                funcionario.userName = username;
                context.SaveChanges();
                MessageBox.Show("Funcionario Atualizado", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Funcionario não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
