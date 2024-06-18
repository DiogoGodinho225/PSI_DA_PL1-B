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
    public partial class MenuReservas : Form
    {
        ProjetoContext context;
        ExtrasController extrasController;
        QuantidadeExtrasController quantidadeExtraController;
        ProfessorController professorController;
        EstudantesController estudantesController;
        MenusController menusController;
        List<Extra> extras;
        List<Projeto_DA.modelos.Menu> menus;
        bool menuencontrado = false;
        DateTime menuDiaEncontrado;
        int id = 0;
        List<Professor> professores;
        List<Estudante> estudantes;
        float precoEstudante = (float)2.80, precoProfessor = (float)2.50, precoTotal = 0;
        List<Extra> extraSelecionado;

        public MenuReservas()
        {
            InitializeComponent();
            context = new ProjetoContext();
            extraSelecionado = new List<Extra>();
            extrasController = new ExtrasController(context);
            quantidadeExtraController = new QuantidadeExtrasController(context);
            menusController = new MenusController(context);
            professorController = new ProfessorController(context);
            estudantesController = new EstudantesController(context);
            extras = extrasController.ListarExtra();
            listExtras.DataSource = null;
            foreach (var extra in extras)
            {
                listExtras.DataSource = extras.ToList();
            }
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

        private void btnCriar_Click(object sender, EventArgs e)
        {
          
        }

        private void dateTimeDia_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataselecionada = dateTimeDia.Value.Date;
            menuDiaEncontrado = DateTime.MinValue;
            List<DateTime> databd = menusController.procurarData();

            for (int i = 0; i < databd.Count; i++)
            {
                if(dataselecionada.Date == databd[i].Date)
                {
                    menuencontrado = true;
                    menuDiaEncontrado = databd[i].Date;
                }
                else
                {
                    menuencontrado = false;
                }
            }

            if (menuencontrado == true)
            {
                menus = menusController.procurarMenus(menuDiaEncontrado);
                listMenu.DataSource = null;
                foreach (var menu in menus)
                {
                    listMenu.DataSource = menus.ToList();
                }
            }
            else
            {
                MessageBox.Show("Não foram encontrados menus para esse dia", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menuprincipal menuprincipal = new Menuprincipal();
            menuprincipal.Show();
            this.Close();

        }

        private void ReservaEstudantesDoubleClick(object sender, EventArgs e)
        {
            if (listEstudantes.SelectedItem != null)
            {
                Estudante estudante = (Estudante)listEstudantes.SelectedItem;
                labelPrecoTotal.Text = precoEstudante.ToString() + " € ";
                precoTotal = precoEstudante;
            }
        }

        private void ReservaExtrasDoubleClick(object sender, EventArgs e)
        {
            int extrasCounter = 0;

            if (listExtras.SelectedItem != null)
            {
                if (extraSelecionado.Count >= 3)
                {
                    MessageBox.Show("Não pode inserir mais de 3 extras", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Extra extraselecionado = (Extra)listExtras.SelectedItem;
                extraSelecionado.Add(extraselecionado);
                float precoExtra = extraselecionado.precoExtra;
                precoTotal += precoExtra;
                labelPrecoTotal.Text = precoTotal.ToString() + " €";
                
         
                
            }
        }

        private void ReservaProfessoresDoubleClick(object sender, EventArgs e)
        {
            if(listProfessores.SelectedItem != null)
            {
                Professor professor = (Professor)listProfessores.SelectedItem;
                labelPrecoTotal.Text = precoProfessor.ToString() + " € ";
                precoTotal = precoProfessor;
            }

        }
    }
}
