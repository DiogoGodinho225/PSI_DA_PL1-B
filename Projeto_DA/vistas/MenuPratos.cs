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
    public partial class MenuPratos : Form
    {


        PratosController pratosController;
        ProjetoContext context;
        int id;
        Menuprincipal menuprincipal;
        List<Prato> pratos;
 
        QuantidadePratosController quantidadePratosController;

        public MenuPratos()
        {
            InitializeComponent();
            context = new ProjetoContext();
            pratosController = new PratosController(context);
            quantidadePratosController = new QuantidadePratosController(context);
            pratos = pratosController.ListarPratos();
            listPratos.DataSource = null;
            txtQuantidade.Enabled = false;
            comboTipo.Enabled = false;
            comboTipo.Items.Add("Carne");
            comboTipo.Items.Add("Peixe");
            comboTipo.Items.Add("Vegetariano");
            foreach (var extra in pratos)
            {
                listPratos.DataSource = pratos.ToList();
            }
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string descricao = txtDescricao.Text;
                string tipo = comboTipo.Text;


                pratosController.InserirPrato (descricao, tipo);
                List<Prato> listPratos = new List<Prato>();
                ShowPratos(listPratos);
                txtDescricao.Clear();
                comboTipo.Items.Clear();
            }
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            if(listPratos.SelectedItems == null)
            {
                MessageBox.Show("Selecione algum extra", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                pratosController.RemoverPrato(id);
                List<Prato> listpratos = new List<Prato>();
                ShowPratos(listpratos);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (listPratos.SelectedItems == null)
            {
                MessageBox.Show("Selecione algum prato", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                pratosController.AlterarPrato(id, txtDescricao.Text, comboTipo.Text);
                List<Prato> listpratos = new List<Prato>();
                ShowPratos(listpratos);
                txtDescricao.Clear();
                comboTipo.Items.Clear();

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            menuprincipal = new Menuprincipal();
            menuprincipal.Show();
            this.Close();
        }

        private void ShowPratos(List<Prato> pratos)
        {
            pratos = pratosController.ListarPratos();
            listPratos.DataSource = null;
            foreach (var prato in pratos)
            {
                listPratos.DataSource = pratos.ToList();
            }
        }

        private void PratosDoubleClick(object sender, EventArgs e)
        {
            Prato prato = (Prato)listPratos.SelectedItem;
            int idPrato = prato.id;
            txtDescricao.Text = prato.descricao;
            comboTipo.Text = prato.tipo;
            txtQuantidade.Text = quantidadePratosController.GetQuantidade(idPrato).ToString();
            id = pratosController.ProcurarPrato(txtDescricao.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarQuantidadePrato adicionar = new AdicionarQuantidadePrato();
            adicionar.Show();
            this.Close();
        }
    }
}
