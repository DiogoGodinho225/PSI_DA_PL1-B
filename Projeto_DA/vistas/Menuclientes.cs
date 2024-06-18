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

namespace Projeto_DA.vistas
{
    public partial class Menuclientes : Form
    {
        ProjetoContext context;
        ProfessorController professorController;
        EstudantesController estudantesController;
        SaldoController saldoController;
        List<Professor> professores;
        List<Estudante> estudantes;
        public static int id;
        float saldo;
        public Menuclientes()
        {
            InitializeComponent();
        }

        private void Menuclientes_Load(object sender, EventArgs e)
        {
            context = new ProjetoContext();
            professorController = new ProfessorController(context);
            saldoController = new SaldoController(context);
            professores = new List<Professor>();
            professores = professorController.ListarProfessor();
            foreach (var professor in professores)
            {
                listProfessores.DataSource = professores.ToList();
            }
            estudantesController = new EstudantesController(context);
            estudantes = new List<Estudante>();
            estudantes = estudantesController.ListarEstudante();
            foreach (var estudante in estudantes)
            {
                listEstudantes.DataSource = estudantes.ToList();
            }
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            MenuProfessores menuProfessores = new MenuProfessores();
            menuProfessores.Show();
            this.Close();
        }

        private void btnEstudantes_Click(object sender, EventArgs e)
        {
            Menuestudantes menuestudantes = new Menuestudantes();
            menuestudantes.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menuprincipal principal = new Menuprincipal();
            principal.Show();
            this.Close();
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            Saldo saldo = new Saldo();
            saldo.Show();
            this.Close();
        }

        private void SaldoProfessoresDoubleClick(object sender, EventArgs e)
        {
            if (listProfessores.SelectedItem != null && listProfessores.SelectedItem is Professor professor)
            {
                id = professor.id;
                saldo = saldoController.GetSaldo(id);
                labelsaldo.Text = saldo.ToString();
            }
        }

        private void SaldoEstudantesDoubleClick(object sender, EventArgs e)
        {
            if (listEstudantes.SelectedItem != null && listEstudantes.SelectedItem is Estudante estudante)
            {
                id = estudante.id;
                saldo = saldoController.GetSaldo(id);
                labelsaldo.Text = saldo.ToString();
            }
        }
    }
}
