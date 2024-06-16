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
using Projeto_DA.controladores;
using Projeto_DA.modelos;

namespace Projeto_DA.vistas
{
    public partial class AdicionarQuantidadeExtras : Form
    {

        QuantidadeExtrasController quantidadeExtrasController;
        int id_extra = 0, quantidade = 0, quantidadeAdicional = 0;
        ExtrasController extrasController;
        ProjetoContext context;
        List<Extra> extras;
        public AdicionarQuantidadeExtras()
        {
            InitializeComponent();
            context = new ProjetoContext();
            extrasController = new ExtrasController(context);
            extras = extrasController.ListarExtra();
            listExtras.DataSource = null;
            quantidadeExtrasController = new QuantidadeExtrasController(context);
            textBoxQuantidade.Enabled = false;
            foreach (var extra in extras)
            {
                listExtras.DataSource = extras.ToList();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menuextras menuextras = new Menuextras();
            menuextras.Show();
            this.Close();
        }


        private void QuantidadeExtraDoubleClick(object sender, EventArgs e)
        {
            if (listExtras.SelectedItem != null && listExtras.SelectedItem is Extra extra)
            {
                id_extra = extra.id;
                quantidade = quantidadeExtrasController.GetQuantidade(id_extra);
                textBoxQuantidade.Text = quantidade.ToString();
            }
        }


        private void Adicionar_Click(object sender, EventArgs e)
        {
            quantidadeAdicional = int.Parse(txtAdicionar.Text);
            if (quantidadeAdicional != null )
            {
                quantidadeExtrasController.AlterarQuantidade(id_extra, quantidadeAdicional);
                quantidade = quantidadeExtrasController.GetQuantidade(id_extra);
                textBoxQuantidade.Text = quantidade.ToString();
                txtAdicionar.Clear();
            }
        }

    }
}
