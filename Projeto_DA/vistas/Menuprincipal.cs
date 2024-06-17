using Projeto_DA.controladores;
using Projeto_DA.modelos;
using Projeto_DA.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class Menuprincipal : Form
    {
        FuncionariosController funcionariosController;
        ProjetoContext context;
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new ProjetoContext();
            funcionariosController = new FuncionariosController(context);
            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios = funcionariosController.ListarFuncionario();


            foreach(var funcionario in funcionarios)
            {
                listFuncionarios.Items.Add(funcionario);
            }
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            Menufuncionarios menufuncionarios = new Menufuncionarios();
            menufuncionarios.Show();

            this.Hide();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Menuclientes menuclientes = new Menuclientes();
            menuclientes.Show();
            this.Hide();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            CriarMenus criarMenus = new CriarMenus();
            criarMenus.Show();
            this.Hide();
        }

        private void btnextras_Click(object sender, EventArgs e)
        {
            Menuextras menuextras = new Menuextras();
            menuextras.Show();
            this.Hide();
        }

        private void btnpratos_Click(object sender, EventArgs e)
        {
            MenuPratos menupratos = new MenuPratos();
            menupratos.Show();
            this.Hide();
        }
    }
}
