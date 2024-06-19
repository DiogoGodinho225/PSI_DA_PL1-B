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
    public partial class AdicionarQuantidadePrato : Form
    {
        QuantidadePratosController quantidadePratosController;
        int idPrato, quantidade = 0, quantidadeAdicional = 0;
        PratosController pratosController;
        ProjetoContext context;
        List<Prato> pratos;

    
        public AdicionarQuantidadePrato()
        {
            InitializeComponent();
            context = new ProjetoContext();
            pratosController = new PratosController(context);
            pratos = pratosController.ListarPratos();
            listPratos.DataSource = null;
            quantidadePratosController = new QuantidadePratosController(context);
            textBoxQuantidade.Enabled = false;
            foreach (var prato in pratos)
            {
                listPratos.DataSource = pratos.ToList();
            }


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuPratos menupratos = new MenuPratos();
            menupratos.Show();
            this.Close();

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            quantidadeAdicional = int.Parse(txtAdicionar.Text);
            if (quantidadeAdicional != 0)
            {
                quantidadePratosController.AlterarQuantidade(idPrato, quantidadeAdicional);
                quantidade = quantidadePratosController.GetQuantidade(idPrato);
                textBoxQuantidade.Text = quantidade.ToString();
                txtAdicionar.Clear();
                pratosController.AlterarEstado(idPrato);
            }
        }

        private void QuantidadePratosDoubleClick(object sender, EventArgs e)
        {
            if (listPratos.SelectedItem != null && listPratos.SelectedItem is Prato prato)
            {
                idPrato = prato.id;
                quantidade = quantidadePratosController.GetQuantidade(idPrato);
                textBoxQuantidade.Text = quantidade.ToString();
            }
        }
    }
}
