using Projeto_DA.controladores;
using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class Menufuncionarios : Form
    {
        FuncionariosController funcionariosController;
        ProjetoContext context;
        string nif;
        int id;
        Menuprincipal form1;

        public Menufuncionarios()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            context = new ProjetoContext();
            funcionariosController = new FuncionariosController(context);
            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios = funcionariosController.ListarFuncionario();
            foreach (var funcionario in funcionarios)
            {
                listFuncionario.DataSource = funcionarios.ToList();
            }
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            if(txtnome.Text.Length == 0 || txtnif.Text.Length == 0 || txtuser.Text.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(txtnif.Text.Length == 9)
                {
                    string nome = txtnome.Text;
                    string username = txtuser.Text;
                    string nif = txtnif.Text;
                    funcionariosController.InserirFuncionario(nome, username, nif);
                    List<Funcionario> listfuncionarios = new List<Funcionario>();
                    ShowFuncionarios(listfuncionarios);
                    txtnome.Clear();
                    txtnif.Clear();
                    txtuser.Clear();
                }
                else
                {
                    MessageBox.Show("O nif so pode ter 9 digitos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            if (listFuncionario.SelectedItems == null)
            {
                MessageBox.Show("Selecione algum funcionario", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                funcionariosController.RemoverFuncionario(id);
                List<Funcionario> listfuncionarios = new List<Funcionario>();
                ShowFuncionarios(listfuncionarios);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (listFuncionario.SelectedItems == null)
            {
                MessageBox.Show("Selecione algum funcionario", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                funcionariosController.AlterarFuncionario(id, txtnome.Text, txtnif.Text, txtuser.Text);
                List<Funcionario> listfuncionarios = new List<Funcionario>();
                ShowFuncionarios(listfuncionarios);
                txtnome.Clear();
                txtnif.Clear();
                txtuser.Clear();
            }
            
        }


        private void listFuncionariosDoubleClick(object sender, EventArgs e)
        {
            Funcionario funcionario = (Funcionario)listFuncionario.SelectedItem;

            txtnome.Text = funcionario.nome_Utilizador;
            txtnif.Text = funcionario.nif;
            txtuser.Text = funcionario.userName;
            nif = funcionario.nif;
            id = funcionariosController.ProcurarFuncionario(nif);

        }

        private void ShowFuncionarios(List<Funcionario> funcionario)
        {
            funcionario = funcionariosController.ListarFuncionario();
            listFuncionario.DataSource = null;
            foreach (var funcionarios in funcionario)
            {
                listFuncionario.DataSource = funcionario.ToList();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            form1 = new Menuprincipal();
            form1.ShowDialog();
        }

       
    }
}
