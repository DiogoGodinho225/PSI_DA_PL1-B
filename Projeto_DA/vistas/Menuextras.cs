using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_DA.controladores;
using Projeto_DA.modelos;
using Projeto_DA.vistas;

namespace Projeto_DA
{
    public partial class Menuextras : Form
    {
        QuantidadeExtrasController quantidadeExtraController;
        ExtrasController extrasController;
        ProjetoContext context;
        int id;
        Menuprincipal menuprincipal;
        List<Extra> extras;

        public Menuextras()
        {
            InitializeComponent();
            context = new ProjetoContext();
            extrasController = new ExtrasController(context);
            quantidadeExtraController = new QuantidadeExtrasController(context);
            extras = extrasController.ListarExtra();
            txtQuantidade.Enabled = false;
            listExtras.DataSource = null;
            foreach (var extra in extras)
            {
                listExtras.DataSource = extras.ToList();
            }
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Length == 0 || txtPreco.Text.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                string descricao = txtDescricao.Text;
                float preco = float.Parse(txtPreco.Text);
                extrasController.InserirExtra(descricao, preco);
                List<Extra> listextras = new List<Extra>();
                ShowExtras(listextras);
                txtDescricao.Clear();
                txtPreco.Clear();
                txtQuantidade.Clear();
                txtQuantidade.Enabled = false;
            }
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            if (listExtras.SelectedItems == null)
            {
                MessageBox.Show("Selecione algum extra", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                extrasController.RemoverExtra(id);
                List<Extra> listextra = new List<Extra>();
                ShowExtras(listextra);
                txtDescricao.Clear();
                txtPreco.Clear();
                txtQuantidade.Clear();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (listExtras.SelectedItems == null)
            {
                MessageBox.Show("Selecione algum extra", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                float preco = float.Parse(txtPreco.Text);
                extrasController.AlterarExtra(id, txtDescricao.Text, preco);
                List<Extra> listExtras = new List<Extra>();
                ShowExtras(listExtras);
                txtDescricao.Clear();
                txtPreco.Clear();
                txtQuantidade.Clear();
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            menuprincipal = new Menuprincipal();
            menuprincipal.Show();
            this.Close();
        }

        private void ShowExtras(List<Extra> extras)
        {
            extras = extrasController.ListarExtra();
            listExtras.DataSource = null;
            foreach (var extra in extras)
            {
                listExtras.DataSource = extras.ToList();
            }
        }

        private void ExtrasDoubleClick(object sender, EventArgs e)
        {
            Extra extra = (Extra)listExtras.SelectedItem;
            int id_extra = extra.id;
            txtDescricao.Text = extra.descricaoExtra;
            txtPreco.Text = extra.precoExtra.ToString();
            txtQuantidade.Text = quantidadeExtraController.GetQuantidade(id_extra).ToString();
            string descricao = extra.descricaoExtra;
            id = extrasController.ProcurarExtra(descricao);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarQuantidadeExtras adicionarquantidade = new AdicionarQuantidadeExtras();
            adicionarquantidade.Show();
            this.Close();
        }
    }
}
