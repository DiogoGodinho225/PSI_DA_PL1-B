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

namespace Projeto_DA.vistas
{
    public partial class MenuMultas : Form
    {
        MultasController multasController;
        ProjetoContext context;
        int id;
        float valor = 0;
        DateTime numHoras;
        
        public MenuMultas()
        {
            InitializeComponent();
            context = new ProjetoContext();
            multasController = new MultasController(context);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxValor.Text.Length == 0 || textBoxHoras.Text.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float valor = float.Parse(textBoxValor.Text);
                DateTime numHoras = DateTime.Parse(textBoxHoras.Text);
                multasController.InserirMulta(valor, numHoras);
                List<Multa> listmulta = new List<Multa>();
                ShowMulta(listmulta);
                textBoxValor.Clear();
                textBoxHoras.Clear();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listMultas.SelectedItems == null)
            {
                MessageBox.Show("Selecione alguma Multa", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                valor = float.Parse(textBoxValor.Text);
                numHoras = DateTime.Parse(textBoxHoras.Text);
                multasController.AlterarMulta(id, valor, numHoras);
                List<Multa> listmultas = new List<Multa>();
                ShowMulta(listmultas);
                textBoxValor.Clear();
                textBoxHoras.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listMultas.SelectedItems == null)
            {

                MessageBox.Show("Selecione alguma multa", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                multasController.RemoverMulta(id);
                List<Multa> listmultas = new List<Multa>();
                ShowMulta(listmultas);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menuprincipal principal = new Menuprincipal();
            principal.Show();
            this.Close();
        }

        private void ShowMulta(List<Multa> multas)
        {
            multas = multasController.ListarMulta();
            listMultas.DataSource = null;
            foreach (var multa in multas)
            {
                listMultas.DataSource = multas.ToList();
            }
        }

        private void ListMultaDoubleClick(object sender, EventArgs e)
        {
            Multa multa = (Multa)listMultas.SelectedItem;

            textBoxValor.Text = multa.multa.ToString();
            textBoxHoras.Text = multa.numHoras.ToString();
            numHoras = DateTime.Parse(multa.numHoras.ToString());
            id = multasController.ProcurarMulta(numHoras);
        }
    }
}
