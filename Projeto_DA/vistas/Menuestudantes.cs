using Projeto_DA.controladores;
using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Projeto_DA.vistas
{
    public partial class Menuestudantes : Form
    {
        EstudantesController estudantesController;
        string nif;
        int id, numestudante;
        List<Estudante> estudantes;
        ProjetoContext context;

        public Menuestudantes()
        {
            InitializeComponent();
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.Length == 0 || txtnif.Text.Length == 0 || txtnum.Text.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtnif.Text.Length == 9)
                {
                    string nome = txtnome.Text;
                    int numestudante = int.Parse(txtnum.Text);
                    nif = txtnif.Text;
                    estudantesController.InserirEstudante(nome, numestudante, nif);
                    List<Estudante> listestudante = new List<Estudante>();
                    ShowEstudantes(listestudante);
                    txtnome.Clear();
                    txtnif.Clear();
                    txtnum.Clear();
                }
            }
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            if(listEstudante.SelectedItems == null)
            {

                MessageBox.Show("Selecione algum estudante", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                estudantesController.RemoverEstudante(id);
                List<Estudante> listestudante = new List<Estudante>();
                ShowEstudantes(listestudante);
            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (listEstudante.SelectedItems == null)
            {
                MessageBox.Show("Selecione algum Estudante", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                numestudante = int.Parse(txtnum.Text);
                estudantesController.AlterarEstudante(id, txtnome.Text, nif, numestudante);
                List<Estudante> listestudantes = new List<Estudante>();
                ShowEstudantes(listestudantes);
                txtnome.Clear();
                txtnif.Clear();
                txtnum.Clear();
            }
        }

        private void EstudanteDoubleClick(object sender, EventArgs e)
        {
            Estudante estudante = (Estudante)listEstudante.SelectedItem;

            txtnome.Text = estudante.nome_Utilizador;
            txtnif.Text = estudante.nif;
            txtnum.Text = estudante.numEstudante.ToString();
            numestudante = estudante.numEstudante;
            nif = estudante.nif;
            id = estudantesController.ProcurarEstudante(numestudante);
          
        }

        private void ShowEstudantes(List<Estudante> estudantes)
        {
            estudantes = estudantesController.ListarEstudante();
            listEstudante.DataSource = null;
            foreach (var estudante in estudantes)
            {
                listEstudante.DataSource = estudantes.ToList();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menuclientes menuclientes = new Menuclientes();
            menuclientes.Show();
            this.Close();
        }


        private void Menuestudantes_Load(object sender, EventArgs e)
        {
            context = new ProjetoContext();
            estudantesController = new EstudantesController(context);
            estudantes = new List<Estudante>();
            estudantes = estudantesController.ListarEstudante();
            foreach (var estudante in estudantes)
            {
                listEstudante.DataSource = estudantes.ToList();
            }
        }
    }
}
