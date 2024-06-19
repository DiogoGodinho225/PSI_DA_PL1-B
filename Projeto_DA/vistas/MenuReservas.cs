using Projeto_DA.controladores;
using Projeto_DA.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_DA.vistas
{
    public partial class MenuReservas : Form
    {
        ProjetoContext context;
        ExtrasController extrasController;
        QuantidadeExtrasController quantidadeExtraController;
        QuantidadePratosController quantidadePratosController;
        ProfessorController professorController;
        EstudantesController estudantesController;
        MenusController menusController;
        PratosController pratosController;
        ReservaController reservaController;
        FaturaController faturaController;
        SaldoController saldoController;
        List<Extra> extras;
        List<Projeto_DA.modelos.Menu> menus;
        List<Extra> extraSelecionado;
        List<Extra> extraInserir;
        List<Professor> professores;
        List<Estudante> estudantes;
        List<Prato> pratos;
        Prato pratoReserva;
        Projeto_DA.modelos.Menu menuReserva;
        Cliente clienteReserva;
        Reserva reserva;
        bool menuencontrado = false;
        int idCliente, idPrato, idExtra;
        string cliente;
        string clienteNif;
        DateTime menuDiaEncontrado;
        float precoEstudante = (float)2.80, precoProfessor = (float)2.50, precoTotal = 0;
        
        

        public MenuReservas()
        {
            InitializeComponent();
            context = new ProjetoContext();
            extraSelecionado = new List<Extra>();
            extrasController = new ExtrasController(context);
            quantidadeExtraController = new QuantidadeExtrasController(context);
            quantidadePratosController = new QuantidadePratosController(context);
            menusController = new MenusController(context);
            professorController = new ProfessorController(context);
            estudantesController = new EstudantesController(context);
            pratosController = new PratosController(context);
            reservaController = new ReservaController(context);
            faturaController = new FaturaController(context);
            saldoController = new SaldoController(context);
            pratos = new List<Prato>();
            extras = extrasController.ListarExtra();
            listExtras.DataSource = null;
            listExtras.DataSource = extras;
            professores = new List<Professor>();
            extraInserir = new List<Extra>();
            professores = professorController.ListarProfessor();
            listProfessores.DataSource = professores.ToList();
            estudantesController = new EstudantesController(context);
            estudantes = new List<Estudante>();
            estudantes = estudantesController.ListarEstudante();
            listEstudantes.DataSource = estudantes.ToList();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dataAtual = dateTimeDia.Value.Date;
            int menuId = menusController.ProcurarMenuData(dataAtual);

            if (menuId == 0)
            {
                MessageBox.Show("Não há menu disponível para hoje.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var menu = menusController.ObterMenuPorId(menuId);

            string tipoPrato = comboTipo.SelectedItem.ToString();

            if (menu != null)
            {
                pratos = pratosController.ProcurarPratoTipo(tipoPrato);
                listMenu.DataSource = null;
                listReservas.Items.Clear();

                foreach (var prato in pratos)
                {
                    listMenu.DataSource = pratos.ToList();
                    pratoReserva = prato;
                    listReservas.Items.Add(prato);
                    idPrato = prato.id;
                }
            }
            else
            {
                MessageBox.Show("Não foi possível obter o menu.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            float saldoatual = saldoController.GetSaldo(idCliente);
            float saldoConta = saldoatual - precoTotal;
            bool saldo = saldoController.TirarSaldo(idCliente, saldoConta);

            int qntatual = quantidadePratosController.GetQuantidade(idPrato);
            int qntPrato = qntatual - 1;
            quantidadePratosController.TirarQuantidadePrato(idPrato, qntPrato);
             
            for(int i = 0; i < extraInserir.Count; i++)
            {
                int qntatualExtras = quantidadeExtraController.GetQuantidade(extraSelecionado[i].id);
                int qntExtra = qntatualExtras - 1;
                quantidadeExtraController.TirarQuantidadeExtra(extraSelecionado[i].id, qntExtra);             
            }
            
            if (saldo == true)
            {
                reserva = reservaController.CriarReserva(pratoReserva, clienteReserva, menuReserva);
                if(reserva != null)
                {
                    MessageBox.Show("entrei");
                    reservaController.CriarExtrasReserva(extraInserir, reserva);
                }
                listReservas.DataSource = null;
                precoTotal = 0;
                labelPrecoTotal.Text = "0";
            }
            else
            {
                MessageBox.Show("Não tem dinheiro para a reserva", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dateTimeDia_ValueChanged(object sender, EventArgs e)
        {
            menus = null;
            DateTime dataselecionada = dateTimeDia.Value.Date;
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
                listMenu.DataSource = null;
                foreach (var menu in menus)
                {
                    listMenu.DataSource = menus.ToList();
                    menuReserva = menu;
                }
            }
            else
            {
                MessageBox.Show("Não foram encontrados menus para esse dia", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menuprincipal menuprincipal = new Menuprincipal();
            menuprincipal.Show();
            this.Close();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            precoTotal = 0;
            labelPrecoTotal.Text = "0";
            listReservas.Items.Clear();
            extraSelecionado.Clear();
            extraInserir.Clear(); 
        }

        private void ReservaEstudantesDoubleClick(object sender, EventArgs e)
        {
            if (listEstudantes.SelectedItem != null)
            {
                Estudante estudante = (Estudante)listEstudantes.SelectedItem;
                labelPrecoTotal.Text = precoEstudante.ToString() + " € ";
                precoTotal += precoEstudante;
                clienteReserva = estudante;
                cliente = estudante.nome_Utilizador;
                clienteNif = estudante.nif;
                idCliente = estudante.id;
                listReservas.DataSource = null;
            }
        }

        private void btnVerificarReservas_Click(object sender, EventArgs e)
        {
            VerificarReservas verificarReservas = new VerificarReservas();
            verificarReservas.Show();
            this.Close();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        { 
            faturaController.GuardarFatura(precoTotal, DateTime.Now, extraSelecionado, menuReserva);
            GerarFatura();
        }

        private void ReservaExtrasDoubleClick(object sender, EventArgs e)
        {
            if (listExtras.SelectedItem != null)
            {
                if (extraInserir.Count >= 3)
                {
                    MessageBox.Show("Não pode inserir mais de 3 extras", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Extra extraListSelecionado = (Extra)listExtras.SelectedItem;
                extraSelecionado.Add(extraListSelecionado);
                float precoExtra = extraListSelecionado.precoExtra;
                bool isExtraAvailable = false, estado = false;
                foreach (var extra in extraSelecionado)
                {
                    if (extraSelecionado.Contains(extraListSelecionado))
                    {
                        estado = extrasController.verificarEstado(extra.id);
                        if (estado == true)
                        {
                            isExtraAvailable = true;
                        }
                    }
                    
                }

                if (isExtraAvailable == true)
                {
                    precoTotal += precoExtra;
                    extraInserir.Add(extraListSelecionado);
                    listReservas.Items.Add(extraListSelecionado);
                    labelPrecoTotal.Text = precoTotal.ToString() + " €";
                }
            }
        }

        private void ReservaProfessoresDoubleClick(object sender, EventArgs e)
        {
            if(listProfessores.SelectedItem != null)
            {
                Professor professor = (Professor)listProfessores.SelectedItem;
                labelPrecoTotal.Text = precoProfessor.ToString() + " € ";
                precoTotal += precoProfessor;
                clienteReserva = professor;
                cliente = professor.nome_Utilizador;
                clienteNif = professor.nif;
                idCliente = professor.id;
                listReservas.DataSource = null;
            }
        }

        public void GerarFatura()
        {
            Utilizador utilizador = new Utilizador();
            string nomeFicheiro = cliente + " " + clienteNif + ".pdf";
            FileStream fs = new FileStream(nomeFicheiro, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(cliente + "(" + clienteNif + ") em " + DateTime.Now.ToString("dd / MM / yyyy HH: mm:ss"));
            sw.WriteLine("_______________________________________________________________________________");
            sw.WriteLine("Fatura de Reserva");
            sw.WriteLine($"Total: {precoTotal}");
            sw.WriteLine($"Prato: {pratoReserva.descricao}");
            foreach ( var item in extraSelecionado)
            {
                sw.WriteLine($"Extra: {item.descricaoExtra}");
                sw.WriteLine($"Preço Extra: {item.precoExtra}");
            }    
            sw.Close();
            fs.Close();
            MessageBox.Show("Ficheiro exportado com sucesso");
        }
    }
}
