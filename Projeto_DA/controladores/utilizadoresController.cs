using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.controladores
{
    public class utilizadoresController
    {
        public List<Utilizador> utilizador;
        ProjetoContext context;

        public utilizadoresController(ProjetoContext context)
        {
            this.context = context;
        }

        public bool ProcurarTipo(int id)
        {
            Utilizador utilizador = context.Funcionario.FirstOrDefault(u => u.id == id);
            if (utilizador != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Não selecionou um funcionário", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
