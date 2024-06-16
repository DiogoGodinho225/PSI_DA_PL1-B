using System;
using System.Collections.Generic;
using System.ComponentModel;
using Projeto_DA.modelos;
using Projeto_DA.controladores;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.vistas
{
    public partial class MenuProfessores : Form
    {
        ProfessorController professorcontroller;
        string nif, emailprofessor;
        int id;
        List<Professor> professores;
        ProjetoContext context;

        public MenuProfessores()
        {
            InitializeComponent();
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            if (listProfessores.SelectedItems == null)
            {
                MessageBox.Show("Selecione algum professor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                professorcontroller.RemoverProfessor(id);
                List<Professor> listProfessores = new List<Professor>();
                ShowProfessores(listProfessores);
            }
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text.Length == 0 || txtnif.Text.Length == 0 || txtemail.Text.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtnif.Text.Length == 9)
                {
                    string nome = txtnome.Text;
                    string email = txtemail.Text;
                    nif = txtnif.Text;
                    professorcontroller.InserirProfessor(nome, email, nif);
                    List<Professor> listprofessor = new List<Professor>();
                    ShowProfessores(listprofessor);
                    txtnome.Clear();
                    txtnif.Clear();
                    txtemail.Clear();
                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (listProfessores.SelectedItems == null)
            {
                MessageBox.Show("Selecione algum Professor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                emailprofessor = txtemail.Text;
                professorcontroller.AlterarProfessor(id, txtnome.Text, nif, emailprofessor);
                List<Professor> listprofessores = new List<Professor>();
                ShowProfessores(listprofessores);
                txtnome.Clear();
                txtnif.Clear();
                txtemail.Clear();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menuclientes menuclientes = new Menuclientes();
            menuclientes.Show();
            this.Close();
        }

        private void MenuProfessores_Load(object sender, EventArgs e)
        {
            context = new ProjetoContext();
            professorcontroller = new ProfessorController(context);
            professores = new List<Professor>();
            professores = professorcontroller.ListarProfessor();
            foreach (var estudante in professores)
            {
                listProfessores.DataSource = professores.ToList();
            }
        }

        private void ProfessoresDoubleClick(object sender, EventArgs e)
        {
            Professor professor = (Professor)listProfessores.SelectedItem;

            txtnome.Text = professor.nome_Utilizador;
            txtnif.Text = professor.nif;
            txtemail.Text = professor.email;
            nif = professor.nif;
            id = professorcontroller.ProcurarProfessor(nif);
        }

        private void ShowProfessores(List<Professor> professores)
        {
            professores = professorcontroller.ListarProfessor();
            listProfessores.DataSource = null;
            foreach (var professor in professores)
            {
                listProfessores.DataSource = professores.ToList();
            }
        }


    }
}
