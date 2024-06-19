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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_DA
{
    public partial class Menuprincipal : Form
    {
        MenusController menusController;
        FuncionariosController funcionariosController;
        utilizadoresController utilizadoresController;
        ProjetoContext context;
        int id;
        bool VerificarFuncionario = false, menuencontrado = false;
        DateTime menuDiaEncontrado;
        List<Projeto_DA.modelos.Menu> menus;
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new ProjetoContext();
            funcionariosController = new FuncionariosController(context);
            utilizadoresController = new utilizadoresController(context);
            menusController = new MenusController(context);
            List<Funcionario> funcionarios = new List<Funcionario>();
            menus = new List<Projeto_DA.modelos.Menu>();
            funcionarios = funcionariosController.ListarFuncionario();
            listFuncionarios.DataSource = null;
            listFuncionarios.DataSource = funcionarios;
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            Menufuncionarios menufuncionarios = new Menufuncionarios();
            menufuncionarios.Show();

            this.Hide();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            VerificarFuncionario = utilizadoresController.ProcurarTipo(id);

            if (VerificarFuncionario == true)
            {
                Menuclientes clientes = new Menuclientes();
                clientes.Show();
                this.Hide();
            }
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

        private void btnreservas_Click(object sender, EventArgs e)
        {
            VerificarFuncionario = utilizadoresController.ProcurarTipo(id);

            if(VerificarFuncionario == true)
            {
                MenuReservas reservas = new MenuReservas();
                reservas.Show();
                this.Hide();
            }       
        }

        private void ListFuncionarios_doubleClick(object sender, EventArgs e)
        {
            Funcionario funcionario = (Funcionario)listFuncionarios.SelectedItem;
            id = funcionariosController.ProcurarFuncionario(funcionario.nif);
        }

        private void btnmultas_Click(object sender, EventArgs e)
        {
            MenuMultas multas = new MenuMultas();
            multas.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            menus = null;
            DateTime dataselecionada = dateTimePicker1.Value.Date;
            menus = menusController.procurarMenus(dataselecionada);
            if (menus != null)
            {
                menuencontrado = true;
            }
            else
            {
                menuencontrado = false;
            }

            if (menuencontrado == true)
            {
                Listmenu.DataSource = null;
                foreach (var menu in menus)
                {
                    Listmenu.DataSource = menus.ToList();
                }
            }
            else
            {
                MessageBox.Show("Não existem menus para esse dia", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listmenu.DataSource = null;
            }
        }
    }
}
