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
    public partial class CriarMenus : Form
    {
        List<Prato> pratos;
        List<object> listaMenus;
        ProjetoContext context;
        PratosController pratosController;
        MenusController menusController;
        public CriarMenus()
        {
            InitializeComponent();
            context = new ProjetoContext();
            pratosController = new PratosController(context);
            pratos = pratosController.ListarPratos();
            listaMenus = new List<object>();
            listPratos.DataSource = pratos.ToList();
          
        }

        private void pratosDoubleClick(object sender, EventArgs e)
        {
            Prato prato = (Prato)listPratos.SelectedItem;
            int id_Pratos = prato.id;
            pratos = pratosController.MoverPratos(id_Pratos);
            listaMenus.AddRange(pratos);
            listMenu.DataSource = null;
            listMenu.DataSource = listaMenus.ToList();
            menusController = new MenusController(context);
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            if (txtHora.Text.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var item in listaMenus) 
                {
                    if(item is Prato prato)
                    {
                        pratos.Add(prato);
                    }
     
                    else
                    {
                        MessageBox.Show("Itens não encontrados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                string datestring = dateTimeMenu.Value.ToShortDateString()+ " " + txtHora.Text;
                menusController.inserirMenus(DateTime.Parse(datestring), pratos);
            }
        }
    }
}
