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
        List<Extra> extras;
        List<Prato> pratos;
        List<object> listaMenus;
        ProjetoContext context;
        ExtrasController extrasController;
        PratosController pratosController;
        MenusController menusController;
        public CriarMenus()
        {
            InitializeComponent();
            context = new ProjetoContext();
            extrasController = new ExtrasController(context);
            pratosController = new PratosController(context);
            extras = extrasController.ListarExtra();
            pratos = pratosController.ListarPratos();
            listaMenus = new List<object>();
            listPratos.DataSource = pratos.ToList();
            listExtras.DataSource = extras.ToList();
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

        private void extraDoubleClick(object sender, EventArgs e)
        {
            Extra extra = (Extra)listExtras.SelectedItem;
            int id_Extra = extra.id;
            extras = extrasController.MoverExtras(id_Extra);
            listaMenus.AddRange(extras);
            listMenu.DataSource = null;
            listMenu.DataSource = listaMenus.ToList();
        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            if (txtHora.Text.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 

                //menusController.inserirMenus(,);
                List<Professor> listprofessor = new List<Professor>();                  
            }
        }
    }
}
